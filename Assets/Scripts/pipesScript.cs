using System.Collections;
using UnityEngine;

public class pipesScript : MonoBehaviour
{
    public static float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(destroyMe());
    }
    
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(0f, 0f, speed*Time.deltaTime));
    }

    IEnumerator destroyMe()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

}
