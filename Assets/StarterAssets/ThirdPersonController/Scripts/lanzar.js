#pragma strict
var vel : int = 3;		
var objeto : Transform;

function Start () {
	
}

function Update () {
	if (Input.GetKeyDown("mouse 1")){
		var generar = Instantiate (objeto, transform.position, Quaternion.identity);
		
		generar.rigidbody.AddForce(transform.forward * 2000 * vel);
	}
}