/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AttributeUsage] // 0x00000001801D0B50-0x00000001801D0B70
public class InspectorButtonAttribute : PropertyAttribute // TypeDefIndex: 10895
{
	// Fields
	public static float kDefaultButtonWidth; // 0x00
	public readonly string methodName; // 0x18
	public readonly string buttonLabel; // 0x20
	private float _buttonWidth; // 0x28
	private bool _isToggle; // 0x2C

	// Properties
	public float ButtonWidth { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
	public bool IsToggle { get; set; } // 0x0000000180626230-0x0000000180626240 0x0000000180626250-0x0000000180626260

	// Constructors
	public InspectorButtonAttribute(string inButtonLabel, string inMethodName); // 0x00000001806261A0-0x0000000180626230
	static InspectorButtonAttribute(); // 0x0000000180626160-0x00000001806261A0
}

