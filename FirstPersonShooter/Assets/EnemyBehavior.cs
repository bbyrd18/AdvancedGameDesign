using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{  
    
    void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            Destroy (collision.gameObject);
            Destroy (gameObject);
        }
    }
    
    
    
    
    
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(this.gameObject);
    }







}
