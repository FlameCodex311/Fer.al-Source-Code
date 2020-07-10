/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data.Mapping;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public struct AxisCalibrationData // TypeDefIndex: 6485
	{
		// Fields
		public bool enabled; // 0x00
		public float deadZone; // 0x04
		public float zero; // 0x08
		public float min; // 0x0C
		public float max; // 0x10
		public bool invert; // 0x14
		public AxisSensitivityType sensitivityType; // 0x18
		public float sensitivity; // 0x1C
		public AnimationCurve sensitivityCurve; // 0x20
		public bool applyRangeCalibration; // 0x28
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal Dictionary<int, AxisCalibrationInfo> calibrations; // 0x30
	
		// Properties
		public static AxisCalibrationData Default { get; } // 0x000000018142C0A0-0x000000018142C240 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static AxisCalibrationData Raw { get; } // 0x000000018142C240-0x000000018142C3E0 
	
		// Constructors
		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration); // 0x0000000180228700-0x00000001802288C0
		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, float sensitivity); // 0x00000001802288C0-0x0000000180228A90
		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x0000000180228A90-0x0000000180228B10
	}
}
