using UnityEngine;

public class Intersection : Road
{
    [SerializeField] private Road[] connected;

    public override bool TryGetNext(out Road road) {
        road = connected[Random.Range(0, connected.Length)];
        return road is Road;
    }

    public void OnDrawGizmos() {
        if(connected is null) return;
        foreach (Road road in connected)
        {
            if(road != null) Gizmos.DrawLine(Vector, road.Vector);;
        }
    }
}
