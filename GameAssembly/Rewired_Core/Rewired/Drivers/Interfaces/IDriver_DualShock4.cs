/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Drivers.Interfaces
{
	[CustomClassObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	[CustomObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	internal interface IDriver_DualShock4 : IControllerDriver // TypeDefIndex: 6380
	{
		// Properties
		float BatteryLevel { get; }
		float LeftMotor { get; set; }
		float RightMotor { get; set; }
		float LightColorR { get; set; }
		float LightColorG { get; set; }
		float LightColorB { get; set; }
		float LightFlashOnDuration { get; set; }
		float LightFlashOffDuration { get; set; }
		Vector3 AccelerometerValue { get; }
		Vector3 AccelerometerValueRaw { get; }
		Vector3 GyroscopeValue { get; }
		Vector3 GyroscopeValueRaw { get; }
		Vector3 LastGyroscopeValue { get; }
		Vector3 LastGyroscopeValueRaw { get; }
		Quaternion Orientation { get; }
		int MaxTouches { get; }
	
		// Methods
		void ResetOrientation();
		int GetTouchCount();
		bool IsTouchingAtTouchId(int touchId);
		bool IsTouchingAtIndex(int index);
		int GetTouchIdAtIndex(int index);
		bool GetTouchPositionByIndex(int index, out Vector2 position);
		bool GetTouchPositionByTouchId(int touchId, out Vector2 position);
		bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY);
		bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY);
		void StopLightFlash();
		void StopVibration();
	}
}
