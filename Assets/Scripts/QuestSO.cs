using UnityEngine;

[CreateAssetMenu(fileName = "Quest", menuName = "Quest")]
public class QuestSO : ScriptableObject, INotificate
{
    [SerializeField] private NotificationDataSO _notificationData;

    public NotificationDataSO GetNotificationData()
    {
        return _notificationData;
    }
}