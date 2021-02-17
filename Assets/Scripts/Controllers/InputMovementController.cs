using UnityEngine;

[RequireComponent(typeof(MovementBehaviour), typeof(EngineBehaviour))]
public class InputMovementController : MonoBehaviour
{
    private MovementBehaviour movementBehaviour;
    private EngineBehaviour engineBehaviour;
    private float horizontalMovement;

    private void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
        engineBehaviour = GetComponent<EngineBehaviour>();
    }

    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        engineBehaviour.Toggle(horizontalMovement != 0);
    }

    private void FixedUpdate()
    {
        // Already handles a null velocity.
        movementBehaviour.Move(transform.right * horizontalMovement);
    }
}