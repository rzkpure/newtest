using UnityEngine;
using System.Collections;

public class MoveCha1 : MonoBehaviour {




	public Animator anim;
	private bool checkwalk;
	private bool checkjump;
	//public float jumpSpeed = 6f;
	//public float velocityY = 0f;
	//public float gravity = 10f;
	
	
	
	//static var point : int =0;
	
	//public var groundedEnd : Transform ;
	
	//public var grounded : boolean = false;
	
	//static var timmer : float = 100.0f ;
	
	
	void Update () {
		
		playerMove();
		playerJump ();
		SetAnimation();
		
		//Raycasting();
		//playerJump();
	}
	
	int speed = 5;
	
	
	void playerMove(){
		
		
		
		transform.Translate(Vector3.right * Time.deltaTime * speed);
		checkwalk = false;
		checkjump = true;
		
	}
	
	
	
	void playerJump(){
		if(Input.GetKey("w"))
			
			
			//transform.Translate(Vector2.right * Time.deltaTime * 10);
			transform.Translate(0,10*Time.deltaTime,0);
		
		//checkwalk = false;
		//checkjump = true;
		
		//rigidbody2D.AddForce(Vector2.up*3000f);
		else{
			checkwalk = true;
			checkjump = false;
		}
	}
	
	
	void SetAnimation(){
		anim.SetBool("Boy1", checkwalk && !checkjump);
		anim.SetBool("BoyJump", !checkwalk && checkjump);
	}
	
	
	
	
}






