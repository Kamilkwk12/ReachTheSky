using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float followSpeed = 2;
    public Transform target;
    public float yOffset;
    public bool isCameraFollowActive = false;

    private void Start()
    {
        Invoke("activateCameraFollow", (float)3.5);
    }
    void Update()
    {

        if (isCameraFollowActive)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffset, -10);
            transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
        }
    }

    private void activateCameraFollow() {
        {
            isCameraFollowActive=true;
        } 
    }
}

