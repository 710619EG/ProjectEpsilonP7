using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    
    {
        Target.GetComponent <transform>();
    }

    // Update is called once per frame
    void Update()
    {
        moveTo = new Vector3(Target.transform.position.x, Target.transform.position.y + 5, Target.transform.position.z - 10);
        transform.Translate(moveTo);
    }
}