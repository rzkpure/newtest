using UnityEngine;
using System.Collections;

public class SelectCha : MonoBehaviour {


	public Texture mybg;
	public Texture mytex1;
	public Texture mytex2;


	public GUIStyle customButtonMyCharacter1;
	public GUIStyle customButtonMyCharacter2;

	
	
	void OnGUI () {
		
		GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), mybg);
		
		if(GUI.Button(new Rect(250,100,280,450), mytex1,customButtonMyCharacter1)) {
			Application.LoadLevel("SelectLevel");
		}


		if(GUI.Button(new Rect(600,100,250,450), mytex2,customButtonMyCharacter2)) {
			Application.LoadLevel("SelectLevel2");
		}
	}
	


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}




