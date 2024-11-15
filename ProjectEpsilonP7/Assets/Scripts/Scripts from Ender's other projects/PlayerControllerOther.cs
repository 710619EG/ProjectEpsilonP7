using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerOther : MonoBehaviour
{
    public Rigidbody rb;
    public float horizontal;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Updates the state of the movement keys
        
        
        up = Input.GetButton("w");
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate (new Vector2(horizontal * speed * Time.deltaTime, 0f));
    } 
}
