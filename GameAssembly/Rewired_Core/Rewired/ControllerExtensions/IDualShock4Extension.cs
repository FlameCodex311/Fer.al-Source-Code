/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ControllerExtensions
{
	public interface IDualShock4Extension : IControllerVibrator // TypeDefIndex: 6074
	{
		// Properties
		int maxTouches { get; }
		int touchCount { get; }
	
		// Methods
		Vector3 GetAccelerometerValue();
		Vector3 GetAccelerometerValueRaw();
		Vector3 GetGyroscopeValueRaw();
		Vector3 GetGyroscopeValue();
		Quaternion GetOrientation();
		void ResetOrientation();
		void SetLightColor(Color color);
		void SetLightColor(float red, float green, float blue);
		void SetLightColor(float red, float green, float blue, float intensity);
		int GetTouchId(int index);
		bool GetTouchPosition(int index, out Vector2 position);
		bool GetTouchPositionByTouchId(int touchId, out Vector2 position);
		bool IsTouching(int index);
		bool IsTouchingByTouchId(int touchId);
		void SetVibration(float leftMotorLevel, float rightMotorLevel);
		void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration);
	}
}
