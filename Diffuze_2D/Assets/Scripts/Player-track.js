#pragma strict
var camreaPosition : Vector3; 
var TrackedObject : Transform; 

function Start () {
	
}

function Update () {
	transform.position = TrackedObject.position + camreaPosition;
}
