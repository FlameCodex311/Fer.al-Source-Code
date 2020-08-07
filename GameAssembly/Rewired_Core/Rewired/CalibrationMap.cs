/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801DDE50-0x00000001801DDE80
	public sealed class CalibrationMap // TypeDefIndex: 6642
	{
		// Fields
		private AxisCalibration[] BqSdtKydcIEkoWCjLJvCiEzwQMG; // 0x10
		private IList<AxisCalibration> rqqsgekTexjiWgufmqhWDSQKukG; // 0x18
		private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
		// Properties
		public IList<AxisCalibration> Axes { get; } // 0x0000000180372430-0x0000000180372440 
		public int axisCount { get; } // 0x00000001805EF530-0x00000001805EF540 
	
		// Constructors
		private CalibrationMap(); // 0x000000018090F700-0x000000018090F7B0
		internal CalibrationMap(AxisCalibrationData[] hardwareAxisCalibrationData); // 0x000000018090F7B0-0x000000018090FA90
		public CalibrationMap(AxisCalibration[] axisCalibrations); // 0x000000018090F660-0x000000018090F700
	
		// Methods
		public void Reset(); // 0x000000018090EF90-0x000000018090F100
		public AxisCalibration GetAxis(int index); // 0x000000018090E8E0-0x000000018090E9E0
		public float GetCalibratedValue(int axisIndex, float value); // 0x000000018090EA60-0x000000018090EC70
		public bool SetAxisData(int index, AxisCalibrationData data); // 0x000000018090F100-0x000000018090F3F0
		public AxisCalibrationData GetAxisData(int index); // 0x000000018090E780-0x000000018090E8E0
		internal void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone); // 0x000000018090E5E0-0x000000018090E780
		public string ToXmlString(); // 0x000000018090F510-0x000000018090F660
		public string ToJsonString(); // 0x000000018090F3F0-0x000000018090F510
		public bool ImportXmlString(string xmlString); // 0x000000018090EE30-0x000000018090EF90
		public bool ImportJsonString(string jsonString); // 0x000000018090EC70-0x000000018090EE30
		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x000000018090FA90-0x0000000180910130
		private void BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject param_0000da20); // 0x000000018090E1E0-0x000000018090E5E0
		internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType); // 0x000000018090E9E0-0x000000018090EA60
	}
}
