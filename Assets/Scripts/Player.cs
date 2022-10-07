using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
	
	private static Player _instance;
	public static Player Instance{
		get{
			if(_instance == null){
				_instance = FindObjectOfType<Player>();
			}
			return _instance;
		}

	}
	
	[SerializeField] private float speed;
	[ SerializeField] private Rigidbody rgbd;
	[SerializeField] public Transform cam;
	private const float horizontalKeep = 0.01f;
	[SerializeField] private float jumpHeight;
	[SerializeField] private Vector2 cameraSpeed;
	[SerializeField] private Vector2 cameraSpeedDivider;
	private bool jumpAvaible = true;

	private void Start() {
		cam.localRotation = Quaternion.identity;
	}

	private void Update() {
		RotationUpdate();
		JumpUpdate();	
		MovementUpdate();
	}

	private void OnCollisionEnter(Collision collision) {
		jumpAvaible = true;
	}


	private void JumpUpdate(){
		if(jumpAvaible && Input.GetKeyDown(KeyCode.Space)){
			jumpAvaible = false;
			float jumpVelocity = Mathf.Sqrt(10f*jumpHeight);
			rgbd.velocity = rgbd.velocity.YAs(jumpVelocity);	
		}
	}

	private void MovementUpdate(){
		Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		if(movementInput.sqrMagnitude > 1f){ 
			movementInput.Normalize();
		}
		float verticalVelocity = rgbd.velocity.y;
		rgbd.velocity = speed * transform.TransformDirection(new Vector3(movementInput.x, 0, movementInput.y));
		rgbd.velocity = rgbd.velocity.YAs(verticalVelocity);
	}

	private void RotationUpdate(){ 
		Vector2 cameraInput = new Vector2(Input.GetAxisRaw("CameraX"),Input.GetAxisRaw("CameraY"));
				
		transform.Rotate(Vector3.up * (cameraSpeed.x/cameraSpeedDivider.x)*cameraInput.x, Space.Self);
		
		float yCameraDelta = (cameraSpeed.y/cameraSpeedDivider.y) * cameraInput.y;
		Vector3 targetLook = ((transform.forward.YAs(0).normalized)*horizontalKeep).YAs(Mathf.Sign(yCameraDelta)).normalized;
		cam.forward = Vector3.RotateTowards(cam.forward, targetLook, Mathf.Abs( yCameraDelta * Mathf.Deg2Rad), 0f);
	}

}
