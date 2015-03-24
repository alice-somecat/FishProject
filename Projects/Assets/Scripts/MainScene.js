#pragma strict
var isQuit = false;

function OnMouseEnter(){
	renderer.material.color = Color.blue;
}


function OnMouseExit(){
	renderer.material.color = Color.white;
}


function OnMouseUp(){
	if(isQuit == true){
		Debug.Log("exitMain");
		Application.Quit();
	}
	else{
		Debug.Log("loadLevel");
		Application.LoadLevel(1);
	}
}


function Start () {

}

function Update () {
	if(Input.GetButtonDown("Jump")){
	  Debug.Log ("exitMain");
	  Application.Quit();
	}
}

