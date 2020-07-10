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

public class QueensDuelDiceManager : MonoBehaviour // TypeDefIndex: 13115
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
	public struct DiceBoardColumn // TypeDefIndex: 13116
	{
		// Fields
		public string columnName; // 0x00
		public int _columnScore; // 0x08
		public QueensDuelDiceSpot[] Row; // 0x10

		// Properties
		public int columnScore { get; set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartShake>d__28 : IEnumerator<object> // TypeDefIndex: 13117
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDiceManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartShake>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181606C30-0x0000000181607220
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181607220-0x0000000181607270
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartTieShake>d__30 : IEnumerator<object> // TypeDefIndex: 13118
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDiceManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartTieShake>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181607270-0x0000000181607680
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181607680-0x00000001816076D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveDie>d__35 : IEnumerator<object> // TypeDefIndex: 13119
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveDie>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181602660-0x0000000181602890
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181602890-0x00000001816028E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AutoFinalRoll>d__48 : IEnumerator<object> // TypeDefIndex: 13120
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDiceManager <>4__this; // 0x20
		private int <i>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AutoFinalRoll>d__48(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181601B10-0x0000000181601C50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181601C50-0x0000000181601CA0
	}

	// Constructors
	public QueensDuelDiceManager(); // 0x00000001815F9E20-0x00000001815F9E50

	// Methods
	private void Start(); // 0x00000001815F82E0-0x00000001815F8DC0
	internal void DiceFinishedRolling(); // 0x00000001815F6860-0x00000001815F6970
	internal void RequestRollValues(string inDiceRequest, string inTurnNumber); // 0x00000001815F74D0-0x00000001815F76E0
	internal void ReceiveRollValues(string inRollResults); // 0x00000001815F6F50-0x00000001815F7010
	[IteratorStateMachine] // 0x00000001800EDAA0-0x00000001800EDAF0
	internal IEnumerator StartShake(); // 0x00000001815F8220-0x00000001815F8280
	internal void PlayDiceDrop(); // 0x00000001815F6D70-0x00000001815F6DF0
	[IteratorStateMachine] // 0x00000001800EDC80-0x00000001800EDCD0
	internal IEnumerator StartTieShake(); // 0x00000001815F8280-0x00000001815F82E0
	internal void UnlockAll(); // 0x00000001815F9220-0x00000001815F9330
	internal void Roll(); // 0x00000001815F76E0-0x00000001815F76F0
	private void SpotIndicatorChq(int inPlacemantLocatorIndex, int inRow, bool inActive); // 0x00000001815F8070-0x00000001815F8220
	internal void PickupDie(QueensDuelDice inDie); // 0x00000001815F6C90-0x00000001815F6D70
	[IteratorStateMachine] // 0x00000001800EDFF0-0x00000001800EE040
	private IEnumerator MoveDie(Transform inTrans, Vector3 inEndPosition); // 0x00000001815F6C00-0x00000001815F6C90
	internal void UpdateHighlightedSpots(); // 0x00000001815F9330-0x00000001815F9620
	internal void SelectedDice(QueensDuelDice inDice); // 0x00000001815F76F0-0x00000001815F79B0
	private bool AllPlaced(); // 0x00000001815F61E0-0x00000001815F62D0
	private void SpotChq(int inPlacmentLocatorIndex, int inRowIndex); // 0x00000001815F7B50-0x00000001815F8070
	private void ValidSpotChq(); // 0x00000001815F9620-0x00000001815F9E20
	private bool CloseToSpotChq(int inPlacmentLocatorIndex, int inRowIndex); // 0x00000001815F6330-0x00000001815F6760
	private bool CloseToSpotPosition(Transform inTrans1, Transform inTrans2); // 0x00000001815F6760-0x00000001815F6860
	internal void PlayerMoveDice(Vector3 inPoint); // 0x00000001815F6DF0-0x00000001815F6F50
	internal void HideUnplayedDice(); // 0x00000001815F6970-0x00000001815F6AC0
	internal void SpawnTieDice(List<int> inTieColumns); // 0x00000001815F79B0-0x00000001815F7B50
	internal void Replay(); // 0x00000001815F7010-0x00000001815F74D0
	internal void Init(); // 0x00000001815F6AC0-0x00000001815F6C00
	[IteratorStateMachine] // 0x00000001800EE170-0x00000001800EE1C0
	internal IEnumerator AutoFinalRoll(); // 0x00000001815F62D0-0x00000001815F6330
	internal void Unload(); // 0x00000001815F8DC0-0x00000001815F9220
}

