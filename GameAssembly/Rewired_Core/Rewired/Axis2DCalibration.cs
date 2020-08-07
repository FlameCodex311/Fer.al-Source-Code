/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
	public sealed class Axis2DCalibration // TypeDefIndex: 6645
	{
		// Fields
		[CustomObfuscation] // 0x000000018020A060-0x000000018020A0C0
		[SerializeField] // 0x000000018020A060-0x000000018020A0C0
		[Tooltip] // 0x000000018020A060-0x000000018020A0C0
		private DeadZone2DType _deadZoneType; // 0x10
		[CustomObfuscation] // 0x000000018020A2E0-0x000000018020A340
		[SerializeField] // 0x000000018020A2E0-0x000000018020A340
		[Tooltip] // 0x000000018020A2E0-0x000000018020A340
		private AxisSensitivity2DType _sensitivityType; // 0x14
	
		// Properties
		public DeadZone2DType deadZoneType { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public AxisSensitivity2DType sensitivityType { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
	
		// Constructors
		internal Axis2DCalibration(); // 0x0000000180909C80-0x0000000180909CF0
	
		// Methods
		internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis); // 0x0000000180909390-0x00000001809093D0
		internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType); // 0x00000001809093D0-0x0000000180909C80
	}
}
