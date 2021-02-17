using UnityEngine;

public class ScoreManager : MonoBehaviour, IScorable
{
    private UpdateScoreBehaviour updateScoreBehaviour;
    private int score;

    private void Awake()
    {
        updateScoreBehaviour = GetComponent<UpdateScoreBehaviour>();
    }

    private void Start()
    {
        updateScoreBehaviour.UpdateScore(score);
    }

    public void AddScore(int amount)
    {
        score += amount;

        updateScoreBehaviour.UpdateScore(score);
    }
}