using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed;
	public Vector3 startPos;

	void Start()
	{
		startPos = transform.position;
	}

	void Update()
	{
		Vector3 dir = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		transform.position += dir * speed;
	}

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.name.Contains("Enemy"))
		{
			transform.position = startPos;
		}
	}
}