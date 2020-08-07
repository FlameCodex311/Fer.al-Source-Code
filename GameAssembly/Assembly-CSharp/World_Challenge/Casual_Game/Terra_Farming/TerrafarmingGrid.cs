/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerrafarmingGrid : MonoBehaviour // TypeDefIndex: 14800
	{
		// Fields
		[Header] // 0x0000000180214280-0x00000001802142B0
		public TerrafarmingBlock terrafarmingBlock; // 0x20
		public Color gridFaceInactive; // 0x28
		public Color gridFaceActive; // 0x38
		public Color blockEdges; // 0x48
		internal float blockZoffset_vertical; // 0x58
		internal float blockZoffset_slant; // 0x5C
		internal float blockXoffset; // 0x60
		internal TerrafarmingBlock block; // 0x68
		internal List<TerrafarmingBlock> allBlocks; // 0x70
	
		// Constructors
		public TerrafarmingGrid(); // 0x0000000180E775A0-0x0000000180E77600
	
		// Methods
		public void Start(); // 0x0000000180E77570-0x0000000180E775A0
		private void CreateGrid(); // 0x0000000180E76D00-0x0000000180E77570
	}
}
