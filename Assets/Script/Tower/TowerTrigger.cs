using UnityEngine;

public class TowerTrigger : MonoBehaviour
{
    public GameObject[] OnGlass = new GameObject[4];
    public GameObject[] OnGlassDlete = new GameObject[4];
    public static int OnGlassStage;

    private void Update()
    {
        OnTowerFind();
    }


    private void MoveAndGlassMove(GameObject Delete, GameObject GlassOn)
    {
        Destroy(Delete);
        GlassOn.SetActive(true);
    }

    public void OnTowerFind()
    {
        switch (OnGlassStage)
        {
            case 1:
                MoveAndGlassMove(OnGlassDlete[0], OnGlass[0]);
                break;
            case 2:
                MoveAndGlassMove(OnGlassDlete[1], OnGlass[1]);
                break;
            case 3:
                MoveAndGlassMove(OnGlassDlete[2], OnGlass[2]);
                break;
            case 4:
                MoveAndGlassMove(OnGlassDlete[3], OnGlass[3]);
                break;
        }
    }

}
