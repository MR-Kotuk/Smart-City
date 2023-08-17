using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject FlashLight;
    public AudioSource SFXFlashlight;

    public static bool ActiveLightSc = false;
    private bool ActiveLight = false;

    private void FixedUpdate()
    {
        if (ActiveLight == true && ActiveLightSc == true)
        {
            FlashLight.SetActive(true);
        }
        else
            FlashLight.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            SFXFlashlight.Play();
            if (ActiveLight == true)
            {
                ActiveLight = false;
            }
            else if (ActiveLight == false)
            {
                ActiveLight = true;
            }
        }
    }
}
