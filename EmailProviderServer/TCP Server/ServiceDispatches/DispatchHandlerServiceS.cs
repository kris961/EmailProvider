﻿using EmailServiceIntermediate.Dispatches;
using EmailServiceIntermediate.Logging;
using System.Net.Sockets;

namespace EmailProviderServer.ServiceDispatches
{
    public class DispatchHandlerServiceS
    {
        public async Task<bool> Execute(SmartStreamArray inPackage, SmartStreamArray outPackage)
        {
            try
            {
                using TcpClient client = new TcpClient();
                client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);

                using var cts = new CancellationTokenSource(5000);
                await client.ConnectAsync(AddressHelper.GetSMTPIpAddress(), AddressHelper.GetSMTPPrivatePort(), cts.Token);
                using var stream = client.GetStream();
                stream.Flush();

                SmartStreamArray finalPackage = new();
                finalPackage.Serialize("");

                finalPackage.Append(inPackage);

                byte[] requestData = finalPackage.ToByte();
                await stream.WriteAsync(requestData, 0, requestData.Length);

                outPackage.LoadFromStream(stream);

                bool result = false;
                outPackage.Deserialize(out result);

                if (!result)
                {
                    string error = "";
                    outPackage.Deserialize(out error);
                    Logger.LogSilent(!string.IsNullOrWhiteSpace(error) ? error : LogMessages.InteralError);
                    return false;
                }

                stream.Flush();

                return true;
            }
            catch (Exception ex)
            {
                Logger.LogSilent(LogMessages.InteralError);
                return false;
            }
        }
    }
}
