using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "VoidGameEvent", menuName = "so-event-system/VoidGameEvent", order = 0)]
public class VoidGameEvent : ScriptableObject
{
    private List<VoidEventListener> _listeners = new List<VoidEventListener>();

    public void Raise()
    {
        // Iterate backwards to avoid null references that may occur when iterating foward
        for( int i = _listeners.Count; i >= 0; i-- )
        {
            _listeners[ i ].RaiseEvent();
        }
    }

    public void RegisterListener( VoidEventListener listener )
    {
        _listeners.Add( listener );
    }

    public void UnregisterListener( VoidEventListener listener )
    {
        _listeners.Remove( listener );
    }
}