/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[Serializable]
	public sealed class InputBehavior // TypeDefIndex: 6694
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private float _joystickAxisSensitivity; // 0x20
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _digitalAxisSimulation; // 0x24
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _digitalAxisSnap; // 0x25
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _digitalAxisInstantReverse; // 0x26
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _digitalAxisGravity; // 0x28
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private float _digitalAxisSensitivity; // 0x2C
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private MouseXYAxisMode _mouseXYAxisMode; // 0x30
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private MouseOtherAxisMode _mouseOtherAxisMode; // 0x34
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private float _mouseXYAxisSensitivity; // 0x38
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc; // 0x3C
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _mouseOtherAxisSensitivity; // 0x40
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private float _customControllerAxisSensitivity; // 0x44
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private float _buttonDoublePressSpeed; // 0x48
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _buttonShortPressTime; // 0x4C
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _buttonShortPressExpiresIn; // 0x50
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _buttonLongPressTime; // 0x54
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _buttonLongPressExpiresIn; // 0x58
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _buttonDeadZone; // 0x5C
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _buttonDownBuffer; // 0x60
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private float _buttonRepeatRate; // 0x64
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private float _buttonRepeatDelay; // 0x68
	
		// Properties
		public int id { get; internal set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public string name { get; internal set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public float joystickAxisSensitivity { get; set; } // 0x0000000180373AF0-0x0000000180373B00 0x000000018099F310-0x000000018099F340
		public bool digitalAxisSimulation { get; set; } // 0x00000001804F2E90-0x00000001804F2EA0 0x00000001804F2EA0-0x00000001804F2EB0
		public bool digitalAxisSnap { get; set; } // 0x00000001804D2E30-0x00000001804D2E40 0x000000018099F300-0x000000018099F310
		public bool digitalAxisInstantReverse { get; set; } // 0x00000001804D2E20-0x00000001804D2E30 0x000000018099F2C0-0x000000018099F2D0
		public float digitalAxisGravity { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x000000018099F290-0x000000018099F2C0
		public float digitalAxisSensitivity { get; set; } // 0x00000001807DDA30-0x00000001807DDA40 0x000000018099F2D0-0x000000018099F300
		public MouseXYAxisMode mouseXYAxisMode { get; set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018041A3B0-0x000000018041A400
		public MouseOtherAxisMode mouseOtherAxisMode { get; set; } // 0x00000001804EF8F0-0x00000001804EF900 0x000000018041B180-0x000000018041B190
		public float mouseXYAxisSensitivity { get; set; } // 0x0000000180788790-0x00000001807887A0 0x000000018099F370-0x000000018099F3A0
		public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc { get; set; } // 0x000000018099EBE0-0x000000018099EBF0 0x000000018041B1A0-0x000000018041B1B0
		public float mouseOtherAxisSensitivity { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x000000018099F340-0x000000018099F370
		public float customControllerAxisSensitivity { get; set; } // 0x0000000180690330-0x0000000180690340 0x000000018099F260-0x000000018099F290
		public float buttonDoublePressSpeed { get; set; } // 0x00000001804D5810-0x00000001804D5820 0x000000018099F0D0-0x000000018099F100
		public float buttonShortPressTime { get; set; } // 0x0000000180379EA0-0x0000000180379EB0 0x000000018099F230-0x000000018099F260
		public float buttonShortPressExpiresIn { get; set; } // 0x0000000180791CE0-0x0000000180791CF0 0x000000018099F200-0x000000018099F230
		public float buttonLongPressTime { get; set; } // 0x0000000180791CD0-0x0000000180791CE0 0x000000018099F180-0x000000018099F1B0
		public float buttonLongPressExpiresIn { get; set; } // 0x000000018099EBC0-0x000000018099EBD0 0x000000018099F150-0x000000018099F180
		public float buttonDeadZone { get; set; } // 0x000000018099EBB0-0x000000018099EBC0 0x000000018099F0A0-0x000000018099F0D0
		public float buttonDownBuffer { get; set; } // 0x00000001804CD6D0-0x00000001804CD6E0 0x000000018099F100-0x000000018099F150
		public float buttonRepeatRate { get; set; } // 0x000000018099EBD0-0x000000018099EBE0 0x000000018099F1D0-0x000000018099F200
		public float buttonRepeatDelay { get; set; } // 0x00000001804C5F40-0x00000001804C5F50 0x000000018099F1B0-0x000000018099F1D0
	
		// Constructors
		public InputBehavior(); // 0x000000018099EB80-0x000000018099EBB0
		public InputBehavior(InputBehavior source); // 0x000000018099EA10-0x000000018099EB80
	
		// Methods
		public string ToXmlString(); // 0x000000018099E950-0x000000018099EA10
		public bool ImportXmlString(string xmlString); // 0x000000018099D990-0x000000018099DA70
		public string ToJsonString(); // 0x000000018099E890-0x000000018099E950
		public bool ImportJsonString(string jsonString); // 0x000000018099D8B0-0x000000018099D990
		public bool ImportData(InputBehavior inputBehavior); // 0x000000018099D6A0-0x000000018099D8B0
		public InputBehavior Clone(); // 0x000000018099D510-0x000000018099D6A0
		public void Reset(); // 0x000000018099E6B0-0x000000018099E890
		internal SerializedObject JijNtvxBfxSyvZqRuViZInoAdyr(); // 0x000000018099DA70-0x000000018099E490
		internal void oOJgtRfrJindxeXPtlOXKDmATym(SerializedObject param_0000de6c); // 0x000000018099EBF0-0x000000018099F0A0
		private static void NdcJYipIwyegYQfyTrsLRzhzdYx(InputBehavior param_0000de6d, InputBehavior param_0000de6e, bool param_0000de6f); // 0x000000018099E490-0x000000018099E6B0
	}
}
