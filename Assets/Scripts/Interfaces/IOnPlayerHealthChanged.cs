public delegate void OnPlayerHealthChangedEventHandler(int currentHealth, int maxHealth);

public interface IOnPlayerHealthChanged
{
    event OnPlayerHealthChangedEventHandler OnPlayerHealthChanged;
}