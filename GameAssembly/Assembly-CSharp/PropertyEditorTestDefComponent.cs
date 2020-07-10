/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x00000001800D9CE0-0x00000001800D9D10
public class PropertyEditorTestDefComponent : DefComponent // TypeDefIndex: 11583
{
	// Fields
	[ChartDef] // 0x00000001800DA020-0x00000001800DA090
	public string refTest; // 0x18
	[ChartDate] // 0x00000001800B5960-0x00000001800B5970
	public ChartDate chartDateTest; // 0x20
	[ChartList] // 0x00000001800DA450-0x00000001800DA470
	public List<ClassEntry> classArrayTest; // 0x28
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<ClassEntry2> classArrayTest2; // 0x30
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<ClassEntry3> classArrayTest3; // 0x38
	[ChartBundle] // 0x00000001800BF800-0x00000001800BF830
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	public List<ChartBundle> bundles; // 0x40
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<LootList> lootLists; // 0x48
	[ChartDef] // 0x00000001800DACE0-0x00000001800DAD60
	[ChartList] // 0x00000001800DACE0-0x00000001800DAD60
	public ChartDefList defList; // 0x50
	[ChartInt] // 0x00000001800BF800-0x00000001800BF830
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	public List<int> intTest; // 0x58
	[ChartDef] // 0x00000001800DB400-0x00000001800DB480
	[ChartList] // 0x00000001800DB400-0x00000001800DB480
	public List<string> refArrayTest; // 0x60
	[ChartDef] // 0x00000001800DB940-0x00000001800DB9C0
	[ChartList] // 0x00000001800DB940-0x00000001800DB9C0
	public List<string> refArrayTest2; // 0x68
	[ChartColor] // 0x00000001800BF800-0x00000001800BF830
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	public List<Color> colorArrayTest; // 0x70
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public ItemType enumTest; // 0x78
	[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
	public Vector3 vector3Test; // 0x7C
	[NonSerialized]
	[ChartButton] // 0x00000001800DC240-0x00000001800DC290
	public bool buttonTest; // 0x88

	// Nested types
	[Serializable]
	public class ClassEntry // TypeDefIndex: 11584
	{
		// Fields
		[ChartDef] // 0x00000001800DC4E0-0x00000001800DC550
		public string itemDefID; // 0x10
		[ChartInt] // 0x00000001800DC7F0-0x00000001800DC820
		public int count; // 0x18

		// Constructors
		public ClassEntry(); // 0x000000018139C450-0x000000018139C460
	}

	[Serializable]
	public class ClassEntry2 // TypeDefIndex: 11585
	{
		// Fields
		[ChartDef] // 0x00000001800DC970-0x00000001800DC9E0
		public string itemDefID; // 0x10
		[ChartDef] // 0x00000001800DCDD0-0x00000001800DCE40
		public string item2DefID; // 0x18
		[ChartInt] // 0x00000001800DC7F0-0x00000001800DC820
		public int count; // 0x20

		// Constructors
		public ClassEntry2(); // 0x0000000180A6D730-0x0000000180A6D740
	}

	[Serializable]
	public class ClassEntry3 // TypeDefIndex: 11586
	{
		// Fields
		[ChartDef] // 0x00000001800DD3A0-0x00000001800DD430
		public string itemDefID; // 0x10
		[ChartDef] // 0x00000001800DD990-0x00000001800DDA20
		public string item2DefID; // 0x18
		[ChartFloat] // 0x00000001800BF800-0x00000001800BF830
		[ChartList] // 0x00000001800BF800-0x00000001800BF830
		public List<float> floatArrayTest; // 0x20

		// Constructors
		public ClassEntry3(); // 0x000000018139C3F0-0x000000018139C450
	}

	[Serializable]
	public class LootList // TypeDefIndex: 11587
	{
		// Fields
		[ChartDef] // 0x00000001800DE080-0x00000001800DE100
		[ChartList] // 0x00000001800DE080-0x00000001800DE100
		public ChartDefList list; // 0x10

		// Constructors
		public LootList(); // 0x00000001813A5940-0x00000001813A59A0
	}

	// Constructors
	public PropertyEditorTestDefComponent(); // 0x00000001813A7010-0x00000001813A7220

	// Methods
	public void ButtonTestMethod(PropertyEditor.DefEntry inDefEntry); // 0x00000001803581E0-0x00000001803581F0
	protected override void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
}

