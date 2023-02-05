using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float life;
    public float maxLifePlayer;
    public HealthBar lifebar;

    void Start()
    {

        life = maxLifePlayer;
        lifebar.InitiateLifeBar(life);
    }

    
    public void TakeDamage(float damage)
    {
        life -= damage;
        lifebar.ChangeCurrentLife(life);
        if (life <=0)
        {
            Destroy(gameObject);
        }
    }
    public void Curar(float curacion)
    {
        if ((life + curacion) > maxLifePlayer)
        {
            life = maxLifePlayer;
        }
        else
        {
            life += curacion;
        }
    }
}
