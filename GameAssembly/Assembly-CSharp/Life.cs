/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Life : ManagedBehaviour // TypeDefIndex: 10451
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TreeInfo[] treeInfos; // 0x50

	// Nested types
	[Serializable]
	public class ObjectInfo // TypeDefIndex: 10452
	{
		// Fields
		public GameObject prefab; // 0x10
		public Vector3 position; // 0x18
		public Vector3 rotation; // 0x24

		// Constructors
		public ObjectInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class TreeInfo // TypeDefIndex: 10453
	{
		// Fields
		public List<int> terrainTreeIndexes; // 0x10
		public ObjectInfo[] objectInfos; // 0x18

		// Constructors
		public TreeInfo(); // 0x00000001812D46B0-0x00000001812D4E90
	}

	// Constructors
	public Life(); // 0x00000001812D18D0-0x00000001812D1930

	// Methods
	public override void MStart(); // 0x00000001812D11B0-0x00000001812D11D0
	private void AttachToTrees(); // 0x00000001812D0F80-0x00000001812D11B0
	private void SpawnObjects(TreeInfo inTreeInfo, TreeInstance inTreeInstance); // 0x00000001812D11D0-0x00000001812D18D0
}

