using UnityEngine;
using System.Collections;

public class MassSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    [Space]
    [SerializeField] private uint count;
    [SerializeField] private float rate;
    [Space]
    [SerializeField] private Road road;

    private void Start() {StartCoroutine(Spawn());}

    IEnumerator Spawn() {
        for (uint i = 0; i < count; i++)
        {
            yield return new WaitForSeconds(rate);
            GameObject spawned = Instantiate(spawnPrefab, road.Vector, Quaternion.identity, transform);
            Enemy enemy = spawned.GetComponent<Enemy>();
            enemy.Road = road;
            enemy.Speed = enemy.Speed*Random.Range(0.2f, 1.5f);
        }
    }
}
