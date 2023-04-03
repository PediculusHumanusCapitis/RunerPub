
using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private Vector3 pos;
    private Vector3 rot;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Start()
    {
        pos = transform.position;
        rot = transform.localEulerAngles;

        Invoke("DropPrefab", 2f);
    }
    private void DropPrefab()
    {
        GameObject road = Instantiate<GameObject>(prefab);
        pos.y+= -0.15f;
        pos.z += 7.97f;

        rot.x += 2.12f;


        road.transform.position = pos;
        road.transform.localEulerAngles = rot;

        Invoke("DropPrefab", 1f);
    }
}
