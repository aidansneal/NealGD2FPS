using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopOnCollision : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject projectile;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    
     private void OnCollisionEnter(Collision projectile)
    {
        rb.isKinematic = true;
        Debug.Log("Enemy has stopped");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
