using UnityEngine;

public class MarioController : MonoBehaviour
{
    GameObject mario;
    public Animator animator;
    float movement;
    public float movimientoSpeed = 5f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
  
    {
        animator = GetComponent<Animator>();
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
       
        if (movement > 0f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        animator.SetFloat("velocidadX", Mathf.Abs(movement));
        Debug.Log(movement);

        }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movement * movimientoSpeed, rb.linearVelocity.y);
     }
}