using UnityEngine;

[CreateAssetMenu(fileName = "World Event", menuName = "World Event")]
public class WorldEventSO : ScriptableObject, INotificate
{
    [SerializeField] private NotificationDataSO _notificationData;

    public NotificationDataSO GetNotificationData()
    {
        return _notificationData;
    }
}