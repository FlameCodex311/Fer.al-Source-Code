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
	[CustomClassObfuscation] // 0x00000001801DF370-0x00000001801DF3D0
	public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet // TypeDefIndex: 5966
	{
		// Fields
		[CustomObfuscation] // 0x00000001801DFDD0-0x00000001801DFE30
		[SerializeField] // 0x00000001801DFDD0-0x00000001801DFE30
		[Tooltip] // 0x00000001801DFDD0-0x00000001801DFE30
		private bool _splitValue; // 0x10
		[CustomObfuscation] // 0x00000001801E00D0-0x00000001801E0130
		[SerializeField] // 0x00000001801E00D0-0x00000001801E0130
		[Tooltip] // 0x00000001801E00D0-0x00000001801E0130
		private CustomControllerElementTarget _target; // 0x18
		[CustomObfuscation] // 0x00000001801E03C0-0x00000001801E0420
		[SerializeField] // 0x00000001801E03C0-0x00000001801E0420
		[Tooltip] // 0x00000001801E03C0-0x00000001801E0420
		private CustomControllerElementTarget _positiveTarget; // 0x20
		[CustomObfuscation] // 0x00000001801E05B0-0x00000001801E0610
		[SerializeField] // 0x00000001801E05B0-0x00000001801E0610
		[Tooltip] // 0x00000001801E05B0-0x00000001801E0610
		private CustomControllerElementTarget _negativeTarget; // 0x28
	
		// Properties
		public bool splitValue { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
		public CustomControllerElementTarget target { get; } // 0x0000000180372430-0x0000000180372440 
		public CustomControllerElementTarget positiveTarget { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public CustomControllerElementTarget negativeTarget { get; } // 0x00000001803745B0-0x00000001803745C0 
		internal override int targetCount { get; } // 0x0000000180913FC0-0x0000000180913FD0 
		internal override CustomControllerElementTarget this[int index] { get => default; } // 0x0000000180913F00-0x0000000180913FC0 
	
		// Constructors
		internal CustomControllerElementTargetSetForFloat(); // 0x0000000180913940-0x0000000180913B00
		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget target); // 0x0000000180913D00-0x0000000180913F00
		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget positiveTarget, CustomControllerElementTarget negativeTarget); // 0x0000000180913B00-0x0000000180913D00
	
		// Methods
		internal override void ClearElementCaches(); // 0x00000001809138E0-0x0000000180913940
	}
}
