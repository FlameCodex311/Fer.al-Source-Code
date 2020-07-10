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
	public class HardwareAxisInfo : IDeepCloneable // TypeDefIndex: 6252
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal AxisCoordinateMode _dataFormat; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal bool _excludeFromPolling; // 0x14
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal SpecialAxisType _specialAxisType; // 0x18
	
		// Properties
		public AxisCoordinateMode dataFormat { get; } // 0x000000018036CFF0-0x000000018036D000 
		public bool excludeFromPolling { get; } // 0x0000000180491CD0-0x0000000180491CE0 
		public SpecialAxisType specialAxisType { get; } // 0x0000000180367710-0x0000000180367720 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static HardwareAxisInfo Default { get; } // 0x00000001805E9D60-0x00000001805E9DB0 
	
		// Constructors
		public HardwareAxisInfo(); // 0x00000001805E9D30-0x00000001805E9D60
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal HardwareAxisInfo(AxisCoordinateMode dataFormat, bool excludeFromPolling, SpecialAxisType specialAxisType); // 0x00000001805E9CE0-0x00000001805E9D30
	
		// Methods
		public object DeepClone(); // 0x00000001805E9C60-0x00000001805E9CE0
	}
}
