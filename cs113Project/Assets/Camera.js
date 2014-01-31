#pragma strict


// public fields
var target : Transform;           // the target camera is following
var dampTime : float = 0.3;          // offset from the viewport center to fix damping
var distance : float = 10;          // distance away on z axis from the target

// private fields
private var _velocity = Vector3.zero;   // velocity of camera relative to target

function Start () {

}

function Update () {

if(target) {
       // calculate the difference between camera and target positions
        var delta : Vector3 = target.position - camera.ViewportToWorldPoint(Vector3(0.5, 0.5, distance));
        
        var destination : Vector3 = transform.position + delta;
        
        transform.position = Vector3.SmoothDamp(transform.position, destination, _velocity, dampTime);
        }

}