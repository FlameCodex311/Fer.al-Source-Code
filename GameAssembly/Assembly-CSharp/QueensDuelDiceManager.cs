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

public class QueensDuelDiceManager : MonoBehaviour // TypeDefIndex: 10780
{
	// Fields
	public float diePickupTime; // 0x20
	public float validSpotDistance; // 0x24
	public float moveHeightY; // 0x28
	public QueensDuelDice dicePrefab; // 0x30
	public Transform[] playerDiceLocators; // 0x38
	public Transform[] playerTieDiceLocators; // 0x40
	public DiceBoardColumn[] playerPlacementLocators; // 0x48
	public Transform[] opponentDiceLocators; // 0x50
	public Transform[] opponentTieDiceLocators; // 0x58
	public DiceBoardColumn[] opponentPlacementLocators; // 0x60
	internal QueensDuelDice[] playerDice; // 0x68
	internal QueensDuelDice[] opponentDice; // 0x70
	internal QueensDuelDice[] allDice; // 0x78
	internal QueensDuelDice[] playerTieDice; // 0x80
	internal QueensDuelDice[] opponentTieDice; // 0x88
	internal QueensDuelDice[] allTieDice; // 0x90
	internal bool Shaking; // 0x98
	internal int numDiceRolling; // 0x9C
	internal QueensDuelDice selectedDice; // 0xA0
	private Vector3 _diceMover; // 0xA8
	private int _numPlayerDiceRolling; // 0xB4
	private QueensDuelGame _game; // 0xB8
	public float distFromKeepSpotToKeep; // 0xC0

	// Nested types
	[Serializable]
	public struct DiceBoardColumn // TypeDefIndex: 10781
	{
		// Fields
		public string columnName; // 0x00
		public int _columnScore; // 0x08
		public QueensDuelDiceSpot[] Row; // 0x10

		// Properties
		public int columnScore { get; set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartShake>d__28 : IEnumerator<object> // TypeDefIndex: 10782
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDiceManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartShake>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A43630-0x0000000180A43BF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A43BF0-0x0000000180A43C40
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartTieShake>d__30 : IEnumerator<object> // TypeDefIndex: 10783
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDiceManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartTieShake>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A43C40-0x0000000180A44020
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A44020-0x0000000180A44070
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveDie>d__35 : IEnumerator<object> // TypeDefIndex: 10784
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTrans; // 0x20
		public QueensDuelDiceManager <>4__this; // 0x28
		public Vector3 inEndPosition; // 0x30
		private Vector3 <startPos>5__2; // 0x3C
		private float <t>5__3; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveDie>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A3F100-0x0000000180A3F330
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A3F330-0x0000000180A3F380
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AutoFinalRoll>d__48 : IEnumerator<object> // TypeDefIndex: 10785
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDiceManager <>4__this; // 0x20
		private int <i>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AutoFinalRoll>d__48(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A3E790-0x0000000180A3E8C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A3E8C0-0x0000000180A3E910
	}

	// Constructors
	public QueensDuelDiceManager(); // 0x0000000180A374E0-0x0000000180A37510

	// Methods
	private void Start(); // 0x0000000180A35BA0-0x0000000180A365E0
	internal void DiceFinishedRolling(); // 0x0000000180A34270-0x0000000180A343A0
	internal void RequestRollValues(string inDiceRequest, string inTurnNumber); // 0x0000000180A34E90-0x0000000180A35090
	internal void ReceiveRollValues(string inRollResults); // 0x0000000180A34960-0x0000000180A34A20
	[IteratorStateMachine] // 0x0000000180288FC0-0x0000000180289010
	internal IEnumerator StartShake(); // 0x0000000180A35AE0-0x0000000180A35B40
	internal void PlayDiceDrop(); // 0x0000000180A34780-0x0000000180A34800
	[IteratorStateMachine] // 0x0000000180289240-0x0000000180289290
	internal IEnumerator StartTieShake(); // 0x0000000180A35B40-0x0000000180A35BA0
	internal void UnlockAll(); // 0x0000000180A36A10-0x0000000180A36B10
	internal void Roll(); // 0x0000000180A35090-0x0000000180A350A0
	private void SpotIndicatorChq(int inPlacemantLocatorIndex, int inRow, bool inActive); // 0x0000000180A35940-0x0000000180A35AE0
	internal void PickupDie(QueensDuelDice inDie); // 0x0000000180A346A0-0x0000000180A34780
	[IteratorStateMachine] // 0x0000000180289460-0x00000001802894B0
	private IEnumerator MoveDie(Transform inTrans, Vector3 inEndPosition); // 0x0000000180A34610-0x0000000180A346A0
	internal void UpdateHighlightedSpots(); // 0x0000000180A36B10-0x0000000180A36DE0
	internal void SelectedDice(QueensDuelDice inDice); // 0x0000000180A350A0-0x0000000180A352F0
	private bool AllPlaced(); // 0x0000000180A33C30-0x0000000180A33D10
	private void SpotChq(int inPlacmentLocatorIndex, int inRowIndex); // 0x0000000180A35470-0x0000000180A35940
	private void ValidSpotChq(); // 0x0000000180A36DE0-0x0000000180A374E0
	private bool CloseToSpotChq(int inPlacmentLocatorIndex, int inRowIndex); // 0x0000000180A33D70-0x0000000180A34170
	private bool CloseToSpotPosition(Transform inTrans1, Transform inTrans2); // 0x0000000180A34170-0x0000000180A34270
	internal void PlayerMoveDice(Vector3 inPoint); // 0x0000000180A34800-0x0000000180A34960
	internal void HideUnplayedDice(); // 0x0000000180A343A0-0x0000000180A344E0
	internal void SpawnTieDice(List<int> inTieColumns); // 0x0000000180A352F0-0x0000000180A35470
	internal void Replay(); // 0x0000000180A34A20-0x0000000180A34E90
	internal void Init(); // 0x0000000180A344E0-0x0000000180A34610
	[IteratorStateMachine] // 0x0000000180289630-0x0000000180289680
	internal IEnumerator AutoFinalRoll(); // 0x0000000180A33D10-0x0000000180A33D70
	internal void Unload(); // 0x0000000180A365E0-0x0000000180A36A10
}

