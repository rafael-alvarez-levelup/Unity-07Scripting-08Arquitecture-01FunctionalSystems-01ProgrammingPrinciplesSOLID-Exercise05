using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] protected GameObject prefab;

    [SerializeField] private float fireRate;

    protected SpawnGameObjectBehaviour spawnGameObjectBehaviour;

    private float nextFireTime;

    private void Awake()
    {
        spawnGameObjectBehaviour = GetComponent<SpawnGameObjectBehaviour>();
    }

    public abstract void Fire(Transform firePoint);

    public virtual bool CanFire()
    {
        return Time.time >= nextFireTime;
    }

    public virtual void SetNextFireTime()
    {
        nextFireTime = Time.time + fireRate;
    }
}