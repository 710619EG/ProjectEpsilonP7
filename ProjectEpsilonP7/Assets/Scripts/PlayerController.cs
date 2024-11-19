using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float leftNRight;
    public float awayNToward;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Updates the state of the movement keys

        awayNToward = Input.GetAxis("AwayNToward");
        leftNRight = Input.GetAxis("LeftNRight");
        transform.Translate (new Vector3(leftNRight * speed * Time.deltaTime, 0f , awayNToward * speed * Time.deltaTime));
    } 
}
