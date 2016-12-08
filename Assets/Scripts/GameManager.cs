using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	[SerializeField] int prout = 5;

	void Awake() {

	}

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (prout == 6)
			SceneManager.LoadScene ("Test2");
	}

	void FixedUpdate () {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		
	}
}
