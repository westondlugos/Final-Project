using UnityEngine;
using System.Collections;
public class Open : MonoBehaviour {
	
	public Rigidbody rb;

	public float open = 0f;

	void FixedUpdate () 
	{
		rb.AddForce (open, 0, 0 * Time.deltaTime);

		if (Input.GetKey("f"))
		{
			rb.AddForce (25 * Time.deltaTime, 0, 0);
		}
	}
}