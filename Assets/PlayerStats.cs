﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	// Player Stats
	public string username;

	public int points;

	public int hp;
	public int level = 1;
	public int experience;
	public int defense;
	public int attack;
	public int specialAttack;

	// AVATAR STATS
	public int hat;
	public int armor;
	public int glasses;
	public int shoes;
	public int weapon;

	// Workout Stats
	public int milesRan;
	public int caloriesBurned;
	public int goalsFinished;

	public GameObject statsPopup;

	lobby lobbyScript;
	
	// Use this for initialization
	void Start () {
		load ();

		if (Application.loadedLevelName == "lobby") {
			lobbyScript = GameObject.Find ("Game Controller").GetComponent<lobby>();
			lobbyScript.bindPlayerData ();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void save() {

		// Save all of this to local storage
		PlayerPrefs.SetString ("username", username);
		PlayerPrefs.SetInt("hp", hp);
		PlayerPrefs.SetInt("level", level);
		PlayerPrefs.SetInt("experience", experience);
		PlayerPrefs.SetInt("defense", defense);
		PlayerPrefs.SetInt("attack", attack);
		PlayerPrefs.SetInt("specialAttack", specialAttack);

		PlayerPrefs.SetInt("hat", hat);
		PlayerPrefs.SetInt("armor", armor);
		PlayerPrefs.SetInt("glasses", glasses);
		PlayerPrefs.SetInt("shoes", shoes);
		PlayerPrefs.SetInt("weapon", weapon);

		PlayerPrefs.SetInt("milesRan", milesRan);
		PlayerPrefs.SetInt("caloriesBurned", caloriesBurned);
		PlayerPrefs.SetInt("goalsFinished", goalsFinished);

		PlayerPrefs.SetInt ("points", points);

		if (Application.loadedLevelName == "lobby") {
			lobbyScript.bindPlayerData ();
		}
	}

	public void load() {

		// Load all data from local storage
		username = PlayerPrefs.GetString ("username");
		hp = PlayerPrefs.GetInt("hp");
		level = PlayerPrefs.GetInt("level");
		experience = PlayerPrefs.GetInt("experience");
		defense = PlayerPrefs.GetInt("defense");
		attack = PlayerPrefs.GetInt("attack");
		specialAttack = PlayerPrefs.GetInt("specialAttack");

		hat = PlayerPrefs.GetInt("hat");
		armor = PlayerPrefs.GetInt("armor");
		glasses = PlayerPrefs.GetInt("glasses");
		shoes = PlayerPrefs.GetInt("shoes");
		weapon = PlayerPrefs.GetInt("weapon");

		milesRan = PlayerPrefs.GetInt("milesRan");
		caloriesBurned = PlayerPrefs.GetInt("caloriesBurned");
		goalsFinished = PlayerPrefs.GetInt("goalsFinished");

		points = PlayerPrefs.GetInt ("points");
	}



}
