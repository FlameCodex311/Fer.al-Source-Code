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

public class HexGrid : MonoBehaviour // TypeDefIndex: 13140
{
	// Fields
	public int size; // 0x20
	public float gridScale; // 0x24
	private Dictionary<HexCoord, HexTile> tiles; // 0x28
	private static readonly float SQRT_3; // 0x00
	private static readonly Vector4 QR_XZ; // 0x04
	private static readonly Vector4 XZ_QR; // 0x14
	public static readonly HexCoord[] neighbors; // 0x28

	// Nested types
	public enum HexDirection // TypeDefIndex: 13141
	{
		NE = 0,
		N = 1,
		NW = 2,
		SW = 3,
		S = 4,
		SE = 5
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 13142
	{
		// Fields
		public KeyValuePair<HexCoord, HexTile> tileCoordPair; // 0x10
		public HexGrid <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <UpdateHexGridPositions>b__0(); // 0x0000000181065E40-0x0000000181065EF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Neighbors>d__15 : IEnumerable<HexTile>, IEnumerator<HexTile> // TypeDefIndex: 13143
	{
		// Fields
		private int <>1__state; // 0x10
		private HexTile <>2__current; // 0x18
		private int <>l__initialThreadId; // 0x20
		public HexGrid <>4__this; // 0x28
		private HexCoord inCoord; // 0x30
		public HexCoord <>3__inCoord; // 0x38
		private HexDirection[] <>7__wrap1; // 0x40
		private int <>7__wrap2; // 0x48

		// Properties
		HexTile IEnumerator<HexTile>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Neighbors>d__15(int <>1__state); // 0x000000018094DE20-0x000000018094DE50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181061E80-0x0000000181062050
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810620F0-0x0000000181064590
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator<HexTile> IEnumerable<HexTile>.GetEnumerator(); // 0x0000000181062050-0x00000001810620F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181062050-0x00000001810620F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Tiles>d__17 : IEnumerable<HexTile>, IEnumerator<HexTile> // TypeDefIndex: 13144
	{
		// Fields
		private int <>1__state; // 0x10
		private HexTile <>2__current; // 0x18
		private int <>l__initialThreadId; // 0x20
		public HexGrid <>4__this; // 0x28
		private Dictionary<HexCoord, HexTile> <>7__wrap1; // 0x30

		// Properties
		HexTile IEnumerator<HexTile>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Tiles>d__17(int <>1__state); // 0x000000018094DE20-0x000000018094DE50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000181065C90-0x0000000181065D40
		private bool MoveNext(); // 0x0000000181065A40-0x0000000181065BA0
		private void <>m__Finally1(); // 0x0000000181065D40-0x0000000181065D80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181065C40-0x0000000181065C90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator<HexTile> IEnumerable<HexTile>.GetEnumerator(); // 0x0000000181065BA0-0x0000000181065C40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181065BA0-0x0000000181065C40
	}

	// Constructors
	public HexGrid(); // 0x000000018105EE90-0x000000018105EEB0
	static HexGrid(); // 0x000000018105EC00-0x000000018105EE90

	// Methods
	public void CreateGrid(HexTile inTilePrefab); // 0x000000018105D7D0-0x000000018105DAD0
	public void CreateGridWithCoords(HexTile inTilePrefab, List<HexCoord> inCoords); // 0x000000018105D570-0x000000018105D7D0
	public HexTile GetTile(HexCoord inCoord); // 0x000000018105DC00-0x000000018105DC80
	public Vector3 HexCoordToWorldPos(HexCoord inCoord); // 0x000000018105DC80-0x000000018105DEC0
	public HexCoord WorldPosToHexCoord(Vector3 inWorldPos); // 0x000000018105E910-0x000000018105EC00
	private void UpdateHexGridPositions(bool animateTilePositions = false /* Metadata: 0x0078368D */); // 0x000000018105E3A0-0x000000018105E720
	private void OnValidate(); // 0x000000018105DFD0-0x000000018105E000
	[IteratorStateMachine] // 0x00000001800F8D00-0x00000001800F8D50
	public IEnumerable<HexTile> Neighbors(HexCoord inCoord); // 0x000000018105DF50-0x000000018105DFD0
	public IEnumerable<HexTile> Neighbors(HexTile inTile); // 0x000000018105DEC0-0x000000018105DF50
	[IteratorStateMachine] // 0x00000001800F9060-0x00000001800F90B0
	public IEnumerable<HexTile> Tiles(); // 0x000000018105E330-0x000000018105E3A0
	public HexTile GetNeighbor(HexTile inTile, HexDirection inDirection); // 0x000000018105DAD0-0x000000018105DB00
	public HexTile GetNeighbor(HexCoord inCoord, HexDirection inDirection); // 0x000000018105DB00-0x000000018105DC00
	public void UpdateTilesOnGrid(bool animateTilePositions = true /* Metadata: 0x0078368E */); // 0x000000018105E720-0x000000018105E910
	public void SetHighlightAtCoord(HexCoord inCoord, bool inHighlighted); // 0x000000018105E000-0x000000018105E100
	public void SetOutlineAtCoord(HexCoord inCoord, bool inOutlined); // 0x000000018105E100-0x000000018105E1F0
	public void SetPowerupAOEHighlight(HexCoord inCoord, bool inHighlighted); // 0x000000018105E1F0-0x000000018105E330
}

