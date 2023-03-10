using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private float timeDamage;
    private float timeNextDamage;




    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            timeNextDamage -= Time.deltaTime;
            if (timeNextDamage <= 0)
            {
            other.GetComponent<PlayerHealth>().TakeDamage(5);
            timeNextDamage = timeDamage;
            } 
        }
    }
  
}
