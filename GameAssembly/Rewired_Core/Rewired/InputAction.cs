/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Serializable]
	public sealed class InputAction // TypeDefIndex: 6534
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int _id; // 0x10
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string _name; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private InputActionType _type; // 0x20
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _descriptiveName; // 0x28
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private string _positiveDescriptiveName; // 0x30
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private string _negativeDescriptiveName; // 0x38
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int _behaviorId; // 0x40
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private bool _userAssignable; // 0x44
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private int _categoryId; // 0x48
		[NonSerialized]
		private string BzSHOSBxHTsRNRpWFylLxwSXAwr; // 0x50
		[NonSerialized]
		private string VdDfVbcczPozqcIQWsfZfUSQZbQ; // 0x58
	
		// Properties
		public int id { get; internal set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public string name { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public InputActionType type { get; internal set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
		public string descriptiveName { get; internal set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public string positiveDescriptiveName { get; internal set; } // 0x000000018061F570-0x000000018061F620 0x000000018061F680-0x000000018061F6D0
		public string negativeDescriptiveName { get; internal set; } // 0x000000018061F4D0-0x000000018061F570 0x000000018061F630-0x000000018061F680
		public int behaviorId { get; internal set; } // 0x000000018047AB20-0x000000018047AB30 0x00000001804D0BC0-0x00000001804D0BD0
		public int categoryId { get; internal set; } // 0x0000000180384C10-0x0000000180384C20 0x00000001804D0BE0-0x00000001804D0BF0
		public bool userAssignable { get; internal set; } // 0x000000018061F620-0x000000018061F630 0x000000018061F6D0-0x000000018061F6E0
	
		// Constructors
		public InputAction(); // 0x000000018036B6C0-0x000000018036B6D0
		public InputAction(InputAction source); // 0x000000018061F460-0x000000018061F4D0
	
		// Methods
		public InputAction Clone(); // 0x000000018061F3C0-0x000000018061F460
	}
}
