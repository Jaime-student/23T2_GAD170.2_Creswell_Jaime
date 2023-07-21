using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

public class FishStats : MonoBehaviour
{
    // score will be calculated  amd displayed on screen here
    public TextMeshProUGUI messageScore;
    [SerializeField] public int Score = 0;
     
    public void ScoreUpdate(int score)
    {
        Score = score;
        if (score > 1) 
        {
            messageScore.text = " $" + score;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
