using System;
using System.Security.Cryptography.X509Certificates;

namespace AsyncDemo1
{
    class Program
    {
        static async Task Main(string[] args)
        {
          string html=  await DownloadHtmlAsync("https://www.apple.com", @"d:\AspDemo\Async\AppleHtml.txt");
            Console.WriteLine(html);

        }







        public static async Task<string> DownloadHtmlAsync(string url, string filename)
        {
            using (HttpClient HttpClient = new HttpClient())
            {

               string html = await HttpClient.GetStringAsync(url);
                await File.WriteAllTextAsync(filename, html);
                    return html;
            }

        }
    }
    }