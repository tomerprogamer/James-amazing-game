using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class bread : MonoBehaviour
{
    
    scoreScript coolname;
    public Mesh [] modelArray;
    public MeshFilter currentmodel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            print("hit bread");
            pipesScript.speed -= 0.5f;
            coolname = GameObject.FindWithTag("Score").GetComponent<scoreScript>();
            coolname.addScore();

        }
    }

    void Start()
    {
            currentmodel.mesh = modelArray[Random.Range(0, modelArray.Length)];
    }
    void Update()
     {

     //    float speed = -4;
     //   transform.Translate(new Vector3(0f, 0f, speed*Time.deltaTime));
    }
}
