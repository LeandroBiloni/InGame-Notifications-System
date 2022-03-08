using System.Collections.Generic;
using UnityEngine;

public class SpawnTest : MonoBehaviour
{
    public List<ItemSO> items = new List<ItemSO>();
    public List<QuestSO> quests = new List<QuestSO>();
    public List<WorldEventSO> events = new List<WorldEventSO>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var random = Random.Range(0, 3);

            switch (random)
            {
                case 0:
                    var randomItem = Random.Range(0, items.Count);
                    NotificationManager.Instance.CreateNotification(items[randomItem].GetNotificationData());
                    break;
                
                case 1:
                    var randomQuest = Random.Range(0, quests.Count);
                    NotificationManager.Instance.CreateNotification(quests[randomQuest].GetNotificationData());
                    break;
                
                case 2:
                    var randomEvent = Random.Range(0, events.Count);
                    NotificationManager.Instance.CreateNotification(events[randomEvent].GetNotificationData());
                    break;
                    
            }
        }
    }
}