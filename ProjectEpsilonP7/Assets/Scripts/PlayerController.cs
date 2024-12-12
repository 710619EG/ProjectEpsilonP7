using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    float canWeGetMuchHigher = 10.0f;
    float leftNRight;
    float awayNToward;
    public float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Updates the state of the movement keys
        awayNToward = Input.GetAxis("AwayNToward");
        leftNRight = Input.GetAxis("LeftNRight");
        transform.Translate (Vector3.forward * Time.deltaTime * speed * awayNToward);
        transform.Translate(Vector3.right * Time.deltaTime * speed * leftNRight);
        if (Input.GetKeyDown(KeyCode.Space))
        {
             playerRb.AddForce(Vector3.up * canWeGetMuchHigher, ForceMode.Impulse);
        }
    } 
}
