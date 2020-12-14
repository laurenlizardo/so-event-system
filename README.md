# Implementing an Event System using ScriptableObjects

Source - [Unity.com: Three ways to architect your game with ScriptableObjects](https://unity.com/how-to/architect-game-code-scriptable-objects#architect-events)
Inspiration - [Unity Open Project: Chop Chop](https://github.com/UnityTechnologies/open-project-1)

## How it works

From Unity:

"Event architectures help modularize your code by sending messages
between systems that do not directly know about each other. They allow 
things to respond to a change in a state without constantly monitoring 
it in an update loop.

"An example Event system consists of two parts: an Event ScriptableObject
and an EventListener MonoBehaviour. Designers can create any number of 
Events in the project to represent important messages that can be sent.
An EventListener waits for a specific Event to be raised and responds by 
invoking a UnityEvent (which is not a true event, but more of a serialized
function call."

## The ScriptableObject event

### The parts of the event
* A list containing its listeners
* A method to add a listener to its list
* A method to remove a listener from its list
* A method to iterate through the list and call each listener's function
that would invoke their assigned responses

(Note: This is the observer pattern!)

## The event listener

### The parts of the event listener
* A field to store the event the listener is listening to
* A UnityEvent to invoke
* MonoBehaviour's OnEnable method to call the event's register method
* MonoBehaviour's OnDisable method to call the event's unregister method
* A public method from which the UnityEvent will be invoked when the event 
is triggered

## Setup

### How to set up the event

1. In the Unity editor, go to Assets > Create > Events and select VoidEvent.
2. Name the newly created Void Event and press Enter.

### How to set up the event listener

1. Attach the VoidEventListener script to an existing object in the scene. This
object would ideally have a script already attached to it.
2. Drag and drop the desired VoidEvent ScriptableObject from the Assets folder
into the Event field of the VoidEventListener script.
3. Click the + icon under the OnEventRaised() section.
4. Select the object the VoidEventListener script is attached to and drag it
into the empty field under OnEventRaised().
5. In the dropdown menu to the right, select the component and the method you
wish to call when the event is raised.

### How to raise the event using a button

1. Right-click in the Hierarchy and go to UI > Button to create a button.
2. With the button selected, drag and drop the VoidEvent ScriptableObject into
the empty field under OnClick().
3. In the dropdown menu to the right, select the Raise() method.

### How to raise the event from another object

1. In an existing MonoBehaviour script, add a field for a VoidEvent.
2. Inside an existing method, call the VoidEvent's Raise() method.
3. In the editor, select the object containing that MonoBehaviour script
and drag and drop the desired VoidEvent ScriptableObject from the Assets folder
into the newly created field.