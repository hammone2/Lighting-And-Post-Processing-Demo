using UnityEngine;

public class sphereScript : MonoBehaviour
{
    public float moveSpeed = 1f; // Speed of character movement

    void Update()
    {
        // Get input from arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical).normalized;

        // Move the character
        MoveCharacter(movement);
    }

    void MoveCharacter(Vector3 direction)
    {
        // Calculate the character's position after movement
        Vector3 newPosition = transform.position + direction * moveSpeed * Time.deltaTime;

        // Move the character
        transform.position = newPosition;
    }
}
