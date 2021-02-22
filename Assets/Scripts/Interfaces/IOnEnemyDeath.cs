public delegate void EnemyDeathEventHandler();

public interface IOnEnemyDeath
{
    event EnemyDeathEventHandler OnEnemyDeath;
}