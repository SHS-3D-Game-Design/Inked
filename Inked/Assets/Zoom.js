
var HipPose: Vector3;
var AimPose: Vector3;
var MainCam : GameObject;
var zoomin: float;
var zoomout: float;
var ZoomIn: Animation;
var ZoomOut: Animation;
function Start () {
transform.localPosition = HipPose;
MainCam = GameObject.FindGameObjectWithTag("MainCamera");

}

function Update () {
if(Input.GetButton("Fire2")){
transform.localPosition = AimPose;
MainCam.camera.fieldOfView = zoomin;
}
if (!Input.GetButton("Fire2")){
	transform.localPosition = HipPose;
	MainCam.camera.fieldOfView = zoomout;
}
}

