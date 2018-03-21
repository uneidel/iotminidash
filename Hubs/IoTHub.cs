using Microsoft.AspNet.SignalR;

namespace iotminidash.Hubs
{
    public class IoTHub : Hub
    {
        public void IoTHubNotification(string value)
        {
            Clients.All.iotHubNotification(value);
        }
    }
}