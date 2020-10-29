using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "VoidGameEvent", menuName = "so-event-system/VoidGameEvent", order = 0)]
public class VoidGameEvent : ScriptableObject
{
    public UnityAction EventRaised;

    public void Raise()
    {
        EventRaised?.Invoke();
    }
}