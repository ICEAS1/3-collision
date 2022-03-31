using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Good"){
            print("its good");
            rb.AddForce(0,0,200f);
        }
        if(col.gameObject.tag == "Bad"){
            print("its bad, its need to DESTROY");
            Destroy(col.gameObject);
        }
    }
}
