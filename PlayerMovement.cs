    using UnityEngine;

    [RequireComponent(typeof(Rigidbody2D))]
    public class playerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D rb;
    
    private void Start()
    {
         rb = gameObject.GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate()
    {      
       movement();
    }
    void movement()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            var ySpeed = speed * Time.deltaTime;
            rb.velocity = new Vector2(rb.velocity.x, ySpeed);

        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            var ySpeed = speed * Time.deltaTime;
            rb.velocity = new Vector2(rb.velocity.x, -ySpeed);

           
        }
         //Assuming the player's face is looking left. Inputs will also rotate the player's face of direction
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            var ySpeed = speed * Time.deltaTime;
            rb.velocity = new Vector2(ySpeed, rb.velocity.y);
            var rotat = - 180;
            transform.rotation = Quaternion.Euler(transform.rotation.x, rotat, transform.rotation.z);

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            var ySpeed = speed * Time.deltaTime;
            rb.velocity = new Vector2(-ySpeed, rb.velocity.y);
            var rotat = 0;
            transform.rotation = Quaternion.Euler(transform.rotation.x, rotat, transform.rotation.z);
        }
     }
 }
    
