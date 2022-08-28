using System.Net;
using static WebsiteSystemMonitoring.TelegramBot.BotInit;

namespace WebsiteSystemMonitoring.SystemLogic
{
    class WebSiteAlive
    {
        public static async Task IsWebSiteAlive()
        {
            string[] urls = { /*Your website list*/ };

            while (true)
            {
                foreach (var url in urls)
                {
                    bool isAlive = await GetStatusSuccessAsync(url);

                    if (!isAlive)
                    {
                        string messageReason = $"Service by [{url}] not responding.";
                        SendMessage(messageReason);
                    }
                        await Task.Delay(5000);
                }
            }

        }

        private static async Task<bool> GetStatusSuccessAsync(string url)
        {
            HttpClient client = new HttpClient();
            var responce = await client.GetAsync(url);
            return responce.StatusCode == HttpStatusCode.OK;
        }

    }
}
