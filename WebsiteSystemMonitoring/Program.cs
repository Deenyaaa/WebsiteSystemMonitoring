using static WebsiteSystemMonitoring.TelegramBot.BotInit;
using static WebsiteSystemMonitoring.SystemLogic.WebSiteAlive;

namespace WebSiteSystemMonitoring;

public class Program
{
    public static async Task Main()
    {
        InitBot();
        await IsWebSiteAlive();
    }
}
