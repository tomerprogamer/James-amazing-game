using UnityEngine;

public class pipesScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float speed = -4;
        transform.Translate(new Vector3(0f, 0f, speed*Time.deltaTime));
    }
}
