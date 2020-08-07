/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TemplateDrawableAttribute : Attribute // TypeDefIndex: 13002
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
	public string Label { get; set; } // 0x0000000180372430-0x0000000180372440 0x00000001804A0220-0x00000001804A0230
	public string VisibleBoolName { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
	public bool VisibleWhenBoolEquals { get; set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
	public float Width { get; set; } // 0x0000000180379EA0-0x0000000180379EB0 0x00000001805B0A90-0x00000001805B0AA0

	// Constructors
	public TemplateDrawableAttribute(); // 0x0000000180959E80-0x0000000180959F00

	// Methods
	public void InternalDrawInInspector(); // 0x0000000180959E60-0x0000000180959E80
	public virtual void DrawInInspector(); // 0x00000001803774A0-0x00000001803774B0
	public void InternalDrawInSelectorList(); // 0x000000018049FE30-0x000000018049FE50
	public virtual void DrawInSelectorList(); // 0x0000000180959E60-0x0000000180959E80
}

