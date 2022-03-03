using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : Animals
{
    void Start()
    {
        health = 20f;
        points = 20;
        speed = 10;
    }

    private void Update()
    {
        Run(speed);
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
        return "Moose";
    }
}
