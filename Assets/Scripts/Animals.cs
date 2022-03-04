using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour//Inheritance
{
    public int points { get; protected set; }//ENCAPSULATION
    public int health { get; protected set; }//ENCAPSULATION

    public float speed { get; protected set; }//ENCAPSULATION
    protected int damage = 10;

    private GameManager gM;

    public virtual void CallAnimal()// ABSTRACTION && polymorfism
    {
        Debug.Log("Animal");
    }

    protected void Run(float speed)// ABSTRACTION
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected virtual void TakeDamage()// ABSTRACTION && polymorfism
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
