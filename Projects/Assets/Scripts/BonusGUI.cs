using UnityEngine;
using System.Collections;

public class BonusGUI : MonoBehaviour {
	public int Bonus = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Bonus left is : " + Bonus; 
		if(Bonus == 0){
			Application.LoadLevel(1);
		}
	}
}
