/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TemplateDrawableAttribute : Attribute // TypeDefIndex: 11479
{
	// Fields
	private bool _labelWasSet; // 0x10
	private string _label; // 0x18
	public List<PropertyEditor.DefEntry> targetDefEntries; // 0x20
	public PropertyEditor.Project targetProject; // 0x28
	public PropertyEditor.Chart targetChart; // 0x30
	public MethodInfo targetMethod; // 0x38
	private string _visibleBoolName; // 0x40
	private bool _visibleWhenBoolEquals; // 0x48
	private float _width; // 0x4C

	// Properties
	public string Label { get; set; } // 0x000000018038B150-0x000000018038B160 0x0000000180FF5DC0-0x0000000180FF5DD0
	public string VisibleBoolName { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
	public bool VisibleWhenBoolEquals { get; set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
	public float Width { get; set; } // 0x0000000180487D30-0x0000000180487D40 0x0000000180DD2D50-0x0000000180DD2D60

	// Constructors
	public TemplateDrawableAttribute(); // 0x0000000181209B70-0x0000000181209BF0

	// Methods
	public void InternalDrawInInspector(); // 0x00000001805F64D0-0x00000001805F64F0
	public virtual void DrawInInspector(); // 0x00000001803581E0-0x00000001803581F0
	public void InternalDrawInSelectorList(); // 0x00000001805B15A0-0x00000001805B15C0
	public virtual void DrawInSelectorList(); // 0x00000001805F64D0-0x00000001805F64F0
}

