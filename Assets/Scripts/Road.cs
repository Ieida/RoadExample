using UnityEngine;

public abstract class Road : MonoBehaviour
{
    public Vector3 Vector => transform.position;
    public abstract bool TryGetNext(out Road connected);
}
