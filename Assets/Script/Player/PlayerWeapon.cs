using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other);
        }

        switch (other.tag)
        {
            case "Tower 1":
                TowerTrigger.OnGlassStage = 1;
                Destroy(other);
                break;
            case "Tower 2":
                TowerTrigger.OnGlassStage = 2;
                Destroy(other);
                break;
            case "Tower 3":
                TowerTrigger.OnGlassStage = 3;
                Destroy(other);
                break;
            case "Tower 4":
                TowerTrigger.OnGlassStage = 4;
                Destroy(other);
                break;
        }  
    }
}
