/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x000000018027AFE0-0x000000018027B010
public class PropertyEditorTestDefComponent : DefComponent // TypeDefIndex: 13107
{
	// Fields
	[ChartDef] // 0x000000018027B040-0x000000018027B0B0
	public string refTest; // 0x18
	[ChartDate] // 0x00000001801DE450-0x00000001801DE460
	public ChartDate chartDateTest; // 0x20
	[ChartList] // 0x0000000180229BA0-0x0000000180229BC0
	public List<ClassEntry> classArrayTest; // 0x28
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<ClassEntry2> classArrayTest2; // 0x30
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<ClassEntry3> classArrayTest3; // 0x38
	[ChartBundle] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	public List<ChartBundle> bundles; // 0x40
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<LootList> lootLists; // 0x48
	[ChartDef] // 0x000000018027B9A0-0x000000018027BA20
	[ChartList] // 0x000000018027B9A0-0x000000018027BA20
	public ChartDefList defList; // 0x50
	[ChartInt] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	public List<int> intTest; // 0x58
	[ChartDef] // 0x000000018027BDB0-0x000000018027BE30
	[ChartList] // 0x000000018027BDB0-0x000000018027BE30
	public List<string> refArrayTest; // 0x60
	[ChartDef] // 0x000000018027C260-0x000000018027C2E0
	[ChartList] // 0x000000018027C260-0x000000018027C2E0
	public List<string> refArrayTest2; // 0x68
	[ChartColor] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	public List<Color> colorArrayTest; // 0x70
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public ItemType enumTest; // 0x78
	[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
	public Vector3 vector3Test; // 0x7C
	[NonSerialized]
	[ChartButton] // 0x000000018027CBA0-0x000000018027CBF0
	public bool buttonTest; // 0x88

	// Nested types
	[Serializable]
	public class ClassEntry // TypeDefIndex: 13108
	{
		// Fields
		[ChartDef] // 0x000000018027CD50-0x000000018027CDC0
		public string itemDefID; // 0x10
		[ChartInt] // 0x000000018027CF50-0x000000018027CF80
		public int count; // 0x18

		// Constructors
		public ClassEntry(); // 0x00000001804A3C00-0x00000001804A3C10
	}

	[Serializable]
	public class ClassEntry2 // TypeDefIndex: 13109
	{
		// Fields
		[ChartDef] // 0x000000018027D0C0-0x000000018027D130
		public string itemDefID; // 0x10
		[ChartDef] // 0x000000018027D4B0-0x000000018027D520
		public string item2DefID; // 0x18
		[ChartInt] // 0x000000018027CF50-0x000000018027CF80
		public int count; // 0x20

		// Constructors
		public ClassEntry2(); // 0x0000000180D941B0-0x0000000180D941C0
	}

	[Serializable]
	public class ClassEntry3 // TypeDefIndex: 13110
	{
		// Fields
		[ChartDef] // 0x000000018027D9C0-0x000000018027DA50
		public string itemDefID; // 0x10
		[ChartDef] // 0x000000018027DD70-0x000000018027DE00
		public string item2DefID; // 0x18
		[ChartFloat] // 0x0000000180203CA0-0x0000000180203CD0
		[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
		public List<float> floatArrayTest; // 0x20

		// Constructors
		public ClassEntry3(); // 0x0000000180D941C0-0x0000000180D94220
	}

	[Serializable]
	public class LootList // TypeDefIndex: 13111
	{
		// Fields
		[ChartDef] // 0x000000018027F5F0-0x000000018027F670
		[ChartList] // 0x000000018027F5F0-0x000000018027F670
		public ChartDefList list; // 0x10

		// Constructors
		public LootList(); // 0x0000000180D9CEA0-0x0000000180D9CF00
	}

	// Constructors
	public PropertyEditorTestDefComponent(); // 0x0000000180D9E7D0-0x0000000180D9E980

	// Methods
	public void ButtonTestMethod(PropertyEditor.DefEntry inDefEntry); // 0x00000001803774A0-0x00000001803774B0
	protected override void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
}

