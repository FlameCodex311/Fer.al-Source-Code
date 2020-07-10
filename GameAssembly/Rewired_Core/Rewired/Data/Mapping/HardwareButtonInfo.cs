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
	public class HardwareButtonInfo : IDeepCloneable // TypeDefIndex: 6253
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal bool _excludeFromPolling; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal bool _isPressureSensitive; // 0x11
	
		// Properties
		public bool excludeFromPolling { get; } // 0x0000000180375540-0x0000000180375550 
		public bool isPressureSensitive { get; } // 0x0000000180375550-0x0000000180375560 
	
		// Constructors
		public HardwareButtonInfo(); // 0x00000001805E9E60-0x00000001805E9E80
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal HardwareButtonInfo(bool excludeFromPolling, bool isPressureSensitive); // 0x00000001805E9E20-0x00000001805E9E60
	
		// Methods
		public object DeepClone(); // 0x00000001805E9DB0-0x00000001805E9E20
	}
}
