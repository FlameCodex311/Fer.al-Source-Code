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

public class QueensDuelDice : MonoBehaviour // TypeDefIndex: 10771
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
	[Tooltip] // 0x000000018026CB30-0x000000018026CB60
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
	internal bool isLocked { get; set; } // 0x0000000180A389A0-0x0000000180A389B0 0x0000000180A389B0-0x0000000180A389C0
	internal QueensDuelDiceSpot OccupiedSpot { get; set; } // 0x0000000180431310-0x0000000180431320 0x0000000180479500-0x0000000180479510

	// Nested types
	internal enum EDiceFaceValue // TypeDefIndex: 10772
	{
		Sword = 0,
		Twiggle = 1,
		Kobold = 2,
		Captain = 3
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Rise>d__48 : IEnumerator<object> // TypeDefIndex: 10773
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Rise>d__48(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A402B0-0x0000000180A404F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A404F0-0x0000000180A40540
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Roll>d__49 : IEnumerator<object> // TypeDefIndex: 10774
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Roll>d__49(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A40540-0x0000000180A40A90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A40A90-0x0000000180A40AE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PhoDrop>d__50 : IEnumerator<object> // TypeDefIndex: 10775
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PhoDrop>d__50(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A3F8D0-0x0000000180A40260
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A40260-0x0000000180A402B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetOrientationBasedOnFaceValue>d__51 : IEnumerator<object> // TypeDefIndex: 10776
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetOrientationBasedOnFaceValue>d__51(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A40C80-0x0000000180A41200
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A41200-0x0000000180A41250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Shake>d__52 : IEnumerator<object> // TypeDefIndex: 10777
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20
		private Vector3 <rotationModifier>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Shake>d__52(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A41250-0x0000000180A41600
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A41600-0x0000000180A41650
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveTo>d__59 : IEnumerator<object> // TypeDefIndex: 10778
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveTo>d__59(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A3F380-0x0000000180A3F620
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A3F620-0x0000000180A3F670
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AutoRoll>d__60 : IEnumerator<object> // TypeDefIndex: 10779
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelDice <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AutoRoll>d__60(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A3E910-0x0000000180A3EA40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A3EA40-0x0000000180A3EA90
	}

	// Constructors
	public QueensDuelDice(); // 0x0000000180A38960-0x0000000180A389A0
	static QueensDuelDice(); // 0x0000000180A385A0-0x0000000180A38960

	// Methods
	internal void Init(bool inPlayerDice); // 0x0000000180A37610-0x0000000180A37780
	internal void SetDiceFaceValue(); // 0x0000000180A37EC0-0x0000000180A38050
	private void SetDiceGameValue(); // 0x0000000180A38050-0x0000000180A380C0
	[IteratorStateMachine] // 0x0000000180282490-0x00000001802824E0
	private IEnumerator Rise(); // 0x0000000180A37E00-0x0000000180A37E60
	[IteratorStateMachine] // 0x0000000180282740-0x0000000180282790
	private IEnumerator Roll(); // 0x0000000180A37E60-0x0000000180A37EC0
	[IteratorStateMachine] // 0x0000000180282930-0x0000000180282980
	private IEnumerator PhoDrop(); // 0x0000000180A37DA0-0x0000000180A37E00
	[IteratorStateMachine] // 0x0000000180282B80-0x0000000180282BD0
	private IEnumerator SetOrientationBasedOnFaceValue(float inTimeToOrient); // 0x0000000180A380C0-0x0000000180A38130
	[IteratorStateMachine] // 0x0000000180282D60-0x0000000180282DB0
	private IEnumerator Shake(); // 0x0000000180A38130-0x0000000180A38190
	internal void Cleanup(bool inActive); // 0x0000000180A37570-0x0000000180A37610
	internal void StartShake(bool inPlayFX = true /* Metadata: 0x0077C105 */); // 0x0000000180A383E0-0x0000000180A385A0
	internal void ShowSelected(bool inShow); // 0x0000000180A38190-0x0000000180A383E0
	private void OnMouseDrag(); // 0x0000000180A37900-0x0000000180A37A50
	private void OnMouseDown(); // 0x0000000180A37810-0x0000000180A37900
	private void OnMouseUp(); // 0x0000000180A37A50-0x0000000180A37DA0
	[IteratorStateMachine] // 0x0000000180282ED0-0x0000000180282F20
	internal IEnumerator MoveTo(Vector3 inPos, float inSpeedMultiplier = 1f /* Metadata: 0x0077C106 */); // 0x0000000180A37780-0x0000000180A37810
	[IteratorStateMachine] // 0x0000000180283170-0x00000001802831C0
	internal IEnumerator AutoRoll(); // 0x0000000180A37510-0x0000000180A37570
}

