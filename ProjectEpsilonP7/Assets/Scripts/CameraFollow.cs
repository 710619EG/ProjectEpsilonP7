using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    
    {
        target.GetComponent <Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.positon = target.position;
    }
}
