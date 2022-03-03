using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Doe : Animals
{
    [SerializeField] private TextMeshPro txt;
    // Start is called before the first frame update
    void Start()
    {
        health = 10f;
        points = 10;
        speed = 5;
        
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
        
        txt.text = "Doe";
        return txt.text;
    }
}
