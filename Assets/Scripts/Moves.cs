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
		Vector3 xMove = Camera.main.transform.right * Input.GetAxis("Horizontal");
		Vector3 yMove = Camera.main.transform.forward * Input.GetAxis("Vertical");


		xMove = new Vector3(xMove.x, 0, xMove.z);
		yMove = new Vector3(yMove.x, 0, yMove.z);

		rb.velocity = (xMove + yMove) * speed;
    }
}