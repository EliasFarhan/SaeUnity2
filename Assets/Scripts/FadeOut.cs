using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {
    SpriteRenderer fadeRenderer;
	// Use this for initialization
	void Awake () {
        fadeRenderer = GetComponent<SpriteRenderer>();
        Debug.Log(fadeRenderer.color.a);
    }
	
	// Update is called once per frame
	void Update () {
        fadeRenderer.color = new Color(1.0f,1.0f,1.0f, 
            fadeRenderer.color.a-1.0f *Time.deltaTime);
        
	}
}
