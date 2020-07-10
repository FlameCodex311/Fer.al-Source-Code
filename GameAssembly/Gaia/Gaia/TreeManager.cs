/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class TreeManager // TypeDefIndex: 9074
	{
		// Fields
		private List<TreePrototype> m_terrainTrees; // 0x10
		private Quadtree<int> m_terrainTreeLocations; // 0x18
	
		// Constructors
		public TreeManager(); // 0x0000000181C046E0-0x0000000181C047B0
	
		// Methods
		public void LoadTreesFromTerrain(); // 0x0000000181C03EE0-0x0000000181C046E0
		public void AddTree(Vector3 position, int prototypeIdx); // 0x0000000181C03D30-0x0000000181C03DB0
		public int Count(Vector3 position, float range); // 0x0000000181C03DB0-0x0000000181C03EA0
		public int Count(); // 0x0000000181C03EA0-0x0000000181C03EE0
	}
}
