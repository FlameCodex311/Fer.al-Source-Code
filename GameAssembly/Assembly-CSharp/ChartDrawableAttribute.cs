/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChartDrawableAttribute : Attribute // TypeDefIndex: 13006
{
	// Fields
	private bool _labelWasSet; // 0x10
	private string _label; // 0x18
	public PropertyEditor.DefEntry targetDefEntry; // 0x20
	public List<PropertyEditor.DefEntry> targetDefEntries; // 0x28
	public PropertyEditor.DefEntryComponent targetDefEntryComponent; // 0x30
	public PropertyEditor.Project targetProject; // 0x38
	public PropertyEditor.Chart targetChart; // 0x40
	public object targetObject; // 0x48
	public FieldInfo targetField; // 0x50
	public FieldInfo targetListField; // 0x58
	public IList targetList; // 0x60
	public int targetIndex; // 0x68
	public MethodInfo targetMethod; // 0x70
	private bool _focus; // 0x78
	private string _visibleBoolName; // 0x80
	private bool _visibleWhenBoolEquals; // 0x88
	private float _width; // 0x8C
	private string _uniqueID; // 0x90

	// Properties
	public string Label { get; set; } // 0x0000000180372430-0x0000000180372440 0x00000001804A0220-0x00000001804A0230
	public Type FieldType { get; } // 0x00000001804A0010-0x00000001804A0100 
	public bool Focus { get; set; } // 0x0000000180453D00-0x0000000180453D10 0x0000000180453D10-0x0000000180453D20
	public string VisibleBoolName { get; set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
	public bool VisibleWhenBoolEquals { get; set; } // 0x00000001804A0200-0x00000001804A0210 0x0000000180434D60-0x0000000180434D70
	public float Width { get; set; } // 0x00000001804A0210-0x00000001804A0220 0x00000001804A0230-0x00000001804A0240
	public virtual bool CSVAllowExport { get; } // 0x0000000180380B60-0x0000000180380B70 
	public string UniqueID { get; } // 0x00000001804A0100-0x00000001804A0200 

	// Constructors
	public ChartDrawableAttribute(); // 0x000000018049FF90-0x00000001804A0010

	// Methods
	public void InternalDrawInInspector(); // 0x000000018049FDF0-0x000000018049FE30
	public virtual void DrawInInspector(); // 0x00000001803774A0-0x00000001803774B0
	public void InternalDrawInSelectorList(); // 0x000000018049FE30-0x000000018049FE50
	public virtual void DrawInSelectorList(); // 0x000000018049FDF0-0x000000018049FE30
	public virtual void Repair(); // 0x00000001803774A0-0x00000001803774B0
	public virtual bool OnExportAsCSV(); // 0x0000000180380950-0x0000000180380960
	public virtual void OnListAdd(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void QueueFocus(); // 0x000000018049FE50-0x000000018049FF90
}

