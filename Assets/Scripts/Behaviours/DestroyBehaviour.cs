using UnityEngine;

public class DestroyBehaviour : MonoBehaviour, IDestroyable
{
    public virtual void Destroy()
    {
        Destroy(gameObject);
    }
}