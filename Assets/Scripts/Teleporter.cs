using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject nextLevel;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            other.transform.position = nextLevel.transform.position;
            other.gameObject.GetComponent<Player>().startPos = nextLevel.transform.position;
        }
    }
}