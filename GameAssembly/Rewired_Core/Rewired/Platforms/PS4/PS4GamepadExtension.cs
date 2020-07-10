/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ControllerExtensions;
using Rewired.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Platforms.PS4
{
	public sealed class PS4GamepadExtension : PS4ControllerExtension, IDualShock4Extension // TypeDefIndex: 6664
	{
		// Properties
		private new IPS4GamepadExtensionSource Source { get; } // 0x0000000180638C20-0x0000000180638CE0 
		public int connectionType { get; } // 0x0000000180638CE0-0x0000000180638DB0 
		public int maxTouches { get; } // 0x0000000180638DB0-0x0000000180638E70 
		public float touchpadPixelDensity { get; } // 0x0000000180638F40-0x0000000180639070 
		public Vector2 touchpadResolution { get; } // 0x0000000180639210-0x0000000180639390 
		public int touchpadResolutionX { get; } // 0x0000000180639070-0x0000000180639140 
		public int touchpadResolutionY { get; } // 0x0000000180639140-0x0000000180639210 
		public int touchCount { get; } // 0x0000000180638E70-0x0000000180638F40 
	
		// Constructors
		internal PS4GamepadExtension(IPS4GamepadExtensionSource source); // 0x0000000180638C00-0x0000000180638C10
		private PS4GamepadExtension(PS4GamepadExtension source); // 0x0000000180638C10-0x0000000180638C20
	
		// Methods
		public int GetTouchId(int index); // 0x0000000180637D10-0x0000000180637DF0
		public bool GetTouchPosition(int index, out Vector2 position); // 0x0000000180638170-0x0000000180638290
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x0000000180638050-0x0000000180638170
		public bool GetTouchPositionAbsolute(int index, out Vector2 position); // 0x0000000180637F10-0x0000000180638050
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position); // 0x0000000180637DF0-0x0000000180637F10
		public bool IsTouching(int index); // 0x00000001806384D0-0x00000001806385B0
		public bool IsTouchingByTouchId(int touchId); // 0x00000001806383F0-0x00000001806384D0
		public float GetVibration(PS4GamepadMotorType motor); // 0x0000000180638290-0x00000001806383F0
		public void SetVibration(PS4GamepadMotorType motor, float motorLevel); // 0x00000001806389B0-0x00000001806389D0
		public void SetVibration(PS4GamepadMotorType motor, float motorLevel, bool stopOtherMotors); // 0x0000000180638990-0x00000001806389B0
		public void SetVibration(PS4GamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors); // 0x00000001806388B0-0x0000000180638990
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x00000001806389D0-0x0000000180638AD0
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration); // 0x0000000180638AD0-0x0000000180638C00
		Vector3 IDualShock4Extension.GetGyroscopeValue(); // 0x0000000180638730-0x00000001806388B0
		Vector3 IDualShock4Extension.GetGyroscopeValueRaw(); // 0x00000001806385B0-0x0000000180638730
		internal override Controller.Extension Clone(); // 0x0000000180637CB0-0x0000000180637D10
		private static int ItLhuewpxOtKMQonZrwdQzltTlT(PS4GamepadMotorType param_0000e4ac); // 0x00000001804259C0-0x0000000180425D40
	}
}
