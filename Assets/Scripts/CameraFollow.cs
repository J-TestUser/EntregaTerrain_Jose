using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _cameraTarget;
    [SerializeField] private Vector3 _cameraOffset;

    // Update is called once per frame
    void LateUpdate()
    {
        if(_cameraTarget != null)
        {
            Vector3 desiredPosition = _cameraTarget.position + _cameraOffset;

            transform.position = desiredPosition;   
        }
    }
}

