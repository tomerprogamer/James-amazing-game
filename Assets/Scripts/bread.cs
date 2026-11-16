using System;
using UnityEngine;

public class bread : MonoBehaviour
{
    
    scoreScript coolname;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            print("hit bread");
            playerMovement.score += 1;
            coolname = GameObject.FindWithTag("Score").GetComponent<scoreScript>();
            coolname.addScore();

        }
    }

    void Update()
     {

     //    float speed = -4;
     //   transform.Translate(new Vector3(0f, 0f, speed*Time.deltaTime));
    }
}
