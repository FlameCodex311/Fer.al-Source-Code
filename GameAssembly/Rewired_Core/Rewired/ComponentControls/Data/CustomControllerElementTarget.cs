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
	[CustomClassObfuscation] // 0x00000001800C10A0-0x00000001800C10D0
	public class CustomControllerElementTarget // TypeDefIndex: 5803
	{
		// Fields
		[CustomObfuscation] // 0x00000001801410B0-0x0000000180141110
		[SerializeField] // 0x00000001801410B0-0x0000000180141110
		[Tooltip] // 0x00000001801410B0-0x0000000180141110
		private CustomControllerElementSelector _element; // 0x10
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private ValueRange _valueRange; // 0x18
		[CustomObfuscation] // 0x0000000180142850-0x00000001801428B0
		[SerializeField] // 0x0000000180142850-0x00000001801428B0
		[Tooltip] // 0x0000000180142850-0x00000001801428B0
		private Pole _valueContribution; // 0x1C
		[CustomObfuscation] // 0x0000000180142D20-0x0000000180142D80
		[SerializeField] // 0x0000000180142D20-0x0000000180142D80
		[Tooltip] // 0x0000000180142D20-0x0000000180142D80
		private bool _invert; // 0x20
	
		// Properties
		public CustomControllerElementSelector element { get; } // 0x000000018036AC80-0x000000018036AC90 
		public Pole valueContribution { get; set; } // 0x000000018037E420-0x000000018037E430 0x000000018037E600-0x000000018037E610
		internal ValueRange valueRange { get; set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
		public bool invert { get; set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
	
		// Nested types
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal enum ValueRange // TypeDefIndex: 5804
		{
			Full = 0,
			Positive = 1,
			Negative = 2
		}
	
		// Constructors
		internal CustomControllerElementTarget(); // 0x0000000181436630-0x00000001814366C0
		internal CustomControllerElementTarget(CustomControllerElementSelector selector); // 0x00000001814366C0-0x0000000181436780
	
		// Methods
		internal void ClearElementCaches(); // 0x0000000181436610-0x0000000181436630
	}
}
