using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;

    private Rigidbody rb;
    private bool isGrounded;

    public GameObject projectilePrefab; 
    public Transform shootPoint;        

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * moveSpeed;
        Vector3 newPos = transform.position + movement * Time.deltaTime;
        rb.MovePosition(newPos);

        // Jumping
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(0)) // click mouse to shoot
        {
            Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
            GameManager.Instance.AddProjectileFired();

        }
    }
}
