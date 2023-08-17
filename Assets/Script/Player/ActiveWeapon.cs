using System.Collections;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{
    public GameObject Weapon;
    public AudioSource SFXWeapon;
    public static float WeaponShoot;
    private bool WeaponShootAct;
    private void Awake()
    {
        WeaponShootAct = true;
        WeaponShoot = 100;
        StartCoroutine(ReturnWeapon());
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && WeaponShoot > 0)
        {
            SFXWeapon.Play();
            Flashlight.ActiveLightSc = false;
            WeaponShoot -= 0.5f;
            Weapon.SetActive(true);
        }
        else
        {
            Flashlight.ActiveLightSc = true;
            Weapon.SetActive(false);
        }
            
    }

    private IEnumerator ReturnWeapon()
    {
        while (WeaponShootAct)
        {
            yield return new WaitForSeconds(0.1f);
            if (WeaponShoot <= 99)
            {
                WeaponShoot += 0.1f;
            }
        }
    }
}
