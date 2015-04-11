using UnityEngine;
using System.Collections;

public class lobby : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadScene(string level) {
		Application.LoadLevel(level);
	}

	public void closeAllPopups() {
		foreach(GameObject popup in GameObject.FindGameObjectsWithTag("popup")) {
			popup.transform.localScale = Vector3.zero;
		}
	}

	public void closePopup(string popup) {
		GameObject.Find (popup).transform.localScale = Vector3.zero;
	}

	public void showPopup(string popup) {
		GameObject.Find (popup).transform.localScale = Vector3.one;
	}
}
