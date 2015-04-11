using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player : MonoBehaviour {

	public string username;

	public int hp;
	public int attackPower;
	public int defense;

	public PlayerStats playerStats;

	// AVATAR STATS
	public int hat;
	public int armor;
	public int glasses;
	public int shoes;
	public int weapon;

	public bool localPlayer;

	void Awake() {

		playerStats = GameObject.Find("Player Stats").GetComponent<PlayerStats>();

		if (localPlayer) {
			transform.FindChild ("Hat").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Hat/" + playerStats.hat) as Sprite;
			transform.FindChild ("Armor").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Armor/" + playerStats.armor) as Sprite;
			transform.FindChild ("Glasses").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Glasses/" + playerStats.glasses) as Sprite;
			transform.FindChild ("Shoes").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Shoes/" + playerStats.shoes) as Sprite;
			transform.FindChild ("Weapon").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Weapon/" + playerStats.weapon) as Sprite;
		} else {
			transform.FindChild ("Hat").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Hat/" + hat) as Sprite;
			transform.FindChild ("Armor").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Armor/" + armor) as Sprite;
			transform.FindChild ("Glasses").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Glasses/" + glasses) as Sprite;
			transform.FindChild ("Shoes").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Shoes/" + shoes) as Sprite;
			transform.FindChild ("Weapon").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Avatar/Weapon/" + weapon) as Sprite;
		}
	}

	public void attack() {

	}

	public void defend() {

	}

	public void takeDamage(int damageToTake) {
		hp -= damageToTake;
		checkForDeath ();
	}

	public void checkForDeath() {

		if (hp <= 0) {
			die ();
		}
	}

	public void die() {
		//TODO: play the death animation and then end the game after a certain amount of time. 
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.gameObject.tag == "Weapon") {
			takeDamage(coll.gameObject.transform.parent.gameObject.GetComponent<player>().attackPower);
		}
	}
}
