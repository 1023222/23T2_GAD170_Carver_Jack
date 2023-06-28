using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //We want to store a reference to each car in our game.
    //We COULD make a new variable for each car, but what if there's like 200?
    //Let's use an array. This is done by adding the [] at the end.

    [SerializeField] private Car[] allCarsArray;

    //If we want to change something in the array, it's not great. We basically have to rebuild the array after making the change.
    //Instead, we can make a list.

    [SerializeField] private List<Car> allCarsList = new List<Car>();

    public void Start()
    {
        //We want to display the names of all the cars at start - this is for ARRAYS. Also the count.
        Debug.Log(allCarsArray[0].name);
        Debug.Log(allCarsArray.Length);
        //What about the list? For lists, it's 'count' rather than 'length'
        Debug.Log(allCarsList[0].name);
        Debug.Log(allCarsList.Count);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckWithCarIsCrashed();
        }
    }
    private void CheckWithCarIsCrashed()
    {
        //We DON'T want to do this. This is because we have to write it out for EACH thing in the list/array.
        //if (allCarsList[0].isCrashed == true)
        //{
        //    Debug.Log("CRASHED 0");
        //}

        //Instead, we can do a FOR LOOP.
        for (int selectedCarIndex = 0; selectedCarIndex < allCarsArray.Length; selectedCarIndex++)
        {
            //This is checking through the array for these conditions. You can check for any variable. For example, we can check for speedlimit too.
            if (allCarsArray[selectedCarIndex].isCrashed == true)
            {
                //We could use this, BUT, it will simply say the element number rather than the object itself, so...
                //Debug.Log("Crashed " + selectedCarIndex);
                Debug.Log("The " + allCarsArray[selectedCarIndex] + " has crashed!");
            }
        }
    }

    private void HelloWorldButton()
    {
        Debug.Log("Hello World from a UI button");
    }
}
