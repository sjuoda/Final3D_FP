using UnityEngine;

public class LetterCollector : MonoBehaviour
{
    public int lettersCollected = 0;
    public int totalLetters = 4;
    public DoorOpener door; // assign in Inspector

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Letter"))
        {
            lettersCollected++;
            Destroy(other.gameObject);

            if (lettersCollected == totalLetters)
            {
                door.OpenDoor();
            }
        }
    }
}