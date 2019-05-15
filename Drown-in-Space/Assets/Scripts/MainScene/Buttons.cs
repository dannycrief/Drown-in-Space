using System.Collections;
using UnityEngine;

public class Buttons : MonoBehaviour {

	void OnMouseDown(){
		transform.localScale = new Vector3 (0.021f, 0.021f, 0.021f);
	}

	void OnMouseUp(){
		transform.localScale = new Vector3 (0.02f, 0.02f, 0.02f);
	}
}
