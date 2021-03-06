﻿using Entitas;
using UnityEngine;
using UnityEngine.InputNew;

public class MouseInputSystem : IInitializeSystem, IExecuteSystem
{
	MyInputs mInput;
	PlayerInput playerInput;

	RaycastHit hit;
	int groundMask;


	public void Initialize ()
	{
		playerInput = GameObject.FindObjectOfType <PlayerInput> ();
		if (playerInput) 
			mInput = playerInput.GetActions <MyInputs> ();

		var groundLayer = LayerMask.NameToLayer ("Ground");
		groundMask = 1 << groundLayer;
	}

	public void Execute ()
	{
		var leftMouseDown = mInput.leftClick.wasJustPressed;
		if (leftMouseDown) {

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Mouse.current.position), out hit, Mathf.Infinity)) {
				Messenger.Broadcast <RaycastHit> (Events.Input.LeftMouseClick, hit);
			}
		}

		var leftMouseHeld = mInput.leftClick.isHeld;
		if (leftMouseHeld) {

		}

		var leftMouseUp = mInput.leftClick.wasJustReleased;
		if (leftMouseUp) {

		}



		var middleClick = mInput.middleClick.wasJustPressed;
		if (middleClick) {
			Physics.Raycast (Camera.main.ScreenPointToRay (Mouse.current.position), out hit, Mathf.Infinity);
			Messenger.Broadcast <RaycastHit> (Events.Input.MiddleMouseClick, hit);
		}

		var rightClick = mInput.rightClick.wasJustPressed;
		if (rightClick) {
			if (Physics.Raycast (Camera.main.ScreenPointToRay (Mouse.current.position), out hit, Mathf.Infinity, groundMask)) {
				Messenger.Broadcast <RaycastHit> (Events.Input.RightMouseClick, hit);
			}
		}
	}

}
