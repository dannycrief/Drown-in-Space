using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToOptions : MonoBehaviour {
	void OnMouseDown(){
		SceneManager.LoadScene (4);
	}
}