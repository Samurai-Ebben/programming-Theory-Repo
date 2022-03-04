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

    private void Start()
    {
        gM = GetComponent<GameManager>();
    }
    public virtual void CallAnimal()
    {
        Debug.Log("Animal");
    }

    private void OnTriggerEnter(Collider other)
    {
        gM.scoreTxt.text = "score: " + points.ToString();
    }
    protected void Run(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected void TakeDamage()
    {
        health -= damage;
        if(health <= 0)
        {
            CallAnimal();
            Destroy(gameObject);
        }
    }

     
}
