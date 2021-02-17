using System;
using UnityEngine;

[RequireComponent(typeof(SpawnGameObjectBehaviour), typeof(DestroyBehaviour))]
public class HealthBehaviour : MonoBehaviour, IDamageable
{
    [SerializeField] protected HealthData healthData;
    [SerializeField] private GameObject damageEffectPrefab;
    [SerializeField] private GameObject explosionPrefab;

    protected int currentHealth;
    protected SpawnGameObjectBehaviour spawnGameObjectBehaviour;

    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        spawnGameObjectBehaviour = GetComponent<SpawnGameObjectBehaviour>();
        destroyBehaviour = GetComponent<DestroyBehaviour>();

        currentHealth = healthData.Health;
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth = Math.Max(0, currentHealth - amount);

        spawnGameObjectBehaviour.Spawn(damageEffectPrefab, transform.position, transform.rotation);

        if (currentHealth == 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        spawnGameObjectBehaviour.Spawn(explosionPrefab, transform.position, transform.rotation);

        destroyBehaviour.Destroy();
    }
}