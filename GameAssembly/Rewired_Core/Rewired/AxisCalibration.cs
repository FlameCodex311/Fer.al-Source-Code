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
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000180207920-0x0000000180207950
	public sealed class AxisCalibration // TypeDefIndex: 6643
	{
		// Fields
		private AlternateAxisCalibrationType _calibrationMode; // 0x10
		private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations; // 0x18
		[CustomObfuscation] // 0x0000000180207B10-0x0000000180207B70
		[SerializeField] // 0x0000000180207B10-0x0000000180207B70
		[Tooltip] // 0x0000000180207B10-0x0000000180207B70
		private bool _enabled; // 0x20
		[CustomObfuscation] // 0x0000000180207B10-0x0000000180207B70
		[SerializeField] // 0x0000000180207B10-0x0000000180207B70
		[Tooltip] // 0x0000000180207B10-0x0000000180207B70
		private float _deadZone; // 0x24
		[CustomObfuscation] // 0x00000001802081C0-0x0000000180208220
		[SerializeField] // 0x00000001802081C0-0x0000000180208220
		[Tooltip] // 0x00000001802081C0-0x0000000180208220
		private float _calibratedZero; // 0x28
		[CustomObfuscation] // 0x00000001802084B0-0x0000000180208510
		[SerializeField] // 0x00000001802084B0-0x0000000180208510
		[Tooltip] // 0x00000001802084B0-0x0000000180208510
		private float _calibratedMin; // 0x2C
		[CustomObfuscation] // 0x00000001802087E0-0x0000000180208840
		[SerializeField] // 0x00000001802087E0-0x0000000180208840
		[Tooltip] // 0x00000001802087E0-0x0000000180208840
		private float _calibratedMax; // 0x30
		[CustomObfuscation] // 0x0000000180208C60-0x0000000180208CC0
		[SerializeField] // 0x0000000180208C60-0x0000000180208CC0
		[Tooltip] // 0x0000000180208C60-0x0000000180208CC0
		private bool _invert; // 0x34
		[CustomObfuscation] // 0x0000000180208F20-0x0000000180208F80
		[SerializeField] // 0x0000000180208F20-0x0000000180208F80
		[Tooltip] // 0x0000000180208F20-0x0000000180208F80
		private AxisSensitivityType _sensitivityType; // 0x38
		[CustomObfuscation] // 0x0000000180209180-0x0000000180209200
		[FieldRange] // 0x0000000180209180-0x0000000180209200
		[SerializeField] // 0x0000000180209180-0x0000000180209200
		[Tooltip] // 0x0000000180209180-0x0000000180209200
		private float _sensitivity; // 0x3C
		[CustomObfuscation] // 0x0000000180209510-0x0000000180209570
		[SerializeField] // 0x0000000180209510-0x0000000180209570
		[Tooltip] // 0x0000000180209510-0x0000000180209570
		private AnimationCurve _sensitivityCurve; // 0x40
		[CustomObfuscation] // 0x00000001802098E0-0x0000000180209940
		[SerializeField] // 0x00000001802098E0-0x0000000180209940
		[Tooltip] // 0x00000001802098E0-0x0000000180209940
		private bool _applyRangeCalibration; // 0x48
	
		// Properties
		public bool enabled { get; set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001803FA0B0-0x00000001803FA0C0
		public float deadZone { get; set; } // 0x000000018090BD10-0x000000018090BD20 0x000000018090BFB0-0x000000018090BFD0
		public float calibratedZero { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
		public float calibratedMin { get; set; } // 0x00000001807DDA30-0x00000001807DDA40 0x00000001807DDA40-0x00000001807DDA50
		public float calibratedMax { get; set; } // 0x00000001806757B0-0x00000001806757C0 0x000000018090BD20-0x000000018090BD30
		public bool invert { get; set; } // 0x0000000180406600-0x0000000180406610 0x0000000180830BC0-0x0000000180830C00
		public AxisSensitivityType sensitivityType { get; set; } // 0x000000018057D1C0-0x000000018057D1D0 0x000000018041B190-0x000000018041B1A0
		public float sensitivity { get; set; } // 0x0000000180379EF0-0x0000000180379F00 0x000000018090BFD0-0x000000018090BFE0
		public AnimationCurve sensitivityCurve { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public bool applyRangeCalibration { get; set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
		internal AlternateAxisCalibrationType calibrationMode { get; set; } // 0x0000000180387590-0x0000000180387930 0x000000018090BD30-0x000000018090BFB0
	
		// Constructors
		internal AxisCalibration(); // 0x000000018090BB50-0x000000018090BD10
		internal AxisCalibration(bool enabled, Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, float deadZone, float calibratedZero, float calibratedMin, float calibratedMax, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x000000018090B6D0-0x000000018090BA20
		internal AxisCalibration(AxisCalibrationData hardwareData); // 0x000000018090BA20-0x000000018090BB50
	
		// Methods
		internal void CopyFrom(AxisCalibration data, bool copyHardwareData); // 0x000000018090A030-0x000000018090A1D0
		public float GetCalibratedValue(float value); // 0x000000018090A890-0x000000018090A940
		internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion); // 0x000000018090A7B0-0x000000018090A890
		public float GetCalibratedValue(float value, AxisRange axisRange); // 0x000000018090A940-0x000000018090AB10
		internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion); // 0x000000018090AB10-0x000000018090AD30
		public AxisCalibrationData GetData(); // 0x000000018090AD30-0x000000018090AE00
		public void SetData(AxisCalibrationData data); // 0x000000018090B5B0-0x000000018090B6D0
		public void Reset(); // 0x000000018090B360-0x000000018090B5B0
		internal SerializedObject ExportData(); // 0x000000018090A540-0x000000018090A7B0
		internal void Import(SerializedObject serializedObject); // 0x000000018090AF50-0x000000018090B0C0
		private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData); // 0x000000018090B0C0-0x000000018090B360
		private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData); // 0x000000018090A1D0-0x000000018090A280
		private AxisCalibrationInfo GetHardwareDefault(); // 0x000000018090AE00-0x000000018090AF50
		internal static AxisCalibration CreateRelative(); // 0x000000018090A280-0x000000018090A540
	}
}
