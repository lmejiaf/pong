using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{



    public KeyCode arriba;
    public KeyCode abajo;
    public float speed;
    public float constrainSpeed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(arriba)) {

            if (transform.localPosition.y > 3.2)
            {

                constrainSpeed = 0f;
            }
            else {
                constrainSpeed = speed;
            }
            transform.Translate(0, constrainSpeed, 0);
        }
        if (Input.GetKey(abajo))
        {
            if (transform.localPosition.y < -3.2)
            {

                constrainSpeed = 0f;
            }
            else
            {
                constrainSpeed = speed;
            }
            transform.Translate(0, -constrainSpeed, 0);
        }

    }
}
