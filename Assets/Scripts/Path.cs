using UnityEngine;

public class Path : Road
{
    [SerializeField] private Road connected;

    public override bool TryGetNext(out Road road) {
        road = connected;
        return road is Road;
    }

    public void OnDrawGizmos() {
        if(connected != null) Gizmos.DrawLine(Vector, connected.Vector);
    }
}
