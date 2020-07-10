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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C10A0-0x00000001800C10D0
	public sealed class CalibrationMap // TypeDefIndex: 6483
	{
		// Fields
		private AxisCalibration[] BqSdtKydcIEkoWCjLJvCiEzwQMG; // 0x10
		private IList<AxisCalibration> rqqsgekTexjiWgufmqhWDSQKukG; // 0x18
		private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
		// Properties
		public IList<AxisCalibration> Axes { get; } // 0x000000018038B150-0x000000018038B160 
		public int axisCount { get; } // 0x0000000180395190-0x00000001803951A0 
	
		// Constructors
		private CalibrationMap(); // 0x0000000181431C50-0x0000000181431D00
		internal CalibrationMap(AxisCalibrationData[] hardwareAxisCalibrationData); // 0x0000000181431D00-0x0000000181431FF0
		public CalibrationMap(AxisCalibration[] axisCalibrations); // 0x0000000181431BB0-0x0000000181431C50
	
		// Methods
		public void Reset(); // 0x00000001814314B0-0x0000000181431630
		public AxisCalibration GetAxis(int index); // 0x0000000181430DF0-0x0000000181430F00
		public float GetCalibratedValue(int axisIndex, float value); // 0x0000000181430F80-0x0000000181431190
		public bool SetAxisData(int index, AxisCalibrationData data); // 0x0000000181431630-0x0000000181431920
		public AxisCalibrationData GetAxisData(int index); // 0x0000000181430C90-0x0000000181430DF0
		internal void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone); // 0x0000000181430AE0-0x0000000181430C90
		public string ToXmlString(); // 0x0000000181431A50-0x0000000181431BB0
		public string ToJsonString(); // 0x0000000181431920-0x0000000181431A50
		public bool ImportXmlString(string xmlString); // 0x0000000181431350-0x00000001814314B0
		public bool ImportJsonString(string jsonString); // 0x0000000181431190-0x0000000181431350
		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH(); // 0x0000000181431FF0-0x00000001814326D0
		private void BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject param_0000d7b0); // 0x00000001814306D0-0x0000000181430AE0
		internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType); // 0x0000000181430F00-0x0000000181430F80
	}
}
