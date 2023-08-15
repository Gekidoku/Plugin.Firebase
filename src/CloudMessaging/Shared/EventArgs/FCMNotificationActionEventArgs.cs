namespace Plugin.Firebase.CloudMessaging.EventArgs
{
    public sealed class FCMNotificationActionEventArgs
    {
        public FCMNotificationActionEventArgs(FCMNotification notification)
        {
            Notification = notification;
        }

        public FCMNotification Notification { get; }
    }
}