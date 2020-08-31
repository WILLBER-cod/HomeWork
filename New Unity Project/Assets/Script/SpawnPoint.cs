using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private GameObject _target;

    private Transform[] _points;

    private float _time;

    private int _index;

    private void Start()
    {
        _points = new Transform[_path.childCount];
  
        for(int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        _time += Time.deltaTime;
        if(_time >= 2 && _index != _path.childCount)
        {
            Spawn();

            _time = 0;

            _index++;
        }
    }

    void Spawn()
    {
        Transform Target = _points[_index];
        Instantiate(_target, transform.position = Target.position, Quaternion.identity);
    }

}
