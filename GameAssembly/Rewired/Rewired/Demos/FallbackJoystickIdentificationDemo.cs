/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class FallbackJoystickIdentificationDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9403
	{
		// Fields
		private const float windowWidth = 250f; // Metadata: 0x00779ACB
		private const float windowHeight = 250f; // Metadata: 0x00779ACF
		private const float inputDelay = 1f; // Metadata: 0x00779AD3
		private bool identifyRequired; // 0x18
		private Queue<Joystick> joysticksToIdentify; // 0x20
		private float nextInputAllowedTime; // 0x28
		private GUIStyle style; // 0x30
	
		// Constructors
		public FallbackJoystickIdentificationDemo(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000180DD0380-0x0000000180DD0470
		private void JoystickConnected(ControllerStatusChangedEventArgs args); // 0x0000000180DD0740-0x0000000180DD0750
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args); // 0x0000000180DD0740-0x0000000180DD0750
		public void IdentifyAllJoysticks(); // 0x0000000180DD0630-0x0000000180DD0740
		private void SetInputDelay(); // 0x0000000180DD09D0-0x0000000180DD0A00
		private void OnGUI(); // 0x0000000180DD0750-0x0000000180DD09C0
		private void DrawDialogWindow(int windowId); // 0x0000000180DD0470-0x0000000180DD0630
		private void Reset(); // 0x0000000180DD09C0-0x0000000180DD09D0
	}
}
