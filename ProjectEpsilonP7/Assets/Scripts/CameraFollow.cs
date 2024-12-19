using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        //Here the script gets the transform of the target(CameraTarget)
        Target.GetComponent <Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Target.transform.position;
    }
}
