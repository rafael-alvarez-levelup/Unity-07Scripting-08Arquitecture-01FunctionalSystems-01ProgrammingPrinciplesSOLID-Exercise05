using UnityEngine;

public class SpawnGameObjectBehaviour : MonoBehaviour, IGameObjectSpawnable
{
    public GameObject Spawn(GameObject gameObject, Vector3 position, Quaternion rotation)
    {
        return Instantiate(gameObject, position, rotation);
    }
}