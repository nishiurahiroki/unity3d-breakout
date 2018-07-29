using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

	public int enemyCount;
	public float time;

	void Start () {
		this.time = 0;
	}

	void Update () {
		this.time = Time.deltaTime;

		if(this.enemyCount <= 0) {
			this.GameOver();
		}
	}

	public void GameOver() {
		SceneManager.LoadScene("Result");
	}
}
