using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Vector3 openOffset = new Vector3(0f, 0f, -3f); // Slide 2 units to the right
    private bool isOpen = false;

    public void OpenDoor()
    {
        // Debug.Log("OpenDoor() called, door position before: " + transform.position);
        // transform.position += openOffset;
        // Debug.Log("Door position after: " + transform.position);

        if (!isOpen)
        {
            transform.position += openOffset;
            isOpen = true;
        }
    }
}