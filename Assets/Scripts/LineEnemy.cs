using UnityEngine;

public class LineEnemy : MonoBehaviour
{
    public float speed;
    public GameObject target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}