using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class ItemSO : ScriptableObject, INotificate
{
    [SerializeField] private string _name;
    [SerializeField] private float _buildTime;
    [SerializeField] private NotificationDataSO _notificationData;

    public string GetItemName()
    {
        return _name;
    }

    public float GetItemBuildTime()
    {
        return _buildTime;
    }

    public NotificationDataSO GetNotificationData()
    {
        return _notificationData;
    }
}