using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        //Display score
        text.text = "Score: " + GameManager.instance.point;
    }
}
