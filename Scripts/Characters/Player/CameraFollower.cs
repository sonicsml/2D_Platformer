using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    private void LateUpdate()
    {
        _camera.transform.position = _target.position + _offset;
    }
}
