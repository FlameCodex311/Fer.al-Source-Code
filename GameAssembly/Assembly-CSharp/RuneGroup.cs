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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RuneGroup : MonoBehaviour // TypeDefIndex: 10818
{
	// Fields
	public HexTile tilePrefab; // 0x20
	public HexGrid localGrid; // 0x28
	public BoxCollider boundingBox; // 0x30
	public float boundingBoxPadding; // 0x38
	public float rotateSpeed; // 0x3C
	public float dropDuration; // 0x40
	[Header] // 0x00000001801CF440-0x00000001801CF470
	public GameObject fxPrefabRunePlacedFlame; // 0x48
	public GameObject fxPrefabRunePlacedFlora; // 0x50
	public GameObject fxPrefabRunePlacedMiasma; // 0x58
	private bool _isMoving; // 0x60
	private Tweener _moveTween; // 0x68
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RuneGroupType <GroupType>k__BackingField; // 0x70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RunesGameBoard <GameBoard>k__BackingField; // 0x78
	private int _tileDropCounter; // 0x80
	private List<HexCoord> _lastDropCoords; // 0x88

	// Properties
	public RuneGroupType GroupType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804B4700-0x00000001804B4710 0x00000001804B47E0-0x00000001804B47F0
	public bool IsBombPowerUp { get; } // 0x00000001804B4710-0x00000001804B47D0 
	private RunesGameBoard GameBoard { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 10819
	{
		// Fields
		public HexTile inDropOnTile; // 0x10
		public HexTile inTile; // 0x18
		public RuneGroup <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DropStandardRune>b__0(); // 0x0000000180749C10-0x0000000180749CB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 10820
	{
		// Fields
		public HexTile inDropOnTile; // 0x10
		public HexTile inTile; // 0x18
		public RuneGroup <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass34_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DropPowerUpRune>b__0(); // 0x0000000180749CB0-0x0000000180749D30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForDrop>d__35 : IEnumerator<object> // TypeDefIndex: 10821
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RuneGroup <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForDrop>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018074A820-0x000000018074A9A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018074A9A0-0x000000018074A9F0
	}

	// Constructors
	public RuneGroup(); // 0x00000001804B4680-0x00000001804B4700

	// Methods
	public void CreateGroup(RuneGroupType inGroupType, RunesGameBoard inGameBoard); // 0x00000001804B0DF0-0x00000001804B1810
	public void SetRuneTypes(List<RuneType> inTypes, bool doShuffle = true /* Metadata: 0x0077C1CA */); // 0x00000001804B3DF0-0x00000001804B4000
	[DeMethodButton] // 0x00000001801CFFD0-0x00000001801D0030
	public void RotateTiles(); // 0x00000001804B2220-0x00000001804B3DF0
	private void UpdateBoundingBox(); // 0x00000001804B4010-0x00000001804B4610
	private void OnMouseDown(); // 0x00000001804B1F70-0x00000001804B2030
	private void OnMouseUp(); // 0x00000001804B2030-0x00000001804B20B0
	public bool CanDrop(HexGrid inDropOnGrid, List<HexCoord> outDropCoords = null); // 0x00000001804B0B60-0x00000001804B0DF0
	public bool CanDropForTutorial(HexGrid inDropOnGrid, List<HexCoord> tutorialCoords); // 0x00000001804B08D0-0x00000001804B0B60
	public bool CanDropAtCoord(HexGrid inDropOnGrid, HexCoord inDropCoord, List<HexCoord> outDropCoords = null); // 0x00000001804B0570-0x00000001804B08D0
	public void DropOnGrid(HexGrid inDropGrid); // 0x00000001804B1810-0x00000001804B1B10
	private void DropStandardRune(HexTile inTile, HexTile inDropOnTile, float inDelay = 0f /* Metadata: 0x0077C1CB */); // 0x00000001804B1CD0-0x00000001804B1E90
	private void DropPowerUpRune(HexTile inTile, HexTile inDropOnTile, float inDelay = 0f /* Metadata: 0x0077C1CF */); // 0x00000001804B1B10-0x00000001804B1CD0
	[IteratorStateMachine] // 0x00000001801D02B0-0x00000001801D0300
	private IEnumerator WaitForDrop(); // 0x00000001804B4610-0x00000001804B4680
	private void PlayRuneDropFx(HexTile inTile); // 0x00000001804B20B0-0x00000001804B2220
	public void MovePieceTo(Vector3 inPosition, float inDuration, Ease inEase = Ease.Linear /* Metadata: 0x0077C1D3 */); // 0x00000001804B1E90-0x00000001804B1F70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <WaitForDrop>b__35_0(); // 0x00000001804B4000-0x00000001804B4010
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MovePieceTo>b__37_0(); // 0x00000001803CD8B0-0x00000001803CD8C0
}

