/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Life : ManagedBehaviour // TypeDefIndex: 11928
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TreeInfo[] treeInfos; // 0x50

	// Nested types
	[Serializable]
	public class ObjectInfo // TypeDefIndex: 11929
	{
		// Fields
		public GameObject prefab; // 0x10
		public Vector3 position; // 0x18
		public Vector3 rotation; // 0x24

		// Constructors
		public ObjectInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class TreeInfo // TypeDefIndex: 11930
	{
		// Fields
		public List<int> terrainTreeIndexes; // 0x10
		public ObjectInfo[] objectInfos; // 0x18

		// Constructors
		public TreeInfo(); // 0x0000000180C5AAA0-0x0000000180C5AB00
	}

	// Constructors
	public Life(); // 0x0000000180C57610-0x0000000180C57670

	// Methods
	public override void MStart(); // 0x0000000180C56F20-0x0000000180C56F40
	private void AttachToTrees(); // 0x0000000180C56D00-0x0000000180C56F20
	private void SpawnObjects(TreeInfo inTreeInfo, TreeInstance inTreeInstance); // 0x0000000180C56F40-0x0000000180C57610
}

