using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour 
{
	public float speed;
	private Rigidbody rb;

	void start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Fixedupdate() 
	{
		if (Input.GetKey (KeyCode.Space)) 
		{
			rb.AddForce(Vector3.up * speed);
		}
		                  
	}

}

