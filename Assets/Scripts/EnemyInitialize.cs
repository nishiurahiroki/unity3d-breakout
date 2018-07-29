using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInitialize : MonoBehaviour {

	public GameObject enemyPrefab;
	public GameObject enemy;

	void Awake() {
		const int VERTICAL_ENEMY_COUNT = 8;
		const int HORIZONTAL_ENEMY_COUNT = 5;

		var master = GameObject.Find("Master");
		for(int x = 0; x < VERTICAL_ENEMY_COUNT; x++) {
			for(int y = 0; y < HORIZONTAL_ENEMY_COUNT; y++) {
				var enemys = Instantiate(enemyPrefab, enemy.transform);
				enemys.transform.position = new Vector3(
					(2f + (1f * y)),
					0.4f,
					(-4.2f + (1.2f * x))
				);
				enemys.GetComponent<Destroyer>().master = master;
			}
		}
	}
}
