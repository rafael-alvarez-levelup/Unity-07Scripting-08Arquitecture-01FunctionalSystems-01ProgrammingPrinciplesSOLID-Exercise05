using UnityEngine;

public class HealBehaviour : MonoBehaviour
{
    [SerializeField] private HealingData healData;

    public void Heal(IHealable target)
    {
        target.Heal(healData.Healing);
    }
}