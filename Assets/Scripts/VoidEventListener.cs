using UnityEngine;
using UnityEngine.Events;

public class VoidEventListener : MonoBehaviour
{
    // The Scriptable Object whose UnityAction to listen to
    public VoidGameEvent VoidGameEvent;

    // The UnityEvent attached to this MonoBehaviour.
    // This acts as an intermediary between the provided UnityAction and the action to take place.
    public UnityEvent OnEventRaised;

    // Add the listener RaiseEvent() to VoidGameEvent (only if it's null).
    private void OnEnable()
    {
        if( VoidGameEvent == null )
        {
            return;
        }
        VoidGameEvent.EventRaised += RaiseEvent;
    }

    // Remove the listener RaiseEvent() for VoidGameEvent (only if it's null).
    private void OnDisable()
    {
        if( VoidGameEvent == null )
        {
            return;
        }
        VoidGameEvent.EventRaised -= RaiseEvent;    
    }

    // Invoke the UnityEvent.
    public void RaiseEvent()
    {
        OnEventRaised?.Invoke();
    }
}