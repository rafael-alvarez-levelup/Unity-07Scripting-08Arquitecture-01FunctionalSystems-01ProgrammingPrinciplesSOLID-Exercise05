using UnityEngine;

public class EnemyHealthBehaviour : HealthBehaviour
{
    public delegate void EnemyDeathEventHandler();
    public event EnemyDeathEventHandler OnEnemyDeath;

    [SerializeField] private float damageMultiplier;

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(Mathf.RoundToInt(amount * damageMultiplier));
    }

    protected override void Die()
    {
        base.Die();

        EnemyDeath();
    }

    private void EnemyDeath()
    {
        // Could insert silent bugs. Use assertion?
        if (OnEnemyDeath != null)
        {
            OnEnemyDeath();
        }
    }
}