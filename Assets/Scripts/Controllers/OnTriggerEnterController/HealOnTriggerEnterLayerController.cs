using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(HealBehaviour))]
public class HealOnTriggerEnterLayerController : OnTriggerEnterLayerControllerBase
{
    private HealBehaviour healBehaviour;

    private void Awake()
    {
        healBehaviour = GetComponent<HealBehaviour>();
    }

    protected override void React(Collider other)
    {
        IHealable target = other.GetComponent<IHealable>();

        Assert.IsNotNull(target, $"{other.gameObject.name} doesn't implement IHealable interface");

        healBehaviour.Heal(target);
    }
}