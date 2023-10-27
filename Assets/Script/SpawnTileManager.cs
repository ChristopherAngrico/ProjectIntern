using UnityEngine;

public class SpawnTileManager : MonoBehaviour
{
    [SerializeField] private GameObject[] tileGameAsset;
    private GameObject[,] grid = new GameObject[8,8];
    [SerializeField] private int gridX;
    [SerializeField] private int gridZ;

    private void Start()
    {
        SpawnTile();
    }
    private void SpawnTile()
    {
        //Spawn tile at least one tile type
        for (int i = 0; i < tileGameAsset.Length; i++)
        {
            int x = Random.Range(0, 8);
            int z = Random.Range(0, 8);
            grid[x,z] = Instantiate(tileGameAsset[i], new Vector3(x, 0, z), Quaternion.identity);
        }

        //Spawn the rest of haven't filled
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                if (grid[x, z] == null)
                {
                    int randomTile = Random.Range(0, tileGameAsset.Length);
                    grid[x, z] = Instantiate(tileGameAsset[randomTile], new Vector3(x, 0, z), Quaternion.identity);
                }
            }
        }
    }
    
}
