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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class AxisCalibrationInfo : IDeepCloneable // TypeDefIndex: 6254
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _applyRangeCalibration; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _invert; // 0x11
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _deadZone; // 0x14
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _zero; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _min; // 0x1C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _max; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AxisSensitivityType _sensitivityType; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _sensitivity; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _sensitivityCurve; // 0x30
	
		// Properties
		public bool applyRangeCalibration { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
		public bool invert { get; set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
		public float deadZone { get; set; } // 0x000000018048F530-0x000000018048F540 0x00000001805C1F50-0x00000001805C1F60
		public float zero { get; set; } // 0x00000001805D9080-0x00000001805D9090 0x00000001805D90C0-0x00000001805D90D0
		public float min { get; set; } // 0x00000001805D9070-0x00000001805D9080 0x00000001805D90A0-0x00000001805D90B0
		public float max { get; set; } // 0x0000000180487DA0-0x0000000180487DB0 0x00000001805D9090-0x00000001805D90A0
		public AxisSensitivityType sensitivityType { get; set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
		public float sensitivity { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
		public AnimationCurve sensitivityCurve { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	
		// Constructors
		public AxisCalibrationInfo(); // 0x00000001805D9060-0x00000001805D9070
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal AxisCalibrationInfo(float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x00000001805D8FC0-0x00000001805D9060
	
		// Methods
		public object DeepClone(); // 0x00000001805D8C50-0x00000001805D8D80
		internal static AxisCalibrationData LbiWXlbxPxDSZaTtREKkrsmdeyU(AxisCalibrationInfo param_0000d02e); // 0x00000001805D8E10-0x00000001805D8FC0
		internal static AxisCalibrationInfo JjVWjhPGZPcNMdeifAPNqWqNdRQ(AxisCalibrationData param_0000d02f); // 0x00000001805D8D80-0x00000001805D8E10
	}
}
