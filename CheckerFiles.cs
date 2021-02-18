namespace GameOverLoaderBuilder
{
    #region Зависимости
    using System;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    #endregion

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public static class CheckerFiles
    {
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error) => error == SslPolicyErrors.None;
        public static async Task Loader(string link, Label message)
        {
            if (!string.IsNullOrWhiteSpace(link))
            {
                string filename = FileManager.GetFileName(link); // Получаем имя файла из ссылки
                string fullpath = FileManager.CombinePath(GlobalPath.CurrDir, filename); // Соединяем путь и имя файла

                if (!FileManager.ExistsFile(fullpath))
                {
                    try
                    {
                        var url = new Uri(link, UriKind.Absolute);
                        using var client = new WebClient();
                        if (!client.IsBusy)
                        {
                            // Установка сертификата для успешной загрузки файл(а)ов
                            ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12;
                            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36 OPR/49.0.2725.64");
                            client.Proxy = null;
                            try
                            {
                                await client?.DownloadFileTaskAsync(url, fullpath);
                                var file = new FileInfo(fullpath);
                                if (file.Length > 0)
                                {
                                    message.Location = new Point(505, 371);
                                    ControlActive.CheckMessage(message, "Файл загружен успешно!", Color.FromKnownColor(KnownColor.MenuHighlight), 4000);
                                }
                                else
                                {
                                    message.Location = new Point(505, 371);
                                    ControlActive.CheckMessage(message, "Файл повреждён, имеет 0 байтов!", Color.FromKnownColor(KnownColor.MenuHighlight), 4000);
                                }
                            }
                            catch (WebException)
                            {
                                FileManager.DeleteFile(fullpath);
                                message.Location = new Point(505, 371);
                                ControlActive.CheckMessage(message, "Ошибка загрузки файла!", Color.FromKnownColor(KnownColor.MenuHighlight), 4000);
                            }
                        }
                    }
                    catch (Exception ex) { throw new Exception("WebClient error: ", ex); }
                }
                else
                {
                    message.Location = new Point(505, 371);
                    ControlActive.CheckMessage(message, "Файл уже существует!", Color.FromKnownColor(KnownColor.MenuHighlight), 4000);
                }
            }
        }
        public static bool URLExists(string url, Label message)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    var link = new Uri(url, UriKind.Absolute);
                    var webRequest = WebRequest.Create(link);
                    webRequest.Timeout = 1200;
                    webRequest.Method = "HEAD";
                    webRequest?.GetResponse();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
    }
}