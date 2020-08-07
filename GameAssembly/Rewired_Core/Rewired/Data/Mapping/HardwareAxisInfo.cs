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
	public class HardwareAxisInfo : IDeepCloneable // TypeDefIndex: 6411
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal AxisCoordinateMode _dataFormat; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal bool _excludeFromPolling; // 0x14
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal SpecialAxisType _specialAxisType; // 0x18
	
		// Properties
		public AxisCoordinateMode dataFormat { get; } // 0x0000000180387590-0x0000000180387930 
		public bool excludeFromPolling { get; } // 0x00000001809A8910-0x00000001809A8920 
		public SpecialAxisType specialAxisType { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static HardwareAxisInfo Default { get; } // 0x0000000180D88E30-0x0000000180D88E80 
	
		// Constructors
		public HardwareAxisInfo(); // 0x0000000180D88E00-0x0000000180D88E30
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal HardwareAxisInfo(AxisCoordinateMode dataFormat, bool excludeFromPolling, SpecialAxisType specialAxisType); // 0x0000000180D88DB0-0x0000000180D88E00
	
		// Methods
		public object DeepClone(); // 0x0000000180D88D30-0x0000000180D88DB0
	}
}
