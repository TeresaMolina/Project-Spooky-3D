using UnityEngine;
using UnityEngine.Analytics;

public class GeneratorController : MonoBehaviour
{
    public Light lightToTurnOn;
    public AudioSource activationSound;
    public GeneratorManager manager;

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
            if (manager != null) 
            {
                manager.GeneratorActivated();            
            }
    Debug.Log("Generator Activated");
        }
    }
}
