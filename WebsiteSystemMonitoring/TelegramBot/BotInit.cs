using Telegram.Bot;

namespace WebsiteSystemMonitoring.TelegramBot
{
    internal class BotInit
    {
        private static string Token { get; set; } = /*Your Telegram token*/;
        public static string[] ChatIds = { /*Your chatId*/ };
        private static TelegramBotClient? BotClient;

        public static void InitBot()
        {
            BotClient = new TelegramBotClient(Token);
        }

        public static void SendMessage(string messageReason)
        {
            foreach (var chatId in ChatIds)
            {
                BotClient.SendTextMessageAsync(chatId, messageReason);
            }
        }
    }
}
