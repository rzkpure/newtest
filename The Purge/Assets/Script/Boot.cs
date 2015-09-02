using UnityEngine;
using System.Collections;

public class Boot : MonoBehaviour {




	public int boot;
	//public TextMesh coinText;
	
	void OnTriggerEnter2D(Collider Collection){
		if(Collection.gameObject.tag =="Girl"){
			//Destroy(other.gameObject);
			//coin += 1;
			//Destroy(other);
			Destroy(Collection.gameObject);
		}
	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
