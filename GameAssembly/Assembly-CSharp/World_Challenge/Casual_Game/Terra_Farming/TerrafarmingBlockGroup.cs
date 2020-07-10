/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerrafarmingBlockGroup : ManagedBehaviour // TypeDefIndex: 15641
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal TerraFarming game; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal List<TerrafarmingBlock> blocks; // 0x58
		internal int spawnIndex; // 0x60
		internal bool canDrop; // 0x64
		internal bool canClick; // 0x65
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		internal EBlockGroupType blockGroupType; // 0x68
		private bool _canToggle; // 0x6C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TerrafarmingGrid _grid; // 0x70
		private HashSet<string> _activeGrids; // 0x78
	
		// Nested types
		internal enum EBlockGroupType // TypeDefIndex: 15642
		{
			NONE = 0,
			COLLECT = 1,
			SINGLE = 2,
			DOUBLE_VERTICAL = 3,
			DOUBLE_SLANT_UP = 4,
			DOUBLE_SLANT_DOWN = 5,
			TRIPLE_VERTICAL = 6,
			TRIPLE_SLANT_UP = 7,
			TRIPLE_SLANT_DOWN = 8,
			TRIPLE_ARCH_TOP = 9,
			TRIPLE_ARCH_BOTTOM = 10,
			TRIPLE_ARCH_TR = 11,
			TRIPLE_ARCH_TL = 12,
			TRIPLE_ARCH_BR = 13,
			TRIPLE_ARCH_BL = 14,
			TRIPLE_LEFT = 15,
			TRIPLE_RIGHT = 16
		}
	
		private enum EDirections // TypeDefIndex: 15643
		{
			VERTICAL_UP = 0,
			VERTICAL_DOWN = 1,
			SLANT_UP = 2,
			SLANT_DOWN = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ToggleColor>d__17 : IEnumerator<object> // TypeDefIndex: 15644
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TerrafarmingBlockGroup <>4__this; // 0x20
			public int inBlockIndex; // 0x28
			public Vector3 inEndPos; // 0x2C
			private Vector3 <startPos>5__2; // 0x38
			private float <td>5__3; // 0x44
			private float <t>5__4; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ToggleColor>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181720CE0-0x0000000181721040
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181721040-0x0000000181721090
		}
	
		// Constructors
		public TerrafarmingBlockGroup(); // 0x0000000181712C70-0x0000000181712D20
	
		// Methods
		internal void CreateBlockGroup(); // 0x00000001817100C0-0x00000001817108F0
		internal void Colorize(int inCollectorColor = -1 /* Metadata: 0x00784D88 */); // 0x000000018170FBC0-0x00000001817100C0
		private void CreateSingle(); // 0x0000000181710E90-0x0000000181710FF0
		private void CreateDouble(); // 0x00000001817108F0-0x0000000181710E90
		private void CreateTriple(); // 0x0000000181710FF0-0x00000001817128D0
		private Vector3 GetPos(Vector3 inStart, EDirections inDir); // 0x00000001817128D0-0x0000000181712A40
		[IteratorStateMachine] // 0x000000018014D910-0x000000018014D960
		private IEnumerator ToggleColor(int inBlockIndex, Vector3 inEndPos); // 0x0000000181712AB0-0x0000000181712B40
		internal void ToggleColors(); // 0x0000000181712B40-0x0000000181712C70
		internal void CanDrop(bool inCanDrop); // 0x000000018170F450-0x000000018170FBC0
		private void OnMouseDown(); // 0x0000000181712A40-0x0000000181712A80
		private void OnMouseUp(); // 0x0000000181712A80-0x0000000181712AB0
	}
}
