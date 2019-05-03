using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {
	
	
	public float speed;

    void FixedUpdate()
    {
		transform.Rotate(Input.GetAxis("Vertical")*speed*Time.deltaTime, Input.GetAxis("Oculus_CrossPlatform_PrimaryIndexTrigger") *-speed*Time.deltaTime, Input.GetAxis("Horizontal")*(-speed)*Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") *speed * Time.deltaTime, 0);
    }
}
