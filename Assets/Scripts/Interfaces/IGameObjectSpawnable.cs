using UnityEngine;

public interface IGameObjectSpawnable
{
    GameObject Spawn(GameObject gameObject, Vector3 position, Quaternion rotation);
}
