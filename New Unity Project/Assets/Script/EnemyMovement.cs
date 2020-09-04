using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _enemypath;
    [SerializeField] private float _speed;

    private Transform[] _enemypoints;

    private int _enemyindex;

    private void Start()
    {
            _enemypoints = new Transform[_enemypath.childCount];

            for (int i = 0; i < _enemypath.childCount; i++)
            {
                _enemypoints[i] = _enemypath.GetChild(i);
            }
    }

    private void Update()
    {
        Transform Enemytarget = _enemypoints[_enemyindex];

        transform.position = Vector3.MoveTowards(transform.position, Enemytarget.position, _speed * Time.deltaTime);

        if(transform.position == Enemytarget.position)
        {
            _enemyindex ++;

            if (_enemyindex >= _enemypoints.Length)
                _enemyindex = 0;
        }
    }
}
