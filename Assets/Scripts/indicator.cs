using UnityEngine;

public class indicator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of the airplane when it moves")]
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        // To take the movement input from the keyboard
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // To move the airplane
        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
