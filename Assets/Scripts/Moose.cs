using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moose : Animals
{
    [SerializeField] TextMeshPro txt;

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
