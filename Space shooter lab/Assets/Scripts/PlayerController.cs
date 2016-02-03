using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
		Rigidbody.velocity = some Vector3 value;
	}
}
