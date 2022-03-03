using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabsVertical;

    private float spawnPosX = 16f;
    private float spawnPosZ = -50f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, AnimalPrefabsVertical.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX+3, spawnPosX), 0, spawnPosZ);
        Instantiate(AnimalPrefabsVertical[animalIndex], spawnPos, AnimalPrefabsVertical[animalIndex].transform.rotation);
    }
}
