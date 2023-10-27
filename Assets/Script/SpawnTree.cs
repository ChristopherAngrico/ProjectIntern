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
            GameObject[] dirts = GameObject.FindGameObjectsWithTag("Dirt");
            int randomNumber = Random.Range(0, dirts.Length);

            //Change tag dirt that has planted to plant tag to avoid
            //grab previous position has planted
            dirts[randomNumber].tag = "Plant";

            Vector3 dirtPosition = dirts[randomNumber].transform.position;
            GameObject clone = Instantiate(prefabTree, dirtPosition, Quaternion.identity);
        }

    }
}
