using UnityEngine;

public class EnemyDeathController : MonoBehaviour
{
    private EnemyHealthBehaviour enemyHealthBehaviour;
    private IAddScorable addScorable;
    private ScoreManager scoreManager;

    private void Awake()
    {
        enemyHealthBehaviour = GetComponent<EnemyHealthBehaviour>();
        addScorable = GetComponent<IAddScorable>();

        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnEnable()
    {
        enemyHealthBehaviour.OnEnemyDeath += EnemyHealthBehaviour_OnEnemyDeath;
    }

    private void OnDestroy()
    {
        enemyHealthBehaviour.OnEnemyDeath -= EnemyHealthBehaviour_OnEnemyDeath;
    }

    private void EnemyHealthBehaviour_OnEnemyDeath()
    {
        addScorable.AddScore(scoreManager);
    }
}