using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject Epsilon;
    // Start is called before the first frame update
    void Start()
    
    {
        Epsilon = GameObject.Find("Epsilon");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Epsilon.transform.position.x, Epsilon.transform.position.y + 5, Epsilon.transform.position.z - 10);
    }
}
