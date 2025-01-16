using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    public GameObject[] waypointsNode;
    int currentWPNode = 0;

    public float speed = 10.0f;
    public float rotSpeed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, waypointsNode[currentWPNode].transform.position) < 3)
            currentWPNode++;

        if (currentWPNode >= waypointsNode.Length)
            currentWPNode = 0;

        //  this.transform.LookAt(waypoints[currentWP].transform);
        Quaternion lookatWP = Quaternion.LookRotation(waypointsNode[currentWPNode].transform.position - this.transform.position);

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookatWP, rotSpeed * Time.deltaTime);

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
