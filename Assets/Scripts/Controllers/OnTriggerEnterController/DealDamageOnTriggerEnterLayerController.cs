using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(DealDamageBehaviour))]
public class DealDamageOnTriggerEnterLayerController : OnTriggerEnterLayerControllerBase
{
    private DealDamageBehaviour dealDamageBehaviour;

    private void Awake()
    {
        dealDamageBehaviour = GetComponent<DealDamageBehaviour>();
    }

    protected override void React(Collider other)
    {
        IDamageable target = other.GetComponent<IDamageable>();

        Assert.IsNotNull(target, $"{other.gameObject.name} doesn't implement IDamageable interface");

        dealDamageBehaviour.DealDamage(target);
    }
}