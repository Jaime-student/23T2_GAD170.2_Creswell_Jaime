using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class FishStats : MonoBehaviour
{
    //Fish species length and value will be done here
    [SerializeField] public int FishSpecies = 1 - 8;
    [SerializeField] public int Length;
     
    public void update()
    {

        //if (Input.GetButtonDown(KeyCode.Mouse0));
        //{
        //    Debug.Log("you caught" + FishSpecies);
        //}



        //This is the fish species
        //if (Input.GetButtonDown) ;

        //{
        //    string[] _randomName = { "Mackrle", "Tuna", "Great White Shark", "Sun Fish", "Angelfish", "Barracuda", "Viperfish", "Triggerfish" };


        //    return _randomName[Random.Range(0, _randomName.Length)];
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}
