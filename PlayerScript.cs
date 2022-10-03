using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject rightPosition, leftPosition;
    bool changePosition, startGame;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);

        if(changePosition == true && startGame == true)
        {
            // MAKE IT SMOOTH
            transform.position = Vector3.Lerp(transform.position, new Vector3(rightPosition.transform.position.x, transform.position.y, transform.position.z), 10f * Time.deltaTime);
        }
        if (changePosition == false && startGame == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(leftPosition.transform.position.x, transform.position.y, transform.position.z), 10f * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            startGame = true;

            if (changePosition==false)
            {
                changePosition = true;
            }else if(changePosition==true)
            {
                changePosition = false;
            }
        }
    }
}
