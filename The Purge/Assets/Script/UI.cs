using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	

	public Texture mybg;
	public Texture myplay;
	public Texture myTutorial;
	public Texture myExit;

	public GUIStyle customButtonMyPlay;
	public GUIStyle customButtonMyTutorial;
	public GUIStyle customButtonMyExit;

	
	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);


		if(GUI.Button(new Rect(450,300,200,80), myplay,customButtonMyPlay)) {
			Application.LoadLevel("SelectCharacter");
			
		}

		if(GUI.Button(new Rect(450,400,200,80), myTutorial,customButtonMyTutorial)) {
			Application.LoadLevel("Tutorial");
		}

		
		if(GUI.Button(new Rect(450,500,200,80), myExit,customButtonMyExit)) {
			Application.Quit();
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
