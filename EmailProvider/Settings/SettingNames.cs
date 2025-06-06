﻿//Includes

namespace EmailServiceIntermediate.Settings
{
    //------------------------------------------------------
    //	SectionNames
    //------------------------------------------------------

    /// <summary> Секции в ini file </summary>
    public static class SectionNames
    {
        public const string _sectionServer = "SERVER";
        public const string _sectionClient = "CLIENT";
        public const string _sectionShared = "SHARED";
    }

    //------------------------------------------------------
    //	SettingsNames
    //------------------------------------------------------

    /// <summary> настройки в ini file </summary>
    public static class SettingsNames
    {
        public const string _paramLogFilePath = "FileLogPath";
        public const string _paramServerName = "ServerName";
        public const string _paramDatabaseName = "DataBaseName";
        public const string _paramServerIP = "ServerIP";
        public const string _paramServerPort = "ServerPort";
    }
}
