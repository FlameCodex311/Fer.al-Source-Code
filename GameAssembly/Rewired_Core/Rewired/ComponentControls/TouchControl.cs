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
	[DisallowMultipleComponent] // 0x000000018014CB30-0x000000018014CB90
	[RequireComponent] // 0x000000018014CB30-0x000000018014CB90
	public abstract class TouchControl : CustomControllerControl // TypeDefIndex: 5818
	{
		// Fields
		private Canvas _canvas; // 0x28
		private RectTransform __rectTransform; // 0x30
	
		// Properties
		internal TouchController touchController { get; } // 0x000000018190CD40-0x000000018190CD90 
		internal Canvas canvas { get; } // 0x0000000180369B60-0x0000000180369B70 
		internal RectTransform canvasTransform { get; } // 0x000000018190CBE0-0x000000018190CC80 
		internal RectTransform rectTransform { get; } // 0x000000018190CCF0-0x000000018190CD40 
		internal override bool hasController { get; } // 0x000000018190CC80-0x000000018190CCF0 
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal TouchControl(); // 0x000000018190CBD0-0x000000018190CBE0
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnValidate(); // 0x000000018190CAD0-0x000000018190CBD0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnCanvasGroupChanged(); // 0x000000018190C640-0x000000018190C780
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnTransformParentChanged(); // 0x000000018190C9C0-0x000000018190CAD0
		internal override bool OnInitialize(); // 0x000000018190C780-0x000000018190C8A0
		internal override void OnSetProperty(); // 0x000000018190C8A0-0x000000018190C9C0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override IComponentController FindController(); // 0x000000018190C440-0x000000018190C4B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override Type GetRequiredControllerType(); // 0x000000018190C5E0-0x000000018190C640
		private new bool GEgOhDhFWzlyUDjyMHeIcciCspI(bool param_0000c6d1, bool param_0000c6d2); // 0x000000018190C4B0-0x000000018190C5E0
	}
}
