
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform playerPos;
    private float yOffSet = 1.25f;
    


    private void Awake()
    {
        playerPos = GameObject.Find("Player").transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(playerPos.position.x + 0.8f, playerPos.position.y + yOffSet, playerPos.position.z -0.5f);
        
    }
}
