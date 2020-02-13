using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int StartScore = 0;
    public Text text;
    
    void Update()
    {
        text.text = StartScore.ToString();
    }
}
