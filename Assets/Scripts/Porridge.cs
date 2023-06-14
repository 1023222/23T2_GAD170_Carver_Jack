using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{

    [SerializeField] private float porridgeTemp;

    [SerializeField] private float porridgeTooHot;
    [SerializeField] private float porridgeTooCold;

    [SerializeField] private int porridgeAmount;

    [SerializeField] bool runOnce;
    [SerializeField] bool porridgeRunOnce;

    // Start is called before the first frame update
    void Start()
    {
        porridgeTemp = 100;
        porridgeTooHot = 70;
        porridgeTooCold = 40;

        porridgeAmount = Random.Range(10, 20);

        runOnce = false;
        porridgeRunOnce = false;

        Debug.Log("Hungry, kiddo? Go check if the porrdige is the right temperature to eat. ");

    }

  

    // Update is called once per frame
    void Update()
    {
        if (porridgeRunOnce == false)
        {
            if(porridgeAmount == 0)
            {
                Debug.Log("The bowl is empty. Get up, and walk away from the table. ");
                porridgeRunOnce = true;
            }
        }
        
        if(runOnce == false)
        {
            if (Input.anyKeyDown)
            {
                Debug.Log("What, don't know how? Check the spacebar, dummy. ");
                runOnce = true;
            }

        }
        //Computer running at 800FPS. deltaTime will be 1/800 = 0.00125.
        //Computer running at  60FPS. deltaTime will be 1/60  = 0.01667.
        //Computer running at  10FPS. deltaTime will be 1/10  = 0.1.
        porridgeTemp = (float)(porridgeTemp - Time.deltaTime);

        if (porridgeTemp > porridgeTooHot)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("You just burnt your tounge. ");
                porridgeAmount = porridgeAmount - 1;
            }
        }

        //if (porridgeTemp < porridgeTooHot && porridgeTemp > porridgeTooCold)
        //{
        //    if (Input.GetKeyDown(KeyCode.Space))
        //         Debug.Log("You eat some porridge. ");
        //}

        else if (porridgeTemp < porridgeTooCold)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("It's cold. You are disgusted. You eat it anyway, though, because you need to finish your plate. Your disgust is transferred from the porridge to yourself. ");
                porridgeAmount = porridgeAmount - 1;
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("You eat some porridge, and it's a suitable temperature. For some reason your tongue informs you of it's e x a c t termpature to several decimal points:  " + (float)porridgeTemp + ". " + "Want it as a whole number? Try 'W.' ");
                porridgeAmount = porridgeAmount - 1;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("You eat some again. It's " + (int)porridgeTemp + " degrees. ");
                porridgeAmount = porridgeAmount - 1;
            }
        }
    }
}
