using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doe : Animals
{
    // Start is called before the first frame update
    void Start()
    {
        health = 10f;
        points = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        return "Doe";
    }
}
