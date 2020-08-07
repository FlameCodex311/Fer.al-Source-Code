/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class TouchControls1_ManipulateCube : UnityEngine.MonoBehaviour // TypeDefIndex: 9422
	{
		// Fields
		public float rotateSpeed; // 0x18
		public float moveSpeed; // 0x1C
		private int currentColorIndex; // 0x20
		private Color[] colors; // 0x28
	
		// Constructors
		public TouchControls1_ManipulateCube(); // 0x000000018106DE40-0x000000018106DF60
	
		// Methods
		private void OnEnable(); // 0x000000018106D650-0x000000018106DA50
		private void OnDisable(); // 0x000000018106D410-0x000000018106D650
		private void OnMoveReceivedX(InputActionEventData data); // 0x000000018106DA50-0x000000018106DAA0
		private void OnMoveReceivedY(InputActionEventData data); // 0x000000018106DAA0-0x000000018106DAF0
		private void OnRotationReceivedX(InputActionEventData data); // 0x000000018106DC30-0x000000018106DC80
		private void OnRotationReceivedY(InputActionEventData data); // 0x000000018106DC80-0x000000018106DCD0
		private void OnCycleColor(InputActionEventData data); // 0x000000018106D320-0x000000018106D410
		private void OnCycleColorReverse(InputActionEventData data); // 0x000000018106D240-0x000000018106D320
		private void OnMoveReceived(Vector2 move); // 0x000000018106DAF0-0x000000018106DC30
		private void OnRotationReceived(Vector2 rotate); // 0x000000018106DCD0-0x000000018106DE40
		private void OnCycleColor(); // 0x000000018106D320-0x000000018106D410
		private void OnCycleColorReverse(); // 0x000000018106D240-0x000000018106D320
	}
}
