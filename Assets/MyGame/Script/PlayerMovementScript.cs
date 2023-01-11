using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovementScript : MonoBehaviour

{
   private Rigidbody2D player;
   [SerializeField] private float speed = 3f;
   public float rotationSpeed;

    private void Start()

   {
        player = GetComponent<Rigidbody2D>();
   }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);

        player.AddForce(direction * speed);
        player.AddForce(-player.velocity);

        if (horizontal != 0f || vertical != 0f)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Vector3.forward, direction), rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            speed = speed + 1f;
        }
    }


}



