using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace ErgastBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

             // return our reply to the user
            await context.PostAsync($"\"{activity.Text}\" si tu veux mais j'ai pas trop envie de parler (je suis surtout encore trop con pour ca...)");

            context.Wait(MessageReceivedAsync);
        }
    }
}