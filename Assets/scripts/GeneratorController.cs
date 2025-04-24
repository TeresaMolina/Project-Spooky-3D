using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public Light lightToTurnOn;
    public AudioSource activationSound; // <-- find later

    private bool isActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isActivated)
        {
            isActivated = true;
            if (lightToTurnOn != null)
            {
                lightToTurnOn.enabled = true;
            }
            if (activationSound != null)
            {
                activationSound.Play();
            }
    Debug.Log("Generator Activated");
        }
    }
}
