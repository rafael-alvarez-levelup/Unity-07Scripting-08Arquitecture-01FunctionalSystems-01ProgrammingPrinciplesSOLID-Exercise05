using UnityEngine;

public class InputRigidbodyMovementController : MonoBehaviour
{
    private RigidbodyMovementBehaviour rigidbodyMovementBehaviour;
    private EngineBehaviour engineBehaviour;
    private float horizontalMovement;

    private void Awake()
    {
        rigidbodyMovementBehaviour = GetComponent<RigidbodyMovementBehaviour>();
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
        rigidbodyMovementBehaviour.Move(transform.right * horizontalMovement);
    }
}