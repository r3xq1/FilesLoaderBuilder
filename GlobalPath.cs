namespace GameOverLoaderBuilder
{
    #region Зависимости

    using System;
    using System.Reflection;

    #endregion

    public static class GlobalPath
    {
        public const string KEY = "r3Net";
        public static readonly string CurrDir = Environment.CurrentDirectory, // bin\Release
        StartupPath = FileManager.GetDirName(AssemblyPath),
        DesktopDir = FileManager.CombinePath(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)),
        GetFileName = FileManager.GetFileName(AppDomain.CurrentDomain.FriendlyName), // GameOverLoaderBuilder.exe
        AssemblyPath = Assembly.GetExecutingAssembly().Location; // bin\Release\GameOverLoaderBuilder.exe
    }
}