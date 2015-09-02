using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {


	public Texture mybg;
	public Texture myBack;

	public GUIStyle customButtonMyBack;


	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);


		if(GUI.Button(new Rect(250,400,250,100), myBack,customButtonMyBack)) {
			Application.LoadLevel("UI");
		}
	}







	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
