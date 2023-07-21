using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Fish : MonoBehaviour
{
    public TextMeshProUGUI messageLable;
    public int Score = 0;

    //This tells the player that they have discarded the fish in the on screen text
    public void DiscardFish(int score)
    {
        messageLable.text = ("You Have discared the caught fish and it will NOT be placed in the Aquarium");
        Score = score;
        if (score > 1)
        {
           score -= Score;
        }

    }

    
}
