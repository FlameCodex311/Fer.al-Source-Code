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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Platforms.PS4
{
	public sealed class PS4GamepadExtension : PS4ControllerExtension, IDualShock4Extension // TypeDefIndex: 6823
	{
		// Properties
		private new IPS4GamepadExtensionSource Source { get; } // 0x0000000180EB0440-0x0000000180EB0500 
		public int connectionType { get; } // 0x0000000180EB0500-0x0000000180EB05C0 
		public int maxTouches { get; } // 0x0000000180EB05C0-0x0000000180EB0680 
		public float touchpadPixelDensity { get; } // 0x0000000180EB0740-0x0000000180EB0870 
		public Vector2 touchpadResolution { get; } // 0x0000000180EB09F0-0x0000000180EB0B70 
		public int touchpadResolutionX { get; } // 0x0000000180EB0870-0x0000000180EB0930 
		public int touchpadResolutionY { get; } // 0x0000000180EB0930-0x0000000180EB09F0 
		public int touchCount { get; } // 0x0000000180EB0680-0x0000000180EB0740 
	
		// Constructors
		internal PS4GamepadExtension(IPS4GamepadExtensionSource source); // 0x0000000180EB0420-0x0000000180EB0430
		private PS4GamepadExtension(PS4GamepadExtension source); // 0x0000000180EB0430-0x0000000180EB0440
	
		// Methods
		public int GetTouchId(int index); // 0x0000000180EAF550-0x0000000180EAF630
		public bool GetTouchPosition(int index, out Vector2 position); // 0x0000000180EAF9B0-0x0000000180EAFAD0
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x0000000180EAF890-0x0000000180EAF9B0
		public bool GetTouchPositionAbsolute(int index, out Vector2 position); // 0x0000000180EAF750-0x0000000180EAF890
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position); // 0x0000000180EAF630-0x0000000180EAF750
		public bool IsTouching(int index); // 0x0000000180EAFD10-0x0000000180EAFDF0
		public bool IsTouchingByTouchId(int touchId); // 0x0000000180EAFC30-0x0000000180EAFD10
		public float GetVibration(PS4GamepadMotorType motor); // 0x0000000180EAFAD0-0x0000000180EAFC30
		public void SetVibration(PS4GamepadMotorType motor, float motorLevel); // 0x0000000180EB01D0-0x0000000180EB01F0
		public void SetVibration(PS4GamepadMotorType motor, float motorLevel, bool stopOtherMotors); // 0x0000000180EB01B0-0x0000000180EB01D0
		public void SetVibration(PS4GamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180EB00D0-0x0000000180EB01B0
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x0000000180EB01F0-0x0000000180EB02F0
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration); // 0x0000000180EB02F0-0x0000000180EB0420
		Vector3 IDualShock4Extension.GetGyroscopeValue(); // 0x0000000180EAFF60-0x0000000180EB00D0
		Vector3 IDualShock4Extension.GetGyroscopeValueRaw(); // 0x0000000180EAFDF0-0x0000000180EAFF60
		internal override Controller.Extension Clone(); // 0x0000000180EAF4F0-0x0000000180EAF550
		private static int ItLhuewpxOtKMQonZrwdQzltTlT(PS4GamepadMotorType param_0000e71c); // 0x0000000180831220-0x0000000180831570
	}
}
