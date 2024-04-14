using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject[] tilePrefabs; // Assign prefabs in the inspector
    public int width = 20;
    public int height = 20;

    void Start()
    {
        GenerateMap();
    }



    void GenerateMap()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GameObject tilePrefab = tilePrefabs[Random.Range(0, tilePrefabs.Length)];
                Instantiate(tilePrefab, new Vector3(x, 0, y), Quaternion.identity);
            }
        }
    }
}
