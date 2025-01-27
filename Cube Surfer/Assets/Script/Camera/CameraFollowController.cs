
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] private float lerpValue;
    void Start()
    {
        offset = transform.position - heroTransform.position;
    }

    
    void LateUpdate()
    {
        SetCameraSmootFollow();
    }

    private void SetCameraSmootFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.position.x)+ offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
