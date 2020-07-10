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

public class MothsAndFlamesDice : MonoBehaviour // TypeDefIndex: 13073
{
	// Fields
	public Rigidbody body; // 0x20
	public float riseTime; // 0x28
	public float riseHeight; // 0x2C
	public float diceShakeRotateSpeed; // 0x30
	public float diceShakeRotateSpeedRnd; // 0x34
	public float dropTime; // 0x38
	public float dropTimeVariance; // 0x3C
	public float initialPositionRandomnes; // 0x40
	public float revealMoveTime; // 0x44
	public GameObject diceGlowBlueFX; // 0x48
	public GameObject diceGlowOrangeFX; // 0x50
	public GameObject diceSnuffsOutFX; // 0x58
	public GameObject diceTrailFX; // 0x60
	public GameObject diceHitFX; // 0x68
	[Tooltip] // 0x00000001800D6E00-0x00000001800D6E30
	public Transform[] sideLocators; // 0x70
	internal int diceNumberValue; // 0x78
	internal int desiredNumberValue; // 0x7C
	internal int diceIndex; // 0x80
	internal Vector3 initialPosition; // 0x84
	internal Vector3 placedPosition; // 0x90
	internal static Vector3[] endRotation1; // 0x00
	internal static Vector3[] endRotation2; // 0x08
	internal static Vector3[] endRotation3; // 0x10
	internal static Vector3[] endRotation4; // 0x18
	internal static Vector3[] endRotation5; // 0x20
	internal static Vector3[] endRotation6; // 0x28
	internal EDiceFaceValue diceFaceValue; // 0x9C
	private float _diceShakeRotateSpeed; // 0xA0
	private Vector3 rotateDirO; // 0xA4
	private Vector3 _risePosition; // 0xB0
	private MothsAndFlamesGame _game; // 0xC0
	private MothsAndFlamesDiceManager _diceManager; // 0xC8
	private Coroutine _diceShakeCoroutine; // 0xD0
	private Transform _cupCenter; // 0xD8
	private EDiceState _diceState; // 0xE0

	// Properties
	private EDiceState DiceState { get; set; } // 0x00000001812E0390-0x00000001812E03A0 0x00000001812E03A0-0x00000001812E03B0

	// Nested types
	internal enum EDiceFaceValue // TypeDefIndex: 13074
	{
		Moth = 0,
		Flame = 1,
		Other = 2
	}

	private enum EDiceState // TypeDefIndex: 13075
	{
		Wait = 0,
		Rise = 1,
		Shake = 2,
		RevealWait = 3,
		Reveal = 4
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Rise>d__44 : IEnumerator<object> // TypeDefIndex: 13076
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Rise>d__44(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F0430-0x00000001812F06D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F06D0-0x00000001812F0720
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Shake>d__45 : IEnumerator<object> // TypeDefIndex: 13077
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		private Vector3 <rotationModifier>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Shake>d__45(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F17B0-0x00000001812F1AF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F1AF0-0x00000001812F1B40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Roll>d__47 : IEnumerator<object> // TypeDefIndex: 13078
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Roll>d__47(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F0720-0x00000001812F08E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F08E0-0x00000001812F0930
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveToReveal>d__48 : IEnumerator<object> // TypeDefIndex: 13079
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		private Vector3 <startposition>5__2; // 0x28
		private Vector3 <endPosition>5__3; // 0x34
		private float <t>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveToReveal>d__48(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EE4F0-0x00000001812EE810
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EE810-0x00000001812EE860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PhoDrop>d__49 : IEnumerator<object> // TypeDefIndex: 13080
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
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
		public <PhoDrop>d__49(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EF150-0x00000001812EF920
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EF920-0x00000001812EF970
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ShowResults>d__50 : IEnumerator<object> // TypeDefIndex: 13081
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		public bool inResultsWin; // 0x28
		public bool inFlamesSelected; // 0x29

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ShowResults>d__50(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F1B40-0x00000001812F1E30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F1E30-0x00000001812F1E80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetOrientationBasedOnFaceValue>d__51 : IEnumerator<object> // TypeDefIndex: 13082
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
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
		private bool MoveNext(); // 0x00000001812F11C0-0x00000001812F1760
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F1760-0x00000001812F17B0
	}

	// Constructors
	public MothsAndFlamesDice(); // 0x00000001812E0350-0x00000001812E0390
	static MothsAndFlamesDice(); // 0x00000001812DFF70-0x00000001812E0350

	// Methods
	internal void Init(int inIndex); // 0x00000001812DF4D0-0x00000001812DF670
	internal void Unload(); // 0x00000001812DFDF0-0x00000001812DFF70
	internal void SetDiceFaceValue(); // 0x00000001812DF960-0x00000001812DFAE0
	internal static EDiceFaceValue GetFaceValue(int inNumberValue); // 0x00000001812DF4B0-0x00000001812DF4D0
	[IteratorStateMachine] // 0x00000001800D70E0-0x00000001800D7130
	private IEnumerator Rise(); // 0x00000001812DF8A0-0x00000001812DF900
	[IteratorStateMachine] // 0x00000001800D7390-0x00000001800D73E0
	private IEnumerator Shake(); // 0x00000001812DFB50-0x00000001812DFBB0
	internal void PreReveal(); // 0x00000001812DF7B0-0x00000001812DF8A0
	[IteratorStateMachine] // 0x00000001800D7540-0x00000001800D7590
	private IEnumerator Roll(); // 0x00000001812DF900-0x00000001812DF960
	[IteratorStateMachine] // 0x00000001800D78D0-0x00000001800D7920
	internal IEnumerator MoveToReveal(); // 0x00000001812DF670-0x00000001812DF6D0
	[IteratorStateMachine] // 0x00000001800D7A80-0x00000001800D7AD0
	private IEnumerator PhoDrop(); // 0x00000001812DF750-0x00000001812DF7B0
	[IteratorStateMachine] // 0x00000001800D7DC0-0x00000001800D7E10
	internal IEnumerator ShowResults(bool inResultsWin, bool inFlamesSelected); // 0x00000001812DFBB0-0x00000001812DFC30
	[IteratorStateMachine] // 0x00000001800D8270-0x00000001800D82C0
	private IEnumerator SetOrientationBasedOnFaceValue(float inTimeToOrient); // 0x00000001812DFAE0-0x00000001812DFB50
	internal void Cleanup(bool inActive); // 0x00000001812DF430-0x00000001812DF4B0
	internal void StartShake(); // 0x00000001812DFC30-0x00000001812DFDF0
	private void OnTriggerEnter(Collider other); // 0x00000001812DF6D0-0x00000001812DF750
}

