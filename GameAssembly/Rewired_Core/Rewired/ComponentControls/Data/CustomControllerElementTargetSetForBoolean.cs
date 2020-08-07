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
	public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet // TypeDefIndex: 5965
	{
		// Fields
		private const int gAnvtLVbWGYxtOwlauGXwInwxxc = 1; // Metadata: 0x0076389D
		[CustomObfuscation] // 0x00000001801DF550-0x00000001801DF5B0
		[SerializeField] // 0x00000001801DF550-0x00000001801DF5B0
		[Tooltip] // 0x00000001801DF550-0x00000001801DF5B0
		private CustomControllerElementTarget _target; // 0x10
	
		// Properties
		public CustomControllerElementTarget target { get; } // 0x0000000180372440-0x0000000180372450 
		internal override int targetCount { get; } // 0x000000018058C710-0x000000018058C720 
		internal override CustomControllerElementTarget this[int index] { get => default; } // 0x0000000180913870-0x00000001809138E0 
	
		// Constructors
		internal CustomControllerElementTargetSetForBoolean(); // 0x00000001809136E0-0x00000001809137A0
		internal CustomControllerElementTargetSetForBoolean(CustomControllerElementTarget target); // 0x00000001809137A0-0x0000000180913870
	
		// Methods
		internal override void ClearElementCaches(); // 0x00000001809136B0-0x00000001809136E0
	}
}
