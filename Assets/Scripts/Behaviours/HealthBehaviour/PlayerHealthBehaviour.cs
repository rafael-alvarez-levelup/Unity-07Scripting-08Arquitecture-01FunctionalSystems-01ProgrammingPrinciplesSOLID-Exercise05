using System;
using UnityEngine;

public class PlayerHealthBehaviour : HealthBehaviour, IHealable
{
    public delegate void OnPlayerHealthChangedEventHandler(int currentHealth, int maxHealth);
    public event OnPlayerHealthChangedEventHandler OnPlayerHealthChanged;

    [SerializeField] private GameObject healEffectPrefab;

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);

        PlayerHealthChanged();
    }

    public void Heal(int amount)
    {
        if (currentHealth < healthData.Health)
        {
            currentHealth = Math.Min(currentHealth + amount, healthData.Health);

            spawnGameObjectBehaviour.Spawn(healEffectPrefab, transform.position, transform.rotation);

            PlayerHealthChanged();
        }
    }

    private void PlayerHealthChanged()
    {
        // Could insert silent bugs. Use assertion?
        if (OnPlayerHealthChanged != null)
        {
            OnPlayerHealthChanged.Invoke(currentHealth, healthData.Health);
        }
    }
}