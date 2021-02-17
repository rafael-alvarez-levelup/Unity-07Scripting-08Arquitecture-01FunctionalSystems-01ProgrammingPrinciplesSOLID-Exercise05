using UnityEngine;

public abstract class OnTriggerEnterLayerControllerBase: MonoBehaviour
{
    [SerializeField] private LayerMask triggerMask;

    private void OnTriggerEnter(Collider other)
    {
        CheckLayer(other);
    }

    private void CheckLayer(Collider other)
    {
        if (Utilities.ContainsLayer(triggerMask, other.gameObject.layer))
        {
            React(other);
        }
    }

    protected abstract void React(Collider other);
}