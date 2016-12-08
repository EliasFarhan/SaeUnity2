using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	[SerializeField] int prout = 3;

	void Awake() {
		prout = 6;
	}

	// Use this for initialization
	void Start () {
		//prout = 7;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		
	}
}
