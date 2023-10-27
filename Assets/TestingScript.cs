using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    private List<int> containAllNumber = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        PickAtLeastOne();
    }
    private void PickAtLeastOne()
    {
        bool allNumberPresent = true;

        for (int x = 0; x < 8; x++)
        {
            for (int z = 0; z < 8; z++)
            {
                int randomIndex = Random.Range(0, 1);
                print(randomIndex);
                containAllNumber.Add(randomIndex);
            }
        }
        for (int i = 0; i < 7; i++)
        {
            if (!containAllNumber.Contains(i))
            {
                allNumberPresent = false;
                break;
            }
        }
        if (allNumberPresent)
        {
            return;
        }
        else
        {
            print("False");
            //Reset list
            containAllNumber.Clear();
        }
    }
}
