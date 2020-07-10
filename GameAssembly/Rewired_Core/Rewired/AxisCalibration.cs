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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800D0530-0x00000001800D0560
	public sealed class AxisCalibration // TypeDefIndex: 6484
	{
		// Fields
		private AlternateAxisCalibrationType _calibrationMode; // 0x10
		private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations; // 0x18
		[CustomObfuscation] // 0x0000000180167ED0-0x0000000180167F30
		[SerializeField] // 0x0000000180167ED0-0x0000000180167F30
		[Tooltip] // 0x0000000180167ED0-0x0000000180167F30
		private bool _enabled; // 0x20
		[CustomObfuscation] // 0x0000000180167ED0-0x0000000180167F30
		[SerializeField] // 0x0000000180167ED0-0x0000000180167F30
		[Tooltip] // 0x0000000180167ED0-0x0000000180167F30
		private float _deadZone; // 0x24
		[CustomObfuscation] // 0x0000000180168590-0x00000001801685F0
		[SerializeField] // 0x0000000180168590-0x00000001801685F0
		[Tooltip] // 0x0000000180168590-0x00000001801685F0
		private float _calibratedZero; // 0x28
		[CustomObfuscation] // 0x00000001801687D0-0x0000000180168830
		[SerializeField] // 0x00000001801687D0-0x0000000180168830
		[Tooltip] // 0x00000001801687D0-0x0000000180168830
		private float _calibratedMin; // 0x2C
		[CustomObfuscation] // 0x0000000180168B80-0x0000000180168BE0
		[SerializeField] // 0x0000000180168B80-0x0000000180168BE0
		[Tooltip] // 0x0000000180168B80-0x0000000180168BE0
		private float _calibratedMax; // 0x30
		[CustomObfuscation] // 0x0000000180168DC0-0x0000000180168E20
		[SerializeField] // 0x0000000180168DC0-0x0000000180168E20
		[Tooltip] // 0x0000000180168DC0-0x0000000180168E20
		private bool _invert; // 0x34
		[CustomObfuscation] // 0x0000000180169140-0x00000001801691A0
		[SerializeField] // 0x0000000180169140-0x00000001801691A0
		[Tooltip] // 0x0000000180169140-0x00000001801691A0
		private AxisSensitivityType _sensitivityType; // 0x38
		[CustomObfuscation] // 0x000000018016A880-0x000000018016A900
		[FieldRange] // 0x000000018016A880-0x000000018016A900
		[SerializeField] // 0x000000018016A880-0x000000018016A900
		[Tooltip] // 0x000000018016A880-0x000000018016A900
		private float _sensitivity; // 0x3C
		[CustomObfuscation] // 0x000000018016AB20-0x000000018016AB80
		[SerializeField] // 0x000000018016AB20-0x000000018016AB80
		[Tooltip] // 0x000000018016AB20-0x000000018016AB80
		private AnimationCurve _sensitivityCurve; // 0x40
		[CustomObfuscation] // 0x000000018016ADC0-0x000000018016AE20
		[SerializeField] // 0x000000018016ADC0-0x000000018016AE20
		[Tooltip] // 0x000000018016ADC0-0x000000018016AE20
		private bool _applyRangeCalibration; // 0x48
	
		// Properties
		public bool enabled { get; set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
		public float deadZone { get; set; } // 0x00000001804935B0-0x00000001804935C0 0x000000018142E380-0x000000018142E3A0
		public float calibratedZero { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
		public float calibratedMin { get; set; } // 0x0000000180487D70-0x0000000180487D80 0x000000018139C3C0-0x000000018139C3D0
		public float calibratedMax { get; set; } // 0x0000000180485990-0x00000001804859A0 0x000000018142E0E0-0x000000018142E0F0
		public bool invert { get; set; } // 0x0000000180357070-0x0000000180357080 0x0000000180425360-0x00000001804253A0
		public AxisSensitivityType sensitivityType { get; set; } // 0x00000001804999D0-0x00000001804999E0 0x000000018036C620-0x000000018036C630
		public float sensitivity { get; set; } // 0x0000000180E426C0-0x0000000180E426D0 0x000000018142E3A0-0x000000018142E3B0
		public AnimationCurve sensitivityCurve { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public bool applyRangeCalibration { get; set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
		internal AlternateAxisCalibrationType calibrationMode { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018142E0F0-0x000000018142E380
	
		// Constructors
		internal AxisCalibration(); // 0x000000018142DF20-0x000000018142E0E0
		internal AxisCalibration(bool enabled, Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, float deadZone, float calibratedZero, float calibratedMin, float calibratedMax, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x000000018142DAA0-0x000000018142DDF0
		internal AxisCalibration(AxisCalibrationData hardwareData); // 0x000000018142DDF0-0x000000018142DF20
	
		// Methods
		internal void CopyFrom(AxisCalibration data, bool copyHardwareData); // 0x000000018142C3E0-0x000000018142C580
		public float GetCalibratedValue(float value); // 0x000000018142CC40-0x000000018142CCF0
		internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion); // 0x000000018142CB60-0x000000018142CC40
		public float GetCalibratedValue(float value, AxisRange axisRange); // 0x000000018142CCF0-0x000000018142CEC0
		internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion); // 0x000000018142CEC0-0x000000018142D0E0
		public AxisCalibrationData GetData(); // 0x000000018142D0E0-0x000000018142D1B0
		public void SetData(AxisCalibrationData data); // 0x000000018142D980-0x000000018142DAA0
		public void Reset(); // 0x000000018142D720-0x000000018142D980
		internal SerializedObject ExportData(); // 0x000000018142C8F0-0x000000018142CB60
		internal void Import(SerializedObject serializedObject); // 0x000000018142D300-0x000000018142D470
		private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData); // 0x000000018142D470-0x000000018142D720
		private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData); // 0x000000018142C580-0x000000018142C630
		private AxisCalibrationInfo GetHardwareDefault(); // 0x000000018142D1B0-0x000000018142D300
		internal static AxisCalibration CreateRelative(); // 0x000000018142C630-0x000000018142C8F0
	}
}
