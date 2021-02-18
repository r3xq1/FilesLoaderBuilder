namespace GameOverLoaderBuilder
{
    using System.Reflection;
    using System.Runtime.InteropServices;

    /*
         Created by r3xq1
         https://github.com/r3xq1/
         Telegram: https://t.me/r3xq1
         BTC: 1CFk2hvtYWPKsyqLHjtidJ71qNsrHeAt3U  - Поддержи кодера.
     */

    public static class MutEx
    {
        public static string GetGUID()
        {
            Assembly assembly = typeof(Program).Assembly;
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            return attribute.Value?.ToUpper();
        }
    }
}