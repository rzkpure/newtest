using UnityEngine;
using System.Collections;

public class TankGameLogic : MonoBehaviour {
	


	public float roundTime = 30.0f;
	
	// Use this for initialization
	void Start () {
		roundTime = 30;
	}
	
	// Update is called once per frame
	void Update () {

		roundTime -= Time.deltaTime;
		while(roundTime >= 30.0f)
		{
			roundTime--;
		}
	}


	void OnGUI(){

			GUI.Label(new Rect(10,10,200,20), "Time  : "+roundTime);

	}
}











