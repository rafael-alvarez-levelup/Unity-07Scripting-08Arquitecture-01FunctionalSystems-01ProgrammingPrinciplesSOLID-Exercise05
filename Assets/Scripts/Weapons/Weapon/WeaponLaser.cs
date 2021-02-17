using UnityEngine;
using UnityEngine.Assertions;

public class WeaponLaser : WeaponBase
{
    public override void Fire(Transform firePoint)
    {
        GameObject laser = gameObjectSpawnable.Spawn(prefab, firePoint.position, firePoint.rotation);

        LaserBehaviour laserBehaviour = laser.GetComponent<LaserBehaviour>();

        Assert.IsNotNull(laserBehaviour, $"{laser.gameObject.name} doesn't have LaserBehaviour component");

        laserBehaviour.AddVelocityChangeForce(transform.up);
    }
}