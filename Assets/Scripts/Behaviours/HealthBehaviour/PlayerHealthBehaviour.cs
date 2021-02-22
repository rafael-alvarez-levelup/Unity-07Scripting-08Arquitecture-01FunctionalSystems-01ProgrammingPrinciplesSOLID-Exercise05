using System;
using UnityEngine;

public class PlayerHealthBehaviour : HealthBehaviour, IHealable, IOnPlayerHealthChanged
{
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

            gameObjectSpawnable.Spawn(healEffectPrefab, transform.position, transform.rotation);

            PlayerHealthChanged();
        }
    }

    private void PlayerHealthChanged()
    {
        if (OnPlayerHealthChanged != null)
        {
            OnPlayerHealthChanged.Invoke(currentHealth, healthData.Health);
        }
    }
}