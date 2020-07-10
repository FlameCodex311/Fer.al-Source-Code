/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class TouchControls1_ManipulateCube : UnityEngine.MonoBehaviour // TypeDefIndex: 9256
	{
		// Fields
		public float rotateSpeed; // 0x18
		public float moveSpeed; // 0x1C
		private int currentColorIndex; // 0x20
		private Color[] colors; // 0x28
	
		// Constructors
		public TouchControls1_ManipulateCube(); // 0x0000000181BCC210-0x0000000181BCC330
	
		// Methods
		private void OnEnable(); // 0x0000000181BCBA20-0x0000000181BCBE20
		private void OnDisable(); // 0x0000000181BCB7E0-0x0000000181BCBA20
		private void OnMoveReceivedX(InputActionEventData data); // 0x0000000181BCBE20-0x0000000181BCBE70
		private void OnMoveReceivedY(InputActionEventData data); // 0x0000000181BCBE70-0x0000000181BCBEC0
		private void OnRotationReceivedX(InputActionEventData data); // 0x0000000181BCC000-0x0000000181BCC050
		private void OnRotationReceivedY(InputActionEventData data); // 0x0000000181BCC050-0x0000000181BCC0A0
		private void OnCycleColor(InputActionEventData data); // 0x0000000181BCB6F0-0x0000000181BCB7E0
		private void OnCycleColorReverse(InputActionEventData data); // 0x0000000181BCB600-0x0000000181BCB6F0
		private void OnMoveReceived(Vector2 move); // 0x0000000181BCBEC0-0x0000000181BCC000
		private void OnRotationReceived(Vector2 rotate); // 0x0000000181BCC0A0-0x0000000181BCC210
		private void OnCycleColor(); // 0x0000000181BCB6F0-0x0000000181BCB7E0
		private void OnCycleColorReverse(); // 0x0000000181BCB600-0x0000000181BCB6F0
	}
}
