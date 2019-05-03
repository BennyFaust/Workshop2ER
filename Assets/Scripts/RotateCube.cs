using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {
	
	
	public float speed;

    void FixedUpdate()
    {
        transform.Rotate(Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, Input.GetAxis("Horizontal") * (-speed) * Time.deltaTime);
    }
}
