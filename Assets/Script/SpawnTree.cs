using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{
    [SerializeField] private GameObject prefabTree;
    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            GameObject dirt = GameObject.FindGameObjectWithTag("Dirt");

            //Finished spawn if all dirt have filled
            if (dirt == null)
            {
                break;
            }
            
            //Change tag dirt that has planted to plant tag to avoid
            //grab previous position has planted
            dirt.tag = "Plant";

            Vector3 dirtPosition = dirt.transform.position;
            GameObject clone = Instantiate(prefabTree, dirtPosition, Quaternion.identity);
        }

    }
}
