using System.Threading.Tasks;
using TwitchBotApi.Models;

namespace TwitchBotApi.Services
{
    public class Processor
    {
        public Processor() { }

        public async Task<string> Process(TwitchMessage message)
        {
            var processTask = Task.Run(() =>
            {
                if (message.Message == "hello")
                {
                    return $"Hi there {message.Username}";
                }

                return null;
            });

            var result = await processTask;

            return result;
        }
    }
}