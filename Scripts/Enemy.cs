using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Path _path;
    private Vector3 _targetPoint;

    private void Update()
    {
        if (_targetPoint == null) return;

        if (transform.position == _targetPoint)
        {
            _targetPoint = _path.GetNextPoint(_targetPoint);
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPoint, _speed * Time.deltaTime);
    }

    public void Init(Path path)
    {
        _path = path;
        _targetPoint = path.GetFirstPoint();
        transform.position = _targetPoint;
    }
}