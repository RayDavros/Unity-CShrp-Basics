using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	public float RotationSpeed;
	public Transform Face, Player;
	float X, Y;

	void Start()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	void LateUpdate()
	{
		CamControls();
	}

	void CamControls()
	{
		X += Input.GetAxis("Mouse X") * RotationSpeed;
		Y -= Input.GetAxis("Mouse Y") * RotationSpeed;
		Y = Mathf.Clamp(Y, -45, 60);
		transform.LookAt(Face);
		if (Input.GetButton("Forward") | Input.GetButton("Back") | Input.GetButton("Left") | Input.GetButton("Right"))
		{
			Face.rotation = Quaternion.Euler(Y, X, 0);
			Player.rotation = Quaternion.Euler(0, X, 0);
		}
		else
		{
			Face.rotation = Quaternion.Euler(Y, X, 0);
		}


	}
}
