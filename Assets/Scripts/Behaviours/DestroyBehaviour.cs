using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    public virtual void Destroy()
    {
        Destroy(gameObject);
    }
}