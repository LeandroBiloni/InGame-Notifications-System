# InGame Notifications System
 Basic System to show In Game notifications

This system will let you create notifications to show in your UI.

HOW TO USE IT

- Create a container in your Canvas where notifications will be shown.

- Create a Prefab for your notifications and add the "Notification" script (can be modified to add or remove elements for your notification).

- Select a notification type (types can be added or removed in "NotificationManager.cs").

- Create and add the NotificationDataSO to the object you want to be able to create a notification (the script must have a NotificationData field for the data).

- Add the "NotificationManager" script to a GameObject then add your notifications prefabs.

- Then in the script you want to create a notification just call NotificationManager.Instance.CreateNotification and pass it the NotificationDataSO it should read to create the notification.
