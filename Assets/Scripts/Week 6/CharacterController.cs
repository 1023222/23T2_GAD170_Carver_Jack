using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int sprintSpeed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Move Little Bean Boy based on player input

        //Defining a moving direction - Vector3 just means 'direction in 3d'
        //We COULD make new vectors like this, or we could do it in the movement code.
        //For example transform.position += Vector3.forward in the if statement.
        Vector3 forward = Vector3.forward;
        Vector3 backward = Vector3.back;
        Vector3 right = Vector3.right;
        Vector3 left = Vector3.left;



        //if (Input.GetKey(KeyCode.W))
        //{
        ////While the transform is a number, it's a float, so transform.position++; WILL NOT WORK, as it's not an int.
        //    transform.position += forward * Time.deltaTime * speed;
        //    if (Input.GetKey(KeyCode.LeftShift))
        //    {
        //        transform.position += forward * Time.deltaTime * sprintSpeed;
        //    }
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += backward * Time.deltaTime * speed;
        //    if (Input.GetKey(KeyCode.LeftShift))
        //    {
        //        transform.position += backward * Time.deltaTime * sprintSpeed;
        //    }
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += right * Time.deltaTime * speed;
        //    if (Input.GetKey(KeyCode.LeftShift))
        //    {
        //        transform.position += right * Time.deltaTime * sprintSpeed;

        //    }
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += left * Time.deltaTime * speed;
        //    if (Input.GetKey(KeyCode.LeftShift))
        //    {
        //        transform.position += left * Time.deltaTime * sprintSpeed;
        //    }
        //}

        //We can be cheeky and call on the built in Input Manager (Edit > Project Settings > Input Manager)
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);

        //Sprint mechanic
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 9;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5;
        }
    }
}
