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
	[DisallowMultipleComponent] // 0x00000001801EA690-0x00000001801EA6F0
	[RequireComponent] // 0x00000001801EA690-0x00000001801EA6F0
	public abstract class TouchControl : CustomControllerControl // TypeDefIndex: 5977
	{
		// Fields
		private Canvas _canvas; // 0x28
		private RectTransform __rectTransform; // 0x30
	
		// Properties
		internal TouchController touchController { get; } // 0x00000001810B2BA0-0x00000001810B2BF0 
		internal Canvas canvas { get; } // 0x00000001803745B0-0x00000001803745C0 
		internal RectTransform canvasTransform { get; } // 0x00000001810B2A40-0x00000001810B2AE0 
		internal RectTransform rectTransform { get; } // 0x00000001810B2B50-0x00000001810B2BA0 
		internal override bool hasController { get; } // 0x00000001810B2AE0-0x00000001810B2B50 
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal TouchControl(); // 0x00000001810B2A30-0x00000001810B2A40
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnValidate(); // 0x00000001810B2930-0x00000001810B2A30
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnCanvasGroupChanged(); // 0x00000001810B24A0-0x00000001810B25E0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnTransformParentChanged(); // 0x00000001810B2820-0x00000001810B2930
		internal override bool OnInitialize(); // 0x00000001810B25E0-0x00000001810B2700
		internal override void OnSetProperty(); // 0x00000001810B2700-0x00000001810B2820
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override IComponentController FindController(); // 0x00000001810B22A0-0x00000001810B2310
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override Type GetRequiredControllerType(); // 0x00000001810B2440-0x00000001810B24A0
		private new bool GEgOhDhFWzlyUDjyMHeIcciCspI(bool param_0000c941, bool param_0000c942); // 0x00000001810B2310-0x00000001810B2440
	}
}
