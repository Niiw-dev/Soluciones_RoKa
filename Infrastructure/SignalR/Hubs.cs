using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace RoKa.Infrastructure.SignalR
{
    public class EmailNotificationHub : Hub
    {
        public async Task NotifyEmailSent(string message)
        {
            await Clients.All.SendAsync("ReceiveEmailNotification", message);
        }
    }
}