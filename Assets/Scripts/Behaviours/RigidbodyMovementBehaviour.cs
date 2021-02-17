using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyMovementBehaviour : MonoBehaviour, IMovable
{
    [SerializeField] private SpeedData speedData;

    private Rigidbody myRigidbody;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        // Must handle a null velocity.
        myRigidbody.velocity = direction * speedData.Speed;
    }
}