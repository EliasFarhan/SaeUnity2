using UnityEngine;
using System.Collections;

public class Stream : MonoBehaviour {

	public int a = 3;

	// Use this for initialization
	void Start () {
		BullshitChildren ();
	}
	void BullshitChildren()
	{
		transform.position = new Vector3 ();

		transform.eulerAngles = new Vector3 (0, 0, 30.0f);

		Vector3 prout = new Vector3 (
			Mathf.Cos(transform.eulerAngles.z),
			Mathf.Sin(transform.eulerAngles.z),
			0.0f);
		Debug.Log (gameObject.transform.GetChild(0).gameObject.name);
	}
	// Update is called once per frame
	void Update () {
	}
}
