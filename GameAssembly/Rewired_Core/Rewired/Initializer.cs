/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[Browsable] // 0x00000001801E5C70-0x00000001801E5CD0
	[CustomClassObfuscation] // 0x00000001801E5C70-0x00000001801E5CD0
	[EditorBrowsable] // 0x00000001801E5C70-0x00000001801E5CD0
	public sealed class Initializer : UnityEngine.MonoBehaviour // TypeDefIndex: 6517
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject _inputManagerPrefab; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _destroySelf; // 0x20
	
		// Properties
		public GameObject inputManagerPrefab { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public bool destroySelf { get; set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001803FA0B0-0x00000001803FA0C0
	
		// Constructors
		public Initializer(); // 0x0000000180E63040-0x0000000180E63090
	
		// Methods
		private void Awake(); // 0x0000000180E62B70-0x0000000180E62B80
		public bool Initialize(); // 0x0000000180E62B80-0x0000000180E63040
	}
}
