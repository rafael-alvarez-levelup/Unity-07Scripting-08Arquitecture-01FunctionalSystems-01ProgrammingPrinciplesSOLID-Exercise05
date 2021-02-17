using UnityEngine;

public class DestroyOnTriggerEnterLayerController : OnTriggerEnterLayerControllerBase
{
    private IDestroyable destroyable;

    private void Awake()
    {
        destroyable = GetComponent<IDestroyable>();
    }

    protected override void React(Collider other)
    {
        destroyable.Destroy();
    }
}