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
	public class HardwareButtonInfo : IDeepCloneable // TypeDefIndex: 6412
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal bool _excludeFromPolling; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal bool _isPressureSensitive; // 0x11
	
		// Properties
		public bool excludeFromPolling { get; } // 0x00000001803FD450-0x00000001803FD460 
		public bool isPressureSensitive { get; } // 0x0000000180400120-0x0000000180400130 
	
		// Constructors
		public HardwareButtonInfo(); // 0x0000000180D88F30-0x0000000180D88F50
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal HardwareButtonInfo(bool excludeFromPolling, bool isPressureSensitive); // 0x0000000180D88EF0-0x0000000180D88F30
	
		// Methods
		public object DeepClone(); // 0x0000000180D88E80-0x0000000180D88EF0
	}
}
