using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zRange = 17;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < -80 && !gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.isOver = true;
            Time.timeScale = 0;
        }
    }
}
