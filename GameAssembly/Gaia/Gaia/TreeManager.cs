/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class TreeManager // TypeDefIndex: 9240
	{
		// Fields
		private List<TreePrototype> m_terrainTrees; // 0x10
		private Quadtree<int> m_terrainTreeLocations; // 0x18
	
		// Constructors
		public TreeManager(); // 0x00000001816FA370-0x00000001816FA440
	
		// Methods
		public void LoadTreesFromTerrain(); // 0x00000001816F9BC0-0x00000001816FA370
		public void AddTree(Vector3 position, int prototypeIdx); // 0x00000001816F9A10-0x00000001816F9A90
		public int Count(Vector3 position, float range); // 0x00000001816F9A90-0x00000001816F9B80
		public int Count(); // 0x00000001816F9B80-0x00000001816F9BC0
	}
}
