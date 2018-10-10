using Microsoft.Azure.NotificationHubs;

namespace blastd_server.Notifications
{
    public class NotificationHubWrapper
    {
        private NotificationHubClient client =
            NotificationHubClient.CreateClientFromConnectionString(Constants.Signature,
                blastd.Constants.NotificationHubName);

        public void BuildNotification()
        {
            // So close!
            //client.CreateGcmNativeRegistrationAsync()
        }
    }
}