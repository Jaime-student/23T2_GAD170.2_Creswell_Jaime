using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int fishSpecies;
    public Button buttonFish;
    

    string myrandomString;
    public void RandomFishSpecies()

    {
        {
            //This is the fish species

            {
                string[] _fishSpecies = { "Mackrle", "Tuna", "Great White Shark", "Sun Fish", "Angelfish", "Barracuda", "Viperfish", "Triggerfish" };


                myrandomString = _fishSpecies[Random.Range(0, _fishSpecies.Length)];
            }
            Debug.Log(myrandomString);
        }
    }
    


}