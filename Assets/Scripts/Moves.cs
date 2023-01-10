using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{

	[SerializeField] Rigidbody	rb;
	[SerializeField] float		speed;

    // Start is called before the first frame update
    void Start()
    {}

	void Update()
	{
		print(transform.position.x + " / " + transform.position.z);
		Vector3 xMove = Camera.main.transform.right * Input.GetAxis("Horizontal");
		Vector3 yMove = Camera.main.transform.forward * Input.GetAxis("Vertical");


		xMove = new Vector3(xMove.x, 0, xMove.z);
		yMove = new Vector3(yMove.x, 0, yMove.z);
		
		Vector3 mov = new Vector3(xMove.x + yMove.x, 0, xMove.z + yMove.z);

		if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(mov), Time.deltaTime * 40f);
		rb.velocity = mov * speed;
    }
	
}