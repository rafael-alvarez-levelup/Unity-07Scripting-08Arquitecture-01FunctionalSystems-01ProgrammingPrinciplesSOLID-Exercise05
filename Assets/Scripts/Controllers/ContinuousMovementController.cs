using UnityEngine;

[RequireComponent(typeof(MovementBehaviour))]
public class ContinuousMovementController : MonoBehaviour
{
    private MovementBehaviour movementBehaviour;

    private void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
    }

    private void FixedUpdate()
    {
        movementBehaviour.Move(transform.up * -1);
    }
}