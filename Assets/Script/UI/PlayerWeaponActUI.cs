using UnityEngine;
using UnityEngine.UI;

public class PlayerWeaponActUI : MonoBehaviour
{
    Image PlayerWeaponActImage;

    private void Awake()
    {
        PlayerWeaponActImage = GetComponent<Image>();
    }

    private void Update()
    {
        PlayerWeaponActImage.fillAmount = ActiveWeapon.WeaponShoot / 100;
    }
}
