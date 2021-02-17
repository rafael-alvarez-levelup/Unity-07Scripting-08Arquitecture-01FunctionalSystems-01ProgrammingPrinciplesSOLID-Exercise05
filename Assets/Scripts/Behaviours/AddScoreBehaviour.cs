using UnityEngine;

public class AddScoreBehaviour : MonoBehaviour
{
    [SerializeField] private int score;

    public void AddScore(IScorable scorer)
    {
        scorer.AddScore(score);
    }
}