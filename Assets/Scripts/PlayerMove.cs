
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed;
    public SpawnManager spawnManager;
    private Vector3 playerY = new Vector3(0, 0.2f, 0);
    private Transform playerTransform;


    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }


    void Update()
    {
        PlayerLocomotion();
    }



    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }



    void PlayerLocomotion()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(horizontalMovement, 0, verticalMovement).normalized * moveSpeed * Time.fixedDeltaTime);
    }



}
