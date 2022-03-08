using UnityEngine;

public class NotificationManager : MonoBehaviour
{
    public static NotificationManager Instance;

    [SerializeField] private Notification[] _notificationPrefab;  

    [SerializeField] private GameObject _notificationsContainer;
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CreateNotification(NotificationDataSO data)
    {
        var type = data.notificationType;

        var notification = FindNotificationPrefab(type);

        if (notification)
        {
            var newNot = Instantiate(notification, _notificationsContainer.transform);
            newNot.Initialize(data);
        }
    }

    private Notification FindNotificationPrefab(NotificationType type)
    {
        Notification notification = null;
        
        foreach (var prefab in _notificationPrefab)
        {
            if (prefab.GetNotificationType() == type)
            {
                notification = prefab;
            }
        }
        return notification;
    }
    
    

    private void OnEnable()
    {
        if (!_notificationsContainer)
        {
            _notificationsContainer = GameObject.Find("Notification Container");
        }
    }
}

public enum NotificationType
{
    Item,
    Quest,
    WorldEvent
};
