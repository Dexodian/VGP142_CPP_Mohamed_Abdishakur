using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Animator anim;
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Enemy"))
        {


            
            Destroy(other.gameObject, 5f);
            Destroy(gameObject); 
        }
    }
}