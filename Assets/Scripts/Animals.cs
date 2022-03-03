using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public int points { get; protected set; }
    public float health { get; protected set; }

    public float speed { get; protected set; }

    public virtual string CallAnimal()
    {
        return "Animal";
    }

    public virtual IEnumerator DisplayText()
    {
        yield return new WaitForSeconds(1.3f);
    }

    public void Run(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}
