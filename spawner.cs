using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnpoint;
    void Update()
    {
        Instantiate(_template, _spawnpoint.position, Quaternion.identity);
    }
}
