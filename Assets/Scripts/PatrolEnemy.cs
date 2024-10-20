using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public float speed;
    public List<GameObject> target;
    public GameObject currentTarget;
    public int currentIndex;

    void Start()
    {
	    currentTarget = target[0];
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, speed);
       //Vector3.Distance()
       if (Vector3.Distance(transform.position, currentTarget.transform.position) < 0.5f)
       {
	       currentTarget = target[currentIndex++];
       }

       if (currentIndex >= target.Count) currentIndex = 0;
    }
}