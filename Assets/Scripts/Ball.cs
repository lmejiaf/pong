using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //dirección de la velocidad
    public int speedX;
        public int speedY;

    //velocidad
    public float speed;

    //rigidBody
    private Rigidbody rbd;

    //ball transform
    Transform t;

    //score
    Score score;


    // Start is called before the first frame update
    void Start()
    {
        
        t = GetComponent<Transform>();
        score = GetComponent<Score>();
        rbd = GetComponent<Rigidbody>();

        StartCoroutine(reset());

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.name) {
            case "Left":
                score.aumentarPunto("player2");
                StartCoroutine(reset());
                break;
            case "Right":
                score.aumentarPunto("player1");
                StartCoroutine(reset());
                break;
            default:
                return;
        }
       

    }

    private IEnumerator reset() {
        
        t.position = new Vector3(0f,0f,0f);
        rbd.velocity = new Vector3(0f,0f, 0f);
        speed = Random.Range(5, 15);
        yield return new WaitForSeconds(3);
        speedX = Random.Range(0, 2);
        if (speedX == 0)
        {
            speedX = 1;
        }
        else
        {
            speedX = -1;
        }

        speedY = Random.Range(0, 2);
        if (speedY == 0)
        {
            speedY = 1;
        }
        else
        {
            speedY = -1;
        }

        
        rbd.velocity = new Vector3(speed * speedX, speed * speedY, 0);

    }
}
