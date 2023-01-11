using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public Transform target;
    public int smoothTime = 0;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPos = target.position;
            targetPos.z = transform.position.z;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        }
    }
}
