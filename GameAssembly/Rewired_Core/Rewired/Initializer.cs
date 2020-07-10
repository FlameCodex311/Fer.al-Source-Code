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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[Browsable] // 0x00000001801499F0-0x0000000180149A50
	[CustomClassObfuscation] // 0x00000001801499F0-0x0000000180149A50
	[EditorBrowsable] // 0x00000001801499F0-0x0000000180149A50
	public sealed class Initializer : UnityEngine.MonoBehaviour // TypeDefIndex: 6358
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject _inputManagerPrefab; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _destroySelf; // 0x20
	
		// Properties
		public GameObject inputManagerPrefab { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public bool destroySelf { get; set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
	
		// Constructors
		public Initializer(); // 0x000000018061F370-0x000000018061F3C0
	
		// Methods
		private void Awake(); // 0x000000018061EE90-0x000000018061EEA0
		public bool Initialize(); // 0x000000018061EEA0-0x000000018061F370
	}
}
