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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000180143780-0x00000001801437E0
	public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet // TypeDefIndex: 5807
	{
		// Fields
		[CustomObfuscation] // 0x0000000180143DB0-0x0000000180143E10
		[SerializeField] // 0x0000000180143DB0-0x0000000180143E10
		[Tooltip] // 0x0000000180143DB0-0x0000000180143E10
		private bool _splitValue; // 0x10
		[CustomObfuscation] // 0x0000000180144080-0x00000001801440E0
		[SerializeField] // 0x0000000180144080-0x00000001801440E0
		[Tooltip] // 0x0000000180144080-0x00000001801440E0
		private CustomControllerElementTarget _target; // 0x18
		[CustomObfuscation] // 0x00000001801455C0-0x0000000180145620
		[SerializeField] // 0x00000001801455C0-0x0000000180145620
		[Tooltip] // 0x00000001801455C0-0x0000000180145620
		private CustomControllerElementTarget _positiveTarget; // 0x20
		[CustomObfuscation] // 0x00000001801457F0-0x0000000180145850
		[SerializeField] // 0x00000001801457F0-0x0000000180145850
		[Tooltip] // 0x00000001801457F0-0x0000000180145850
		private CustomControllerElementTarget _negativeTarget; // 0x28
	
		// Properties
		public bool splitValue { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
		public CustomControllerElementTarget target { get; } // 0x000000018038B150-0x000000018038B160 
		public CustomControllerElementTarget positiveTarget { get; } // 0x000000018036AC70-0x000000018036AC80 
		public CustomControllerElementTarget negativeTarget { get; } // 0x0000000180369B60-0x0000000180369B70 
		internal override int targetCount { get; } // 0x0000000181436600-0x0000000181436610 
		internal override CustomControllerElementTarget this[int index] { get => default; } // 0x0000000181436540-0x0000000181436600 
	
		// Constructors
		internal CustomControllerElementTargetSetForFloat(); // 0x0000000181435F70-0x0000000181436130
		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget target); // 0x0000000181436330-0x0000000181436540
		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget positiveTarget, CustomControllerElementTarget negativeTarget); // 0x0000000181436130-0x0000000181436330
	
		// Methods
		internal override void ClearElementCaches(); // 0x0000000181435F10-0x0000000181435F70
	}
}
