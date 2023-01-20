using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moose : Animals//Inheritance
{
    [SerializeField] TextMeshPro txt;
    [SerializeField] ParticleSystem explode;


    void Start()
    {
        health = 20;
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
            Instantiate(explode, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            TakeDamage();
        }
    }
    public override void CallAnimal()
    {
        var txtShow = Instantiate(txt, transform.position, Quaternion.identity);
        txtShow.GetComponent<TextMeshPro>().text = "Moose:" + points.ToString() + "+";
    }
}
