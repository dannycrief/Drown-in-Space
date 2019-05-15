using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour {
	void OnMouseDown(){
		SceneManager.LoadScene(0);
	}
}