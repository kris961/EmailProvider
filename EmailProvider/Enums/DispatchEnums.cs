﻿//Includes

namespace EmailServiceIntermediate.Enums
{
    //------------------------------------------------------
    //	DispatchEnums
    //------------------------------------------------------

    /// <summary> Кодове за идентифициране на RPC Request-ите </summary>
    public enum DispatchEnums : short
    {
        Empty = 0,
        Login,
        Register,
        SetUpProfile,
        GetCountries,
        SendEmail,
        GetEmail,
        DeleteEmails,
        ReceiveEmails,
        LoadIncomingEmails,
        LoadOutgoingEmails,
        LoadDrafts,
        LoadEmailsByFolder,
        LoadFolders,
        AddFolder,
    }
}
