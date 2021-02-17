using UnityEngine;

[RequireComponent(typeof(DestroyBehaviour))]
public class DestroyOnTriggerEnterLayerController : OnTriggerEnterLayerControllerBase
{
    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();
    }

    protected override void React(Collider other)
    {
        destroyBehaviour.Destroy();
    }
}