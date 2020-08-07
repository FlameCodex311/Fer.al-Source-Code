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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	[CustomObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	internal interface IPS4ControllerExtensionSource : IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight // TypeDefIndex: 6817
	{
		// Methods
		int GetUserId();
		int GetUserStatus();
		bool GetUserIsPrimary();
		Color GetUserColor();
		int GetUserColorId();
		string GetUserName();
	}
}
