using UnityEngine;
using System.Collections;

public class SelectLevel : MonoBehaviour {


	public Texture mybg;
	public Texture myEasy;
	public Texture myNormal;
	public Texture myHard;

	public GUIStyle customButtonMyEasy;
	public GUIStyle customButtonMyNormal;
	public GUIStyle customButtonMyHard;
	
	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);
		
		
		if(GUI.Button(new Rect(150,280,250,100), myEasy,customButtonMyEasy)) {
			Application.LoadLevel("PlayEasy");
			
		}
		
		if(GUI.Button(new Rect(450,280,250,100), myNormal,customButtonMyNormal)) {
			Application.LoadLevel("PlayNormal");
		}


		if(GUI.Button(new Rect(750,280,250,100), myHard,customButtonMyHard)) {
			Application.LoadLevel("PlayHard");
		}
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
