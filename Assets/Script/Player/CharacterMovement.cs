using System.Collections;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Transform playerModel;
    private Transform mainCamera;
    public Rigidbody rb;
    public float speed = 10f, rotateSpeed = 10f, TimeReturnJump = 1f, PowerJump = 10f;

    private bool isJump = false;
    private float Jump2 = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main.transform;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Jump2 < 2)
        {
            isJump = true;
        }
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += playerModel.transform.forward * speed * Time.fixedDeltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -playerModel.transform.forward * speed * Time.fixedDeltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += playerModel.transform.right * rotateSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -playerModel.transform.right * rotateSpeed * Time.fixedDeltaTime;
        }
        if(isJump == true)
        {
            isJump = false;
            StartCoroutine(PlayerJump(TimeReturnJump));
        }
    }

    private IEnumerator PlayerJump(float wait)
    {
        Jump2++;
        rb.AddForce(new Vector3(0, 1, 0) * PowerJump * Time.deltaTime);
        if(Jump2 == 1)
        {
            yield return new WaitForSeconds(wait);
            Jump2 = 0;
        }
    }
}
