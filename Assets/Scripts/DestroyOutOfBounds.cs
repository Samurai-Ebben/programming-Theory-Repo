using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zRange = 17;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < -80)
        {
            Destroy(gameObject);
        }
    }
}
