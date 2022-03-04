using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public int points { get; protected set; }
    public int health { get; protected set; }

    public float speed { get; protected set; }
    protected int damage = 10;

    private GameManager gM;

    public virtual void CallAnimal()
    {
        Debug.Log("Animal");
    }

    protected void Run(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected virtual void TakeDamage()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
        health -= damage;
        if(health <= 0)
        {
            CallAnimal();
            Destroy(gameObject);
            gM.score += points;
        }
    }     
}
