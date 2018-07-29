using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOut : MonoBehaviour {
	private void OnCollisionEnter(Collision collision) {
		GameObject.Find("Master").GetComponent<GameMaster>().GameOver();
	}
}
