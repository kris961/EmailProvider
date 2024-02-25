﻿//Includes

namespace EmailProviderServer.DBContext.Services.Base
{
    public interface IFileService
    {
        IEnumerable<T> GetAll<T>(int? nCount = null);

        T GetById<T>(int nId);
    }
}