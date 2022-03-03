using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Animals
{
    void Start()
    {
        health = 10f;
        points = 10;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(CallAnimal());
            Destroy(gameObject);
        }
    }
    public override string CallAnimal()
    {
        return "Fox";
    }
}
