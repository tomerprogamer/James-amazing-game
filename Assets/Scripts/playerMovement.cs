using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    [SerializeField] public float speeD;

    
    [SerializeField]
    private float mouseSensetivity = 2f;

    private Vector3 moveDirection;
    public float rotationY;
    public static int score;
    public static bool alive = true;
    
    private static Rigidbody rb;
    
    // Update is called once per frame
    void Start()
    {
        alive = true; 
        
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
    }
    
    public static void EnableGravity() {
        rb.useGravity = true;
        rb.mass = 1500f;
        
    }
    
    void Update()
    {
        //handleMovement();
    }

    static IEnumerator restartGame()
    {

            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("menu");//SceneManager.GetActiveScene().name

    }

    private void FixedUpdate()
    {
        if (alive == true) {
            handleMovement();
        }
        else if (alive == false)
        {
            Destroy(gameObject.GetComponent<BoxCollider>());
            StartCoroutine(restartGame());
        }


    }

    private void handleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = 0f;//= Input.GetAxis("Vertical");
        float diagonal = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontal, diagonal, 0f).normalized;
        
        transform.Translate(moveDirection*speeD* Time.deltaTime);
    }
    

   public static void Die()
   {
       
       
       if (alive == true) {
           alive = false;
           EnableGravity();
           
       }
       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
