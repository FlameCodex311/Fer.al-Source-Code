/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Drivers.Interfaces
{
	[CustomClassObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	[CustomObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	internal interface IControllerDriver // TypeDefIndex: 6538
	{
		// Properties
		int AxisCount { get; }
		int ButtonCount { get; }
		int HatCount { get; }
		int AccelerometerCount { get; }
		int GyroscopeCount { get; }
		int TouchpadCount { get; }
		int LightCount { get; }
		int VibrationMotorCount { get; }
	}
}
