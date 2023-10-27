using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHouse : MonoBehaviour
{
    private bool canSpawn;
    public GameObject prefabHosue;
    private float offset = 0.1f;
    private Vector3 spawnPosition;

    private float addPoint;

    private GameObject dirt;
    private void OnTriggerEnter(Collider other)
    {
        //Spawn house in dirt or desert
        if (other.CompareTag("Desert"))
        {
            canSpawn = true;
            spawnPosition.x = other.transform.position.x;
            spawnPosition.y = other.transform.position.y + offset;
            spawnPosition.z = other.transform.position.z;
            addPoint = 2;

            //Set to null reference
            dirt = null;
        }
        else if (other.CompareTag("Dirt"))
        {
            canSpawn = true;
            spawnPosition.x = other.transform.position.x;
            spawnPosition.y = other.transform.position.y + offset;
            spawnPosition.z = other.transform.position.z;
            addPoint = 10;
            
            //Assign dirt gameObject reference if mouse is on dirt gameObject
            dirt = other.gameObject;
        }
        else
        {
            canSpawn = false;
            addPoint = 0;

            //Set to null reference
            dirt = null;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canSpawn)
        {
            //Spawn and add point and base desert tile or dirt tile
            GameObject clone = Instantiate(prefabHosue, spawnPosition, Quaternion.identity);
            GameManager.instance.point += addPoint;
            if (dirt != null)
            {
                dirt.tag = "Plant";
            }
        }
    }
}
