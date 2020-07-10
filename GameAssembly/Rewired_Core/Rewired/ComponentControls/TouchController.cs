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

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x0000000180170410-0x0000000180170470
	[RequireComponent] // 0x0000000180170410-0x0000000180170470
	public sealed class TouchController : CustomController // TypeDefIndex: 5854
	{
		// Fields
		[CustomObfuscation] // 0x0000000180170830-0x0000000180170890
		[SerializeField] // 0x0000000180170830-0x0000000180170890
		[Tooltip] // 0x0000000180170830-0x0000000180170890
		private bool _disableMouseInputWhenEnabled; // 0x58
		[CustomObfuscation] // 0x0000000180170EA0-0x0000000180170F00
		[SerializeField] // 0x0000000180170EA0-0x0000000180170F00
		[Tooltip] // 0x0000000180170EA0-0x0000000180170F00
		private bool _useCustomController; // 0x59
	
		// Properties
		public bool disableMouseInputWhenEnabled { get; set; } // 0x0000000180369BC0-0x0000000180369BD0 0x000000018190D1C0-0x000000018190D1F0
		public bool useCustomController { get; set; } // 0x00000001803A2770-0x00000001803A2780 0x000000018190D1F0-0x000000018190D320
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private TouchController(); // 0x000000018190D1B0-0x000000018190D1C0
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnDisable(); // 0x000000018190CE80-0x000000018190CF80
		internal override bool OnInitialize(); // 0x000000018190CF80-0x000000018190D0B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override bool GetUseCustomController(); // 0x00000001803A2770-0x00000001803A2780
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void SetUseCustomController(bool value); // 0x00000001803A27B0-0x00000001803A27C0
		private void SetMouseState(bool state); // 0x000000018190D0B0-0x000000018190D1B0
		private new void OnSetProperty(); // 0x00000001803581E0-0x00000001803581F0
		private new bool CheckIsRewiredReady(); // 0x000000018190CD90-0x000000018190CE80
	}
}
