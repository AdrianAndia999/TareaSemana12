using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public int speed = 5;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(Horizontal * speed, Vertical * speed);

        rb.velocity = movement;
    }
}