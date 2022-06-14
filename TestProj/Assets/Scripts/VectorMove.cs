using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMove : MonoBehaviour
{
    [SerializeField] private Transform transform1;
    [SerializeField] private Transform transform2;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _speed;

    void Start()
    {
        Vector2 objectVector1 = (transform1.position - transform2.position).normalized;
        Instantiate(_gameObject, objectVector1, Quaternion.identity);
    }
    void Update()
    {
        Vector2 objectVector = (transform1.position - transform2.position).normalized;
        transform.position = Vector3.MoveTowards(transform.position, objectVector, _speed * Time.deltaTime);
    }
}
