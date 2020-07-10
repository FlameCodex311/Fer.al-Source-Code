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

public class QueensDuelDice : MonoBehaviour // TypeDefIndex: 13106
{
	// Fields
	public GameObject hoverFX; // 0x20
	public GameObject sparkFX; // 0x28
	public Material playerMaterial; // 0x30
	public Material opponentMaterial; // 0x38
	public MeshRenderer meshRenderer; // 0x40
	public Rigidbody body; // 0x48
	public GameObject selectionIndicator; // 0x50
	public float riseTime; // 0x58
	public float riseHeight; // 0x5C
	public float diceShakeRotateSpeed; // 0x60
	public float diceShakeRotateSpeedRnd; // 0x64
	public float dropTime; // 0x68
	public float dropTimeVariance; // 0x6C
	public float initialPositionRandomnes; // 0x70
	[Tooltip] // 0x00000001800D6E00-0x00000001800D6E30
	public Transform[] sideLocators; // 0x78
	internal int diceNumberValue; // 0x80
	internal int desiredNumberValue; // 0x84
	internal int diceIndex; // 0x88
	internal Vector3 initialPosition; // 0x8C
	internal Vector3 placedPosition; // 0x98
	internal static Vector3[] endRotation1; // 0x00
	internal static Vector3[] endRotation2; // 0x08
	internal static Vector3[] endRotation3; // 0x10
	internal static Vector3[] endRotation4; // 0x18
	internal static Vector3[] endRotation5; // 0x20
	internal static Vector3[] endRotation6; // 0x28
	internal bool _isLocked; // 0xA4
	private QueensDuelDiceSpot _occupiedSpot; // 0xA8
	internal EDiceFaceValue diceFaceValue; // 0xB0
	private Vector3 _risePosition; // 0xB4
	private bool _playerDice; // 0xC0
	private bool _canSelect; // 0xC1
	private bool _rising; // 0xC2
	private float _diceShakeRotateSpeed; // 0xC4
	private Vector3 rotateDirO; // 0xC8
	private QueensDuelDiceManager _diceManager; // 0xD8
	private QueensDuelGame _game; // 0xE0
	private Vector3? _previousMousePosition; // 0xE8

	// Properties
	internal bool isLocked { get; set; } // 0x000000018139F360-0x000000018139F370 0x000000018139F3C0-0x000000018139F3D0
	internal QueensDuelDiceSpot OccupiedSpot { get; set; } // 0x0000000180382A90-0x0000000180382AA0 0x00000001804A1230-0x00000001804A1240

	// Nested types
	internal enum EDiceFaceValue // TypeDefIndex: 13107
	{
		Sword = 0,
		Twiggle = 1,
		Kobold = 2,
		Captain = 3
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Rise>d__48 : IEnumerator<object> // TypeDefIndex: 13108
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Rise>d__48(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181603AF0-0x0000000181603D30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181603D30-0x0000000181603D80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Roll>d__49 : IEnumerator<object> // TypeDefIndex: 13109
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Roll>d__49(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181603D80-0x00000001816042C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816042C0-0x0000000181604310
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PhoDrop>d__50 : IEnumerator<object> // TypeDefIndex: 13110
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20
		private Vector3 <startRotation>5__2; // 0x28
		private Vector3 <endRotation>5__3; // 0x34
		private Vector3 <startposition>5__4; // 0x40
		private Vector3 <endPosition>5__5; // 0x4C
		private float <dTime>5__6; // 0x58
		private float <t>5__7; // 0x5C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PhoDrop>d__50(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181602E40-0x0000000181603810
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181603810-0x0000000181603860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetOrientationBasedOnFaceValue>d__51 : IEnumerator<object> // TypeDefIndex: 13111
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20
		public float inTimeToOrient; // 0x28
		private Quaternion <startRot>5__2; // 0x2C
		private Quaternion <endRot>5__3; // 0x3C
		private float <t>5__4; // 0x4C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetOrientationBasedOnFaceValue>d__51(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181604310-0x00000001816048B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816048B0-0x0000000181604900
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Shake>d__52 : IEnumerator<object> // TypeDefIndex: 13112
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20
		private Vector3 <rotationModifier>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Shake>d__52(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181604900-0x0000000181604CB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181604CB0-0x0000000181604D00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveTo>d__59 : IEnumerator<object> // TypeDefIndex: 13113
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20
		public float inSpeedMultiplier; // 0x28
		public Vector3 inPos; // 0x2C
		private Vector3 <startPos>5__2; // 0x38
		private float <t>5__3; // 0x44

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveTo>d__59(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816028E0-0x0000000181602B80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181602B80-0x0000000181602BD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AutoRoll>d__60 : IEnumerator<object> // TypeDefIndex: 13114
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AutoRoll>d__60(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181601CA0-0x0000000181601DE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181601DE0-0x0000000181601E30
	}

	// Constructors
	public QueensDuelDice(); // 0x00000001815FB320-0x00000001815FB360
	static QueensDuelDice(); // 0x00000001815FAF40-0x00000001815FB320

	// Methods
	internal void Init(bool inPlayerDice); // 0x00000001815F9F50-0x00000001815FA0D0
	internal void SetDiceFaceValue(); // 0x00000001815FA840-0x00000001815FA9E0
	private void SetDiceGameValue(); // 0x00000001815FA9E0-0x00000001815FAA50
	[IteratorStateMachine] // 0x00000001800E8B20-0x00000001800E8B70
	private IEnumerator Rise(); // 0x00000001815FA780-0x00000001815FA7E0
	[IteratorStateMachine] // 0x00000001800E8C70-0x00000001800E8CC0
	private IEnumerator Roll(); // 0x00000001815FA7E0-0x00000001815FA840
	[IteratorStateMachine] // 0x00000001800E8F60-0x00000001800E8FB0
	private IEnumerator PhoDrop(); // 0x00000001815FA720-0x00000001815FA780
	[IteratorStateMachine] // 0x00000001800E9210-0x00000001800E9260
	private IEnumerator SetOrientationBasedOnFaceValue(float inTimeToOrient); // 0x00000001815FAA50-0x00000001815FAAC0
	[IteratorStateMachine] // 0x00000001800E9380-0x00000001800E93D0
	private IEnumerator Shake(); // 0x00000001815FAAC0-0x00000001815FAB20
	internal void Cleanup(bool inActive); // 0x00000001815F9EB0-0x00000001815F9F50
	internal void StartShake(bool inPlayFX = true /* Metadata: 0x0078364A */); // 0x00000001815FAD80-0x00000001815FAF40
	internal void ShowSelected(bool inShow); // 0x00000001815FAB20-0x00000001815FAD80
	private void OnMouseDrag(); // 0x00000001815FA260-0x00000001815FA3C0
	private void OnMouseDown(); // 0x00000001815FA160-0x00000001815FA260
	private void OnMouseUp(); // 0x00000001815FA3C0-0x00000001815FA720
	[IteratorStateMachine] // 0x00000001800E9550-0x00000001800E95A0
	internal IEnumerator MoveTo(Vector3 inPos, float inSpeedMultiplier = 1f /* Metadata: 0x0078364B */); // 0x00000001815FA0D0-0x00000001815FA160
	[IteratorStateMachine] // 0x00000001800E9700-0x00000001800E9750
	internal IEnumerator AutoRoll(); // 0x00000001815F9E50-0x00000001815F9EB0
}

