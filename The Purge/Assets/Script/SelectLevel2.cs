using UnityEngine;
using System.Collections;

public class SelectLevel2 : MonoBehaviour {





	public Texture mybg;
	public Texture myEasy2;
	public Texture myNormal2;
	public Texture myHard2;
	
	public GUIStyle customButtonMyEasy2;
	public GUIStyle customButtonMyNormal2;
	public GUIStyle customButtonMyHard2;
	
	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);
		
		
		if(GUI.Button(new Rect(150,280,250,100), myEasy2,customButtonMyEasy2)) {
			Application.LoadLevel("PlayEasy2");
			
		}
		
		if(GUI.Button(new Rect(450,280,250,100), myNormal2,customButtonMyNormal2)) {
			Application.LoadLevel("PlayNormal2");
		}
		
		
		if(GUI.Button(new Rect(750,280,250,100), myHard2,customButtonMyHard2)) {
			Application.LoadLevel("PlayHard2");
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
