using System.Collections.Generic;
using UnityEngine;

public class WheelbarrowChecker : MonoBehaviour
{
    public List<string> requiredTags = new List<string> { "item1", "item2", "item3" };
    public GameObject wall;
    private bool completed = false;
    private HashSet<string> itemsInBarrow = new HashSet<string>();

    void OnTriggerEnter(Collider other)
{
    if (requiredTags.Contains(other.tag))
    {
        itemsInBarrow.Add(other.tag);
        CheckItems();
    }
}

void CheckItems()
{
    foreach (string tag in requiredTags)
    {
        if (!itemsInBarrow.Contains(tag))
            return;
    }

    AllItemsInBarrow();
}

void AllItemsInBarrow()
{
    if (completed) return;

    completed = true;
    Debug.Log("All items collected! Removing wall...");
    Destroy(wall);
}
}