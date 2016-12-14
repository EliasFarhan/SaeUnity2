using UnityEngine;
using System.Collections;

public class Black : MonoBehaviour {

	SpriteRenderer m_SpriteRenderer;

	[SerializeField] Stream m_StreamPrefab;

	// Use this for initialization
	void Start () {
		m_SpriteRenderer = GetComponent<SpriteRenderer> ();
		m_SpriteRenderer.sortingOrder = 2;

		for(int i = 0; i<50;i++)
			InstantiateStream ();

	}


	void InstantiateStream()
	{
		Stream newStream = Instantiate (m_StreamPrefab);
		newStream.gameObject.name = "Prout";
		newStream.a = 4;

		float angleDegree = 45.0f;
		float angleRadian = angleDegree / 180.0f * Mathf.PI;
		angleDegree = angleRadian / Mathf.PI * 180.0f;
		Mathf.Cos (angleRadian);
	}



	// Update is called once per frame
	void Update () {
		
	}
}
