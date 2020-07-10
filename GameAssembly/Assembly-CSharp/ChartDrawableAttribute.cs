/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ChartDrawableAttribute : Attribute // TypeDefIndex: 11483
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
	public string Label { get; set; } // 0x000000018038B150-0x000000018038B160 0x0000000180FF5DC0-0x0000000180FF5DD0
	public Type FieldType { get; } // 0x0000000181027660-0x0000000181027750 
	public bool Focus { get; set; } // 0x00000001804A2540-0x00000001804A2550 0x0000000180933270-0x0000000180933280
	public string VisibleBoolName { get; set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
	public bool VisibleWhenBoolEquals { get; set; } // 0x00000001804E88A0-0x00000001804E88B0 0x0000000180386220-0x0000000180386230
	public float Width { get; set; } // 0x0000000181027850-0x0000000181027860 0x0000000181027860-0x0000000181027870
	public virtual bool CSVAllowExport { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	public string UniqueID { get; } // 0x0000000181027750-0x0000000181027850 

	// Constructors
	public ChartDrawableAttribute(); // 0x00000001810275E0-0x0000000181027660

	// Methods
	public void InternalDrawInInspector(); // 0x0000000181027460-0x00000001810274A0
	public virtual void DrawInInspector(); // 0x00000001803581E0-0x00000001803581F0
	public void InternalDrawInSelectorList(); // 0x00000001805B15A0-0x00000001805B15C0
	public virtual void DrawInSelectorList(); // 0x0000000181027460-0x00000001810274A0
	public virtual void Repair(); // 0x00000001803581E0-0x00000001803581F0
	public virtual bool OnExportAsCSV(); // 0x00000001803C28F0-0x00000001803C2900
	public virtual void OnListAdd(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void QueueFocus(); // 0x00000001810274A0-0x00000001810275E0
}

