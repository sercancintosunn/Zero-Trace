using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothTime = 0.15f;

    private Vector3 velocity;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 destination = target.position + offset;
        destination.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, smoothTime);

        
    }
}
