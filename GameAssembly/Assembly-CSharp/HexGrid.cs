/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class HexGrid : MonoBehaviour // TypeDefIndex: 10805
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
	public enum HexDirection // TypeDefIndex: 10806
	{
		NE = 0,
		N = 1,
		NW = 2,
		SW = 3,
		S = 4,
		SE = 5
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 10807
	{
		// Fields
		public KeyValuePair<HexCoord, HexTile> tileCoordPair; // 0x10
		public HexGrid <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <UpdateHexGridPositions>b__0(); // 0x0000000180630620-0x00000001806306D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Neighbors>d__15 : IEnumerable<HexTile>, IEnumerator<HexTile> // TypeDefIndex: 10808
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
		HexTile IEnumerator<HexTile>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Neighbors>d__15(int <>1__state); // 0x00000001806301B0-0x00000001806301E0

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018062FEF0-0x00000001806300C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180630160-0x00000001806301B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator<HexTile> IEnumerable<HexTile>.GetEnumerator(); // 0x00000001806300C0-0x0000000180630160
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806300C0-0x0000000180630160
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Tiles>d__17 : IEnumerable<HexTile>, IEnumerator<HexTile> // TypeDefIndex: 10809
	{
		// Fields
		private int <>1__state; // 0x10
		private HexTile <>2__current; // 0x18
		private int <>l__initialThreadId; // 0x20
		public HexGrid <>4__this; // 0x28
		private Dictionary<HexCoord, HexTile> <>7__wrap1; // 0x30

		// Properties
		HexTile IEnumerator<HexTile>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Tiles>d__17(int <>1__state); // 0x00000001806301B0-0x00000001806301E0

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180630430-0x00000001806304D0
		private bool MoveNext(); // 0x00000001806301E0-0x0000000180630340
		private void <>m__Finally1(); // 0x00000001806304D0-0x0000000180630510
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806303E0-0x0000000180630430
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator<HexTile> IEnumerable<HexTile>.GetEnumerator(); // 0x0000000180630340-0x00000001806303E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180630340-0x00000001806303E0
	}

	// Constructors
	public HexGrid(); // 0x000000018061CED0-0x000000018061CEF0
	static HexGrid(); // 0x000000018061CC50-0x000000018061CED0

	// Methods
	public void CreateGrid(HexTile inTilePrefab); // 0x000000018061B860-0x000000018061BB50
	public void CreateGridWithCoords(HexTile inTilePrefab, List<HexCoord> inCoords); // 0x000000018061B610-0x000000018061B860
	public HexTile GetTile(HexCoord inCoord); // 0x000000018061BC60-0x000000018061BCE0
	public Vector3 HexCoordToWorldPos(HexCoord inCoord); // 0x000000018061BCE0-0x000000018061BF20
	public HexCoord WorldPosToHexCoord(Vector3 inWorldPos); // 0x000000018061C960-0x000000018061CC50
	private void UpdateHexGridPositions(bool animateTilePositions = false /* Metadata: 0x0077C148 */); // 0x000000018061C400-0x000000018061C770
	private void OnValidate(); // 0x000000018061C030-0x000000018061C060
	[IteratorStateMachine] // 0x0000000180295310-0x0000000180295360
	public IEnumerable<HexTile> Neighbors(HexCoord inCoord); // 0x000000018061BFB0-0x000000018061C030
	public IEnumerable<HexTile> Neighbors(HexTile inTile); // 0x000000018061BF20-0x000000018061BFB0
	[IteratorStateMachine] // 0x0000000180295480-0x00000001802954D0
	public IEnumerable<HexTile> Tiles(); // 0x000000018061C390-0x000000018061C400
	public HexTile GetNeighbor(HexTile inTile, HexDirection inDirection); // 0x000000018061BB50-0x000000018061BB70
	public HexTile GetNeighbor(HexCoord inCoord, HexDirection inDirection); // 0x000000018061BB70-0x000000018061BC60
	public void UpdateTilesOnGrid(bool animateTilePositions = true /* Metadata: 0x0077C149 */); // 0x000000018061C770-0x000000018061C960
	public void SetHighlightAtCoord(HexCoord inCoord, bool inHighlighted); // 0x000000018061C060-0x000000018061C160
	public void SetOutlineAtCoord(HexCoord inCoord, bool inOutlined); // 0x000000018061C160-0x000000018061C250
	public void SetPowerupAOEHighlight(HexCoord inCoord, bool inHighlighted); // 0x000000018061C250-0x000000018061C390
}

