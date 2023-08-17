using UnityEngine;


public class EnemyAtack : MonoBehaviour
{
    public Transform Player;
    
    public float EnemySpeed;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerHP.HPPlayer--;
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerZona")
        {
            Vector3 direction = Player.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);

            transform.Translate(new Vector3(0, 0, 1) * EnemySpeed * Time.deltaTime);
        }
        if (other.tag == "Player")
        {
            PlayerHP.HPPlayer--;
        }
    }
}
