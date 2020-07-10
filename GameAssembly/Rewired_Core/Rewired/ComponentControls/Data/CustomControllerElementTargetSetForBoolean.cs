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
	public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet // TypeDefIndex: 5806
	{
		// Fields
		private const int gAnvtLVbWGYxtOwlauGXwInwxxc = 1; // Metadata: 0x0072EC00
		[CustomObfuscation] // 0x0000000180143900-0x0000000180143960
		[SerializeField] // 0x0000000180143900-0x0000000180143960
		[Tooltip] // 0x0000000180143900-0x0000000180143960
		private CustomControllerElementTarget _target; // 0x10
	
		// Properties
		public CustomControllerElementTarget target { get; } // 0x000000018036AC80-0x000000018036AC90 
		internal override int targetCount { get; } // 0x000000018042E670-0x000000018042E680 
		internal override CustomControllerElementTarget this[int index] { get => default; } // 0x0000000181435EA0-0x0000000181435F10 
	
		// Constructors
		internal CustomControllerElementTargetSetForBoolean(); // 0x0000000181435D00-0x0000000181435DC0
		internal CustomControllerElementTargetSetForBoolean(CustomControllerElementTarget target); // 0x0000000181435DC0-0x0000000181435EA0
	
		// Methods
		internal override void ClearElementCaches(); // 0x0000000181435CD0-0x0000000181435D00
	}
}
