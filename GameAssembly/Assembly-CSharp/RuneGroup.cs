/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RuneGroup : MonoBehaviour // TypeDefIndex: 13153
{
	// Fields
	public HexTile tilePrefab; // 0x20
	public HexGrid localGrid; // 0x28
	public BoxCollider boundingBox; // 0x30
	public float boundingBoxPadding; // 0x38
	public float rotateSpeed; // 0x3C
	public float dropDuration; // 0x40
	[Header] // 0x00000001800FD010-0x00000001800FD040
	public GameObject fxPrefabRunePlacedFlame; // 0x48
	public GameObject fxPrefabRunePlacedFlora; // 0x50
	public GameObject fxPrefabRunePlacedMiasma; // 0x58
	private bool _isMoving; // 0x60
	private Tweener _moveTween; // 0x68
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RuneGroupType <GroupType>k__BackingField; // 0x70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RunesGameBoard <GameBoard>k__BackingField; // 0x78
	private int _tileDropCounter; // 0x80
	private List<HexCoord> _lastDropCoords; // 0x88

	// Properties
	public RuneGroupType GroupType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803DAD00-0x00000001803DAD10 0x00000001803DAEA0-0x00000001803DAEB0
	public bool IsBombPowerUp { get; } // 0x0000000180FD32B0-0x0000000180FD3370 
	private RunesGameBoard GameBoard { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 13154
	{
		// Fields
		public HexTile inDropOnTile; // 0x10
		public HexTile inTile; // 0x18
		public RuneGroup <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DropStandardRune>b__0(); // 0x0000000180FE3FE0-0x0000000180FE41F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 13155
	{
		// Fields
		public HexTile inDropOnTile; // 0x10
		public HexTile inTile; // 0x18
		public RuneGroup <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass34_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DropPowerUpRune>b__0(); // 0x0000000180FE41F0-0x0000000180FE4270
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForDrop>d__35 : IEnumerator<object> // TypeDefIndex: 13156
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RuneGroup <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForDrop>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE4A30-0x0000000180FE4BB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE4BB0-0x0000000180FE4C00
	}

	// Constructors
	public RuneGroup(); // 0x0000000180FD3230-0x0000000180FD32B0

	// Methods
	public void CreateGroup(RuneGroupType inGroupType, RunesGameBoard inGameBoard); // 0x0000000180FCF750-0x0000000180FD01F0
	public void SetRuneTypes(List<RuneType> inTypes, bool doShuffle = true /* Metadata: 0x0078370F */); // 0x0000000180FD2980-0x0000000180FD2BA0
	[DeMethodButton] // 0x00000001800FD8B0-0x00000001800FD910
	public void RotateTiles(); // 0x0000000180FD0C10-0x0000000180FD2980
	private void UpdateBoundingBox(); // 0x0000000180FD2BB0-0x0000000180FD31D0
	private void OnMouseDown(); // 0x0000000180FD0950-0x0000000180FD0A10
	private void OnMouseUp(); // 0x0000000180FD0A10-0x0000000180FD0A90
	public bool CanDrop(HexGrid inDropOnGrid, List<HexCoord> outDropCoords = null); // 0x0000000180FCF550-0x0000000180FCF750
	public bool CanDropForTutorial(HexGrid inDropOnGrid, List<HexCoord> tutorialCoords); // 0x0000000180FCF2B0-0x0000000180FCF550
	public bool CanDropAtCoord(HexGrid inDropOnGrid, HexCoord inDropCoord, List<HexCoord> outDropCoords = null); // 0x0000000180FCEF40-0x0000000180FCF2B0
	public void DropOnGrid(HexGrid inDropGrid); // 0x0000000180FD01F0-0x0000000180FD04F0
	private void DropStandardRune(HexTile inTile, HexTile inDropOnTile, float inDelay = 0f /* Metadata: 0x00783710 */); // 0x0000000180FD06B0-0x0000000180FD0870
	private void DropPowerUpRune(HexTile inTile, HexTile inDropOnTile, float inDelay = 0f /* Metadata: 0x00783714 */); // 0x0000000180FD04F0-0x0000000180FD06B0
	[IteratorStateMachine] // 0x00000001800FDC70-0x00000001800FDCC0
	private IEnumerator WaitForDrop(); // 0x0000000180FD31D0-0x0000000180FD3230
	private void PlayRuneDropFx(HexTile inTile); // 0x0000000180FD0A90-0x0000000180FD0C10
	public void MovePieceTo(Vector3 inPosition, float inDuration, Ease inEase = Ease.Linear /* Metadata: 0x00783718 */); // 0x0000000180FD0870-0x0000000180FD0950
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <WaitForDrop>b__35_0(); // 0x0000000180FD2BA0-0x0000000180FD2BB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MovePieceTo>b__37_0(); // 0x0000000180E83FC0-0x0000000180E83FD0
}

