using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTxt : MonoBehaviour
{
    private float timer = 1.5f;
    void Start()
    {
        Destroy(gameObject, timer);
    }

}
