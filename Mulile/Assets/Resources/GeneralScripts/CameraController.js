#pragma strict

var target : Transform;
var xDistance : float;
var yDistance : float;
	
function Start () {

}

 function Update(){ 
    //transform.position.z = target.position.z -distance;
	transform.position.y = target.position.y - yDistance; // Follow Bottle Y Pos
    transform.position.x = target.position.x - xDistance; // Follow Bottle X Pos 
 }