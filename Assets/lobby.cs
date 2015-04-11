using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lobby : MonoBehaviour {

	PlayerStats playerStats;

	public GameObject statsPopup;

	// Use this for initialization
	void Start () {
		playerStats = GameObject.Find("Player Stats").GetComponent<PlayerStats>();
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

	public void bindPlayerData() {
		
		// Set stats UI elements from local storage
		
		// Bind players data to ui elements in the stats popup
		statsPopup.transform.FindChild("HP").GetComponent<Text>().text = playerStats.hp.ToString();
		statsPopup.transform.FindChild("Attack").GetComponent<Text>().text = playerStats.attack.ToString();
		statsPopup.transform.FindChild("Special Attack").GetComponent<Text>().text = playerStats.specialAttack.ToString();
		statsPopup.transform.FindChild("Defense").GetComponent<Text>().text = playerStats.defense.ToString();
		statsPopup.transform.FindChild ("Points").GetComponent<Text> ().text = playerStats.points.ToString ();
		statsPopup.transform.FindChild ("User").FindChild("Username").GetComponent<Text>().text = playerStats.username.ToString();
		
	}

	public void addToStat(string stat) {
		
		// Check if they have avaliable points
		if (playerStats.points < 1) {
			return;
		}
		
		if (stat == "hp") {
			playerStats.hp += 10;
		} else if (stat == "attack") {
			playerStats.attack += 1;
		} else if (stat == "defense") {
			playerStats.defense += 1;
		} else if (stat == "special attack") {
			playerStats.specialAttack += 1;
		}
		
		playerStats.points -= 1;
		
		playerStats.save ();
	}
}
