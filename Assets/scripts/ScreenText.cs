using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.UIElements;

public class ScreenText : MonoBehaviour
{
    public static int fishSpecies;
    public GameObject myText;
    public string message;
    public TextMeshProUGUI messageLable;
    public string myrandomString;
    [SerializeField] public int myValue = 0 ;
    public int myLength; 
    [SerializeField] public int score = 0 ;
    [SerializeField] private int endgame = 0 ;

    //This displays the randomized fish in the on screen text
    //Main page to display text
    public void UpdateText()
    {
        string[] _fishSpecies = new string[] { "Mackrle", "Tuna", "Great White Shark", "Sun Fish", "Angelfish", "Barracuda", "Viperfish", "Triggerfish" };


        myrandomString = _fishSpecies[Random.Range(0, _fishSpecies.Length)];
        {
            myValue = Random.Range(1, 100);
            myValue += myValue;
        }
        {
            myLength = Random.Range(8, 500);

            if (myLength < 150)
                myValue = myValue--;
            if (myLength > 150)

                myValue += 75;
            if (myValue > 0)
            {
                score = myValue + score;
                FindObjectOfType<FishStats>().ScoreUpdate(score);
                FindObjectOfType<Fish>().DiscardFish(score);
            }
        }
        messageLable.text = "you got " + myrandomString + " $" + myValue + " " + myLength + "cm";
          
        
    }

    //displays thew end of the game
    public void Button()
    {
        endgame = endgame + 1;
     
        if (endgame > 10)
            messageLable.text = "You have run out of fishing line. Your final score is" + " $" + score;
    }
    //diplsays if you keep fish
    public void KeepFish()
    {
        messageLable.text = "You kept the fish and it was added to your aquarium";
    }
    public void Aquarium()
    {
        List<string> fishWithList = new List<string>();
        fishWithList.Add(messageLable.text = " " + myrandomString + myValue + myLength);
        

        messageLable.text = " " + myrandomString + myValue + myLength;
    }

    //public void Score()
    //{
    //    score = 0;
    //    score = myValue + score;
    //    if (score > 0) ;
    //    {
    //        messageLable.text = " " + score;
    //    }
    //}
}
