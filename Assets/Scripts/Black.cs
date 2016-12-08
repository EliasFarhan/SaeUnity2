using UnityEngine;
using System.Collections;

public class Black : MonoBehaviour {

	SpriteRenderer m_SpriteRenderer;
	// Use this for initialization
	void Start () {
		m_SpriteRenderer = GetComponent<SpriteRenderer> ();
		m_SpriteRenderer.sortingOrder = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
