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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public struct AxisCalibrationData // TypeDefIndex: 6644
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
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal Dictionary<int, AxisCalibrationInfo> calibrations; // 0x30
	
		// Properties
		public static AxisCalibrationData Default { get; } // 0x0000000180909CF0-0x0000000180909E90 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static AxisCalibrationData Raw { get; } // 0x0000000180909E90-0x000000018090A030 
	
		// Constructors
		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration); // 0x0000000180022030-0x00000001800221F0
		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, float sensitivity); // 0x00000001800221F0-0x00000001800223C0
		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x00000001800223C0-0x0000000180022440
	}
}
