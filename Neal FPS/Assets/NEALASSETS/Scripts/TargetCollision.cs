using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollision : MonoBehaviour
{
    //public Rigidbody rb;

    public void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.name == "Cube")
        {
            Debug.Log("we hit the cube");
        }
    }
   
}
