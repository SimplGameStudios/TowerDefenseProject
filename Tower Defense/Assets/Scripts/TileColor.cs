using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileColor : MonoBehaviour
{
    [SerializeField] Material[] materials;
    [SerializeField] Material equipedMaterial;
    
    void Start()
    {
        if(tag == "Spawn Tile")
        {
            equipedMaterial = materials[0];
        }
        else if(tag == "End Tile")
        {
            equipedMaterial = materials[1];
        }
        else if (tag == "Path Tile")
        {
            equipedMaterial = materials[2];
        }
        else if (tag == "Tower Tile")
        {
            equipedMaterial = materials[3];
        }
        else if (tag == "Empty Tile")
        {
            equipedMaterial = materials[4];
        }

        GetComponent<Renderer>().material = equipedMaterial;
    }

    void Update()
    {
        
    }
}
