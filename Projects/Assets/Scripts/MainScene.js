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
		Application.Quit();
	}
	else{
		Application.LoadLevel(0);
	}
}


function Start () {

}

function Update () {
	
}

