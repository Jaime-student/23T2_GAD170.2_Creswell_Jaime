using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     public static int fishSpecies;
    public Button buttonFish;
    public GameObject myText;
    public int myValue;
    public int myLength;

    public string myrandomString;
    public void RandomFishSpecies()

    {
        {
            //This is the fish species

            {
                string[] _fishSpecies = { "Mackrle", "Tuna", "Great White Shark", "Sun Fish", "Angelfish", "Barracuda", "Viperfish", "Triggerfish" };


                myrandomString = _fishSpecies[Random.Range(0, _fishSpecies.Length)];
                {
                    myValue = Random.Range(1, 100);

                }
                {
                    myLength = Random.Range(8, 500);

                    if (myLength < 150)
                        myValue = myValue-- ;
                    if (myLength > 150)
                      
                        myValue += 75;
                    
                }
            }
        }
    }
}