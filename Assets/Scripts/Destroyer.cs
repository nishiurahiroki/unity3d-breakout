using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
	public GameObject master;

	private void OnCollisionEnter(Collision collision) {
		master.GetComponent<GameMaster>().enemyCount--;
		Destroy(gameObject);
	}
}
