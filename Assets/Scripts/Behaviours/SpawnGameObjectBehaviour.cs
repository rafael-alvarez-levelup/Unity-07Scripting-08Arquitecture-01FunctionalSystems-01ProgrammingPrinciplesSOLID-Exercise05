using UnityEngine;

public class SpawnGameObjectBehaviour : MonoBehaviour
{
    public GameObject Spawn(GameObject gameObject)
    {
        return Spawn(gameObject, Vector3.zero);
    }

    public GameObject Spawn(GameObject gameObject, Vector3 position)
    {
        return Spawn(gameObject, position, Quaternion.identity);
    }

    public GameObject Spawn(GameObject gameObject, Vector3 position, Quaternion rotation)
    {
        return Instantiate(gameObject, position, rotation);
    }
}