using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Doe : Animals//Inheritance
{
    [SerializeField] private TextMeshPro txt;
    [SerializeField] ParticleSystem explode;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        points = 15;
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
            Instantiate(explode, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            TakeDamage();            
        }
        
    }
    public override void CallAnimal()
    {
        var txtShow = Instantiate(txt, transform.position, Quaternion.identity);
        txtShow.GetComponent<TextMeshPro>().text = "Doe:" + points.ToString() + "+";
    }
    
}
