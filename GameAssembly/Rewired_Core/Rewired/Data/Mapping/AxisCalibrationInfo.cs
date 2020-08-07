/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class AxisCalibrationInfo : IDeepCloneable // TypeDefIndex: 6413
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _applyRangeCalibration; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _invert; // 0x11
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _deadZone; // 0x14
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _zero; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _min; // 0x1C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _max; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AxisSensitivityType _sensitivityType; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _sensitivity; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _sensitivityCurve; // 0x30
	
		// Properties
		public bool applyRangeCalibration { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
		public bool invert { get; set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
		public float deadZone { get; set; } // 0x000000018094A320-0x000000018094A330 0x000000018094A330-0x000000018094A340
		public float zero { get; set; } // 0x000000018049DFC0-0x000000018049DFD0 0x0000000180956BE0-0x0000000180956BF0
		public float min { get; set; } // 0x0000000180918C20-0x0000000180918C30 0x0000000180918CF0-0x0000000180918D00
		public float max { get; set; } // 0x0000000180373AF0-0x0000000180373B00 0x0000000180373B00-0x0000000180373B10
		public AxisSensitivityType sensitivityType { get; set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180569610-0x0000000180569620
		public float sensitivity { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
		public AnimationCurve sensitivityCurve { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	
		// Constructors
		public AxisCalibrationInfo(); // 0x0000000180D783D0-0x0000000180D783E0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal AxisCalibrationInfo(float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x0000000180D78330-0x0000000180D783D0
	
		// Methods
		public object DeepClone(); // 0x0000000180D77FC0-0x0000000180D780F0
		internal static AxisCalibrationData LbiWXlbxPxDSZaTtREKkrsmdeyU(AxisCalibrationInfo param_0000d29e); // 0x0000000180D78180-0x0000000180D78330
		internal static AxisCalibrationInfo JjVWjhPGZPcNMdeifAPNqWqNdRQ(AxisCalibrationData param_0000d29f); // 0x0000000180D780F0-0x0000000180D78180
	}
}
