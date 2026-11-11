using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float speeD = 5f;

    
    [SerializeField]
    private float mouseSensetivity = 2f;

    private Vector3 moveDirection;
    public float rotationY;
    
    // Update is called once per frame
    
    void Update()
    {
        handleMovement();
    }

    private void handleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = 0f;//= Input.GetAxis("Vertical");
        float diagonal = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontal, diagonal, 0f).normalized;
        
        transform.Translate(moveDirection*speeD* Time.deltaTime);
    }

   private void handleRotation()
   {
       // float mouseX = Input.GetAxis("Mouse X");
     //   rotationY += mouseX * mouseSensetivity;
        //transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
