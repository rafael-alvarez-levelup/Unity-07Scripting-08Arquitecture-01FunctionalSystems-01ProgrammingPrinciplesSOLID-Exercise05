using UnityEngine;

[RequireComponent(typeof(PlayerHealthBehaviour))]
public class PlayerHealthChangedController : MonoBehaviour
{
    private PlayerHealthBehaviour playerHealthBehaviour;
    private LifebarManager lifebarManager;

    private void Awake()
    {
        playerHealthBehaviour = GetComponent<PlayerHealthBehaviour>();

        lifebarManager = FindObjectOfType<LifebarManager>();
    }

    private void OnEnable()
    {
        playerHealthBehaviour.OnPlayerHealthChanged += PlayerHealthBehaviour_OnPlayerHealthChanged;
    }

    private void OnDestroy()
    {
        playerHealthBehaviour.OnPlayerHealthChanged -= PlayerHealthBehaviour_OnPlayerHealthChanged;
    }

    private void PlayerHealthBehaviour_OnPlayerHealthChanged(int currentHealth, int maxHealth)
    {
        lifebarManager.UpdateLifebar(currentHealth, maxHealth);
    }
}