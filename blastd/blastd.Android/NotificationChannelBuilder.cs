using System;
using Android.App;

namespace blastd.Droid
{
    public class NotificationChannelBuilder
    {
        public static NotificationChannel MakeGeneralChannel()
        {
            string channel = "com.company.blastd.urgent";
            string channelName = "Urgent";
            var importance = NotificationImportance.High;
            return new NotificationChannel(channel, channelName, importance);
        }
    }
}