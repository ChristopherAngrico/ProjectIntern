using UnityEngine;

public class SpawnGridManager : MonoBehaviour
{
    public GameObject[] tileGameAsset;
    public int gridX;
    public int gridz;
    public float gridSpacingOffset = 1;

    private void Start()
    {
        SpawnGrid();
    }
    private void SpawnGrid()
    {
        //Spawn 8X8 tile
        for(int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridz; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset);
                PickAndSpawn(spawnPosition, Quaternion.identity);
            }
        }
    }
    private void PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, tileGameAsset.Length);
        GameObject clone = Instantiate(tileGameAsset[randomIndex], positionToSpawn, rotationToSpawn);
    }
}
