/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
	public sealed class Axis2DCalibration // TypeDefIndex: 6486
	{
		// Fields
		[CustomObfuscation] // 0x000000018016B4F0-0x000000018016B550
		[SerializeField] // 0x000000018016B4F0-0x000000018016B550
		[Tooltip] // 0x000000018016B4F0-0x000000018016B550
		private DeadZone2DType _deadZoneType; // 0x10
		[CustomObfuscation] // 0x000000018016B6E0-0x000000018016B740
		[SerializeField] // 0x000000018016B6E0-0x000000018016B740
		[Tooltip] // 0x000000018016B6E0-0x000000018016B740
		private AxisSensitivity2DType _sensitivityType; // 0x14
	
		// Properties
		public DeadZone2DType deadZoneType { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public AxisSensitivity2DType sensitivityType { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
	
		// Constructors
		internal Axis2DCalibration(); // 0x00000001807711B0-0x00000001807711C0
	
		// Methods
		internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis); // 0x000000018142B730-0x000000018142B770
		internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType); // 0x000000018142B770-0x000000018142C0A0
	}
}
