/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801DDE50-0x00000001801DDE80
	public class CustomControllerElementTarget // TypeDefIndex: 5962
	{
		// Fields
		[CustomObfuscation] // 0x00000001801DDF80-0x00000001801DDFE0
		[SerializeField] // 0x00000001801DDF80-0x00000001801DDFE0
		[Tooltip] // 0x00000001801DDF80-0x00000001801DDFE0
		private CustomControllerElementSelector _element; // 0x10
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private ValueRange _valueRange; // 0x18
		[CustomObfuscation] // 0x00000001801DE570-0x00000001801DE5D0
		[SerializeField] // 0x00000001801DE570-0x00000001801DE5D0
		[Tooltip] // 0x00000001801DE570-0x00000001801DE5D0
		private Pole _valueContribution; // 0x1C
		[CustomObfuscation] // 0x00000001801DE820-0x00000001801DE880
		[SerializeField] // 0x00000001801DE820-0x00000001801DE880
		[Tooltip] // 0x00000001801DE820-0x00000001801DE880
		private bool _invert; // 0x20
	
		// Properties
		public CustomControllerElementSelector element { get; } // 0x0000000180372440-0x0000000180372450 
		public Pole valueContribution { get; set; } // 0x00000001803FB770-0x00000001803FB780 0x000000018042D0F0-0x000000018042D100
		internal ValueRange valueRange { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
		public bool invert { get; set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001803FA0B0-0x00000001803FA0C0
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal enum ValueRange // TypeDefIndex: 5963
		{
			Full = 0,
			Positive = 1,
			Negative = 2
		}
	
		// Constructors
		internal CustomControllerElementTarget(); // 0x0000000180913FF0-0x0000000180914080
		internal CustomControllerElementTarget(CustomControllerElementSelector selector); // 0x0000000180914080-0x0000000180914140
	
		// Methods
		internal void ClearElementCaches(); // 0x0000000180913FD0-0x0000000180913FF0
	}
}
