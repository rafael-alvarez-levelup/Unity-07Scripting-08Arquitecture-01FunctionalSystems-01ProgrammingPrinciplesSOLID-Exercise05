using UnityEngine;

[RequireComponent(typeof(SearchNearestTargetBehaviour), typeof(MoveToTargetBehaviour), typeof(LookAtTargetBehaviour))]
public class MissileController : MonoBehaviour
{
    private SearchNearestTargetBehaviour searchBehaviour;
    private MoveToTargetBehaviour moveToTargetBehaviour;
    private LookAtTargetBehaviour lookAtTargetBehaviour;

    private void Awake()
    {
        searchBehaviour = GetComponent<SearchNearestTargetBehaviour>();
        moveToTargetBehaviour = GetComponent<MoveToTargetBehaviour>();
        lookAtTargetBehaviour = GetComponent<LookAtTargetBehaviour>();
    }

    public void SearchAndDestroy()
    {
        Transform target = searchBehaviour.SearchNearestTarget();
        lookAtTargetBehaviour.SetTarget(target);
        moveToTargetBehaviour.SetTarget(target);
    }
}