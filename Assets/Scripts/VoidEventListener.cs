using UnityEngine;
using UnityEngine.Events;

public class VoidEventListener : MonoBehaviour
{
    /// <summary>
    /// The ScriptableObject event to listen to.
    /// </summary>
    [SerializeField] public VoidGameEvent Event;
    
    /// <summary>
    /// The UnityEvent to invoke when the assigned event is raised.
    /// </summary>
    [SerializeField] public UnityEvent OnEventRaised;

    private void OnEnable()
    {
        if( Event == null )
        {
            return;
        }
        Event.RegisterListener( this );
    }

    private void OnDisable()
    {
        if( Event == null )
        {
            return;
        }
        Event.UnregisterListener( this );
    }
    
    public void RaiseEvent()
    {
        OnEventRaised?.Invoke();
    }
}