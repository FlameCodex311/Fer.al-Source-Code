/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class FallbackJoystickIdentificationDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9237
	{
		// Fields
		private const float windowWidth = 250f; // Metadata: 0x00744DDD
		private const float windowHeight = 250f; // Metadata: 0x00744DE1
		private const float inputDelay = 1f; // Metadata: 0x00744DE5
		private bool identifyRequired; // 0x18
		private Queue<Joystick> joysticksToIdentify; // 0x20
		private float nextInputAllowedTime; // 0x28
		private GUIStyle style; // 0x30
	
		// Constructors
		public FallbackJoystickIdentificationDemo(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x00000001815B5AD0-0x00000001815B5BC0
		private void JoystickConnected(ControllerStatusChangedEventArgs args); // 0x00000001815B5EA0-0x00000001815B5EB0
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args); // 0x00000001815B5EA0-0x00000001815B5EB0
		public void IdentifyAllJoysticks(); // 0x00000001815B5D80-0x00000001815B5EA0
		private void SetInputDelay(); // 0x00000001815B6130-0x00000001815B6160
		private void OnGUI(); // 0x00000001815B5EB0-0x00000001815B6120
		private void DrawDialogWindow(int windowId); // 0x00000001815B5BC0-0x00000001815B5D80
		private void Reset(); // 0x00000001815B6120-0x00000001815B6130
	}
}
