using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Road road;
    public Road Road{
        get => road;
        set{road = value;}
    }
    [Space]
    [SerializeField] private float speed;
    public float Speed{
        get => speed;
        set{speed = value;}
    }

    private void Update() {
        Move();
    }

    private void Move() {
        //if path was reached
        if(Vector3.Distance(transform.position, road.Vector) < 0.02f)
        {
            //if there is a next path, update the current path
            //else return out of the method
            if(road.TryGetNext(out Road connected)) road = connected;
            else
            {
                //if this else runs, it means the enemy has reached the end of the road
                Debug.Log(gameObject.name+" got to the end");
                this.enabled = false;
                return;
            }
        }
        Vector3 point = road.Vector;
        //move code...
        transform.position += (point-transform.position).normalized*speed*Time.deltaTime;
    }
}
