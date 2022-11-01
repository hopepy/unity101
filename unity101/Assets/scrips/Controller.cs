using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(transform.position);

        if(Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(0,transform.position.y + 2,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(0, transform.position.y - 2, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - 2,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 2, 0,0);
        }
    }
}
