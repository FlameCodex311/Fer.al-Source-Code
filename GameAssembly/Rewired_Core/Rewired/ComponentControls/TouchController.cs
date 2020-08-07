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

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001802101B0-0x0000000180210210
	[RequireComponent] // 0x00000001802101B0-0x0000000180210210
	public sealed class TouchController : CustomController // TypeDefIndex: 6013
	{
		// Fields
		[CustomObfuscation] // 0x0000000180210580-0x00000001802105E0
		[SerializeField] // 0x0000000180210580-0x00000001802105E0
		[Tooltip] // 0x0000000180210580-0x00000001802105E0
		private bool _disableMouseInputWhenEnabled; // 0x58
		[CustomObfuscation] // 0x0000000180210A40-0x0000000180210AA0
		[SerializeField] // 0x0000000180210A40-0x0000000180210AA0
		[Tooltip] // 0x0000000180210A40-0x0000000180210AA0
		private bool _useCustomController; // 0x59
	
		// Properties
		public bool disableMouseInputWhenEnabled { get; set; } // 0x0000000180379F00-0x0000000180379F10 0x00000001810B3010-0x00000001810B3040
		public bool useCustomController { get; set; } // 0x00000001805FC570-0x00000001805FC580 0x00000001810B3040-0x00000001810B3170
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private TouchController(); // 0x00000001810B3000-0x00000001810B3010
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnDisable(); // 0x00000001810B2CE0-0x00000001810B2DE0
		internal override bool OnInitialize(); // 0x00000001810B2DE0-0x00000001810B2F10
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override bool GetUseCustomController(); // 0x00000001805FC570-0x00000001805FC580
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void SetUseCustomController(bool value); // 0x00000001805FC590-0x00000001805FC5A0
		private void SetMouseState(bool state); // 0x00000001810B2F10-0x00000001810B3000
		private new void OnSetProperty(); // 0x00000001803774A0-0x00000001803774B0
		private new bool CheckIsRewiredReady(); // 0x00000001810B2BF0-0x00000001810B2CE0
	}
}
