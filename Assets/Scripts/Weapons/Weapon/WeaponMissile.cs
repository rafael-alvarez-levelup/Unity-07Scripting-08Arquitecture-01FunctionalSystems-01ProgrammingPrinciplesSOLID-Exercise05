using UnityEngine;
using UnityEngine.Assertions;

public class WeaponMissile : WeaponBase
{
    public override void Fire(Transform firePoint)
    {
        GameObject missile = spawnGameObjectBehaviour.Spawn(prefab, firePoint.position, firePoint.rotation);

        MissileController missileController = missile.GetComponent<MissileController>();

        Assert.IsNotNull(missileController, $"{missile.gameObject.name} doesn't have MissileController component");

        missileController.SearchAndDestroy();
    }
}