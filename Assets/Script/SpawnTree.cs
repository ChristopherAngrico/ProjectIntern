using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{
    [SerializeField] private GameObject prefabTree;
    //private GameObject[] prefabDirts;
    private GameObject prefab;
    private bool finishedSpawnTree;
    //private List<Vector3> spawnPosition = new List<Vector3>();
    private void OnEnable()
    {
        //StartCoroutine(LateStart());
        StartCoroutine(Spawn());
    }
    //private IEnumerator LateStart()
    //{
    //    yield return new WaitForSeconds(0.1f);
    //prefabDirts = GameObject.FindGameObjectsWithTag("Dirt");
    //    foreach (GameObject dirt in prefabDirts)
    //    {
    //        spawnPosition.Add(dirt.transform.position);
    //    }
    //}
    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            GameObject dirt = GameObject.FindGameObjectWithTag("Dirt");
            if (dirt == null)
            {
                break;
            }
            dirt.tag = "Plant";
            Vector3 dirtPosition = dirt.transform.position;
            GameObject clone = Instantiate(prefabTree, dirtPosition, Quaternion.identity);
        }

    }
}
