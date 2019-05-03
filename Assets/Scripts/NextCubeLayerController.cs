using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextCubeLayerController : MonoBehaviour {

	private void OnTriggerEnter(Collider other) {
		if (other.tag == "Exit"){
			OnExitReached(other.transform.parent.gameObject);
		}
	}
	public void OnExitReached(GameObject cube){
		cube.GetComponent<Animation>().Play();
	}

}
