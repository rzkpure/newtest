using UnityEngine;
using System.Collections;

public class BootC : MonoBehaviour {


			
		public int count = 0;
		public int collectAmount = 3;
		public bool isCollected = false;
		
		void OnTriggerEnter(Collider otherCollider){
			if(isCollected){ return; }
			
			if(otherCollider.CompareTag("Boot")){
				count++;
				otherCollider.gameObject.SetActive(false);
				if(count >= collectAmount){
					isCollected = true;
}
		}
	}

	//public AchievementManager AM;
	
	/*void OnCollisionEnter(Collision Collection)
	{
		if(Collection.gameObject.name == "Boot")
		{
			//AM.OnAchievementWon("Girl");
			//Debug.Log("Congratulations - You Collected 1 / 10 ArteFacts!");
			Destroy(Collection.gameObject);
		}
	}*/
}