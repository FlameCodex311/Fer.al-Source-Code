/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AttributeUsage] // 0x00000001800C23C0-0x00000001800C23E0
public class InspectorButtonAttribute : PropertyAttribute // TypeDefIndex: 13229
{
	// Fields
	public static float kDefaultButtonWidth; // 0x00
	public readonly string methodName; // 0x18
	public readonly string buttonLabel; // 0x20
	private float _buttonWidth; // 0x28
	private bool _isToggle; // 0x2C

	// Properties
	public float ButtonWidth { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
	public bool IsToggle { get; set; } // 0x0000000180488600-0x0000000180488610 0x0000000180488610-0x0000000180488620

	// Constructors
	public InspectorButtonAttribute(string inButtonLabel, string inMethodName); // 0x0000000180F5CD50-0x0000000180F5CDE0
	static InspectorButtonAttribute(); // 0x0000000180F5CD10-0x0000000180F5CD50
}

