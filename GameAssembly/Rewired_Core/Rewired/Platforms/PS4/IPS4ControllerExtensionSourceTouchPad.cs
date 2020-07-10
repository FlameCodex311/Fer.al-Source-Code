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

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	[CustomObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	internal interface IPS4ControllerExtensionSourceTouchPad // TypeDefIndex: 6659
	{
		// Properties
		int maxTouches { get; }
	
		// Methods
		float GetTouchPixelDensity();
		int GetTouchpadResolutionX();
		int GetTouchpadResolutionY();
		int GetTouchCount();
		int GetTouchId(int index);
		bool GetTouchPositionByIndex(int index, out Vector2 position);
		bool GetTouchPositionAbsByIndex(int index, out Vector2 position);
		bool GetTouchPositionByTouchId(int touchId, out Vector2 position);
		bool GetTouchPositionAbsByTouchId(int touchId, out Vector2 position);
		bool IsTouchingByIndex(int index);
		bool IsTouchingByTouchId(int touchId);
	}
}
