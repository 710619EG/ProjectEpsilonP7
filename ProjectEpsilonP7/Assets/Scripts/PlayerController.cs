using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float canWeGetMuchHigher;
    public float jumpNDesend;
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
        jumpNDesend = Input.GetAxis("JumpNDesend");
        awayNToward = Input.GetAxis("AwayNToward");
        leftNRight = Input.GetAxis("LeftNRight");
        rb.AddForce(new Vector3(rb.velocity.x, canWeGetMuchHigher * jumpNDesend, rb.velocity.z));
        transform.Translate (new Vector3(leftNRight * speed * Time.deltaTime, 0f , awayNToward * speed * Time.deltaTime));
    } 
}
