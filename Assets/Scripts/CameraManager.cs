using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField] Transform pl;
	[SerializeField] Vector3 offset;

    void Start() {
		transform.rotation = Quaternion.Euler(35.264f, -45f, 0);
    }

	void LateUpdate() {
    	Vector3 target = new Vector3(pl.position.x, 0, pl.position.z) + offset;
    	transform.position = Vector3.Slerp(transform.position, target, Time.deltaTime);
	}
}
