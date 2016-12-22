using UnityEngine;
using System.Collections;

public class BirdEnemy : MonoBehaviour {

	[SerializeField]Transform playerTransform;
	Rigidbody2D m_Body;

	const float flyingSpeed = 0.5f;
	// Use this for initialization
	void Awake () {
		m_Body = GetComponent<Rigidbody2D> ();//GETCOMPONENTS RETURN AN ARRAY OF ALL THE COMPONENTS OF THE SAME TYPE
	}
	
	// Update is called once per frame
	void Update () {
		m_Body.velocity = (playerTransform.position - transform.position).normalized*flyingSpeed;
		//NORMALIZED RETURNS A NEW VECTOR
		//NORMALIZE() CHANGE THE CURRENT VECTOR TO A NORMALIZED ONE

	}
}
