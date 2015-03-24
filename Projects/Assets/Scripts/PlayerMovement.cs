using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	public AudioClip AC;
	public BonusGUI getClassBonus ;

	private Vector3 StartPos = new Vector3(300.0f, 3.0f, 300.0f);

	
	// Use this for initialization
	//[RequireComponent(typeof(AudioSource))]
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxisRaw("Horizontal") * rotationSpeed;
		float translationUD = speed *10 ;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(translation, 0, 0);
		transform.Rotate(0, rotation, 0);

		if (Input.GetMouseButtonDown (0)) {
			translationUD *= Time.deltaTime;
			transform.Translate(0,translationUD,0);
				}
		if (Input.GetMouseButtonDown(1)){
			translationUD *= -Time.deltaTime;
			transform.Translate(0,translationUD,0);
		}

		if(transform.position.y <= -10 || transform.position.y >= 50){
			transform.position = StartPos;
		}
	}

	void OnTriggerEnter(Collider e)  
	{  
		if (e.gameObject.tag.CompareTo("Goal")==0)  
		{   
			Debug.Log("Goal");  
			AudioSource.PlayClipAtPoint(AC, transform.localPosition); 
			Destroy(e.gameObject);
			getClassBonus.Bonus -= 1;

		}  
		
		if (e.gameObject.tag.CompareTo("Enemie") == 0)  
		{  
			Debug.Log("Enemie");  
			transform.position = StartPos;
		} 
	} 

	//void OnCollisionEnter(Collision collision1){
		//if(collision1.gameObject.tag = "Goal"){
		//	AudioSource.PlayClipAtPoint(AC, transform.localPosition); 
		//	Destroy(gameObject);
		//}
	//}
}
