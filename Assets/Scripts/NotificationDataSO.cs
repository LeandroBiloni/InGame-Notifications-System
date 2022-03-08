using UnityEngine;

[CreateAssetMenu(fileName = "Notification Data", menuName = "Notification Data")]
public class NotificationDataSO : ScriptableObject
{
    public NotificationType notificationType;
    
    public string message;

    public Color textColor;

    public Sprite icon;
    
    public Sprite background;
    
    public Color backgroundColor;

    public float showTime;
    
    public float fadeSpeed;
}
