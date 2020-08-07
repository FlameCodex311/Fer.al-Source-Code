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

public class MothsAndFlamesDice : MonoBehaviour // TypeDefIndex: 10738
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
	[Tooltip] // 0x000000018026CB30-0x000000018026CB60
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
	private EDiceState DiceState { get; set; } // 0x0000000180475730-0x0000000180475740 0x0000000180479310-0x0000000180479320

	// Nested types
	internal enum EDiceFaceValue // TypeDefIndex: 10739
	{
		Moth = 0,
		Flame = 1,
		Other = 2
	}

	private enum EDiceState // TypeDefIndex: 10740
	{
		Wait = 0,
		Rise = 1,
		Shake = 2,
		RevealWait = 3,
		Reveal = 4
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Rise>d__44 : IEnumerator<object> // TypeDefIndex: 10741
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Rise>d__44(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C16AC0-0x0000000180C16D60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C16D60-0x0000000180C16DB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Shake>d__45 : IEnumerator<object> // TypeDefIndex: 10742
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		private Vector3 <rotationModifier>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Shake>d__45(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807DA0B0-0x00000001807DA3E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DA3E0-0x00000001807DA430
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Roll>d__47 : IEnumerator<object> // TypeDefIndex: 10743
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Roll>d__47(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D9320-0x00000001807D9490
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D9490-0x00000001807D94E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveToReveal>d__48 : IEnumerator<object> // TypeDefIndex: 10744
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		private Vector3 <startposition>5__2; // 0x28
		private Vector3 <endPosition>5__3; // 0x34
		private float <t>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveToReveal>d__48(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C15590-0x0000000180C158A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C158A0-0x0000000180C158F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PhoDrop>d__49 : IEnumerator<object> // TypeDefIndex: 10745
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PhoDrop>d__49(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C15E60-0x0000000180C165F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C165F0-0x0000000180C16640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ShowResults>d__50 : IEnumerator<object> // TypeDefIndex: 10746
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDice <>4__this; // 0x20
		public bool inResultsWin; // 0x28
		public bool inFlamesSelected; // 0x29

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ShowResults>d__50(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807DA430-0x00000001807DA530
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DA530-0x00000001807DA580
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetOrientationBasedOnFaceValue>d__51 : IEnumerator<object> // TypeDefIndex: 10747
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetOrientationBasedOnFaceValue>d__51(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D9AE0-0x00000001807DA060
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DA060-0x00000001807DA0B0
	}

	// Constructors
	public MothsAndFlamesDice(); // 0x0000000180C12AA0-0x0000000180C12AE0
	static MothsAndFlamesDice(); // 0x0000000180C126E0-0x0000000180C12AA0

	// Methods
	internal void Init(int inIndex); // 0x0000000180C11C10-0x0000000180C11DA0
	internal void Unload(); // 0x0000000180C12570-0x0000000180C126E0
	internal void SetDiceFaceValue(); // 0x0000000180C120A0-0x0000000180C12210
	internal static EDiceFaceValue GetFaceValue(int inNumberValue); // 0x0000000180C11BF0-0x0000000180C11C10
	[IteratorStateMachine] // 0x000000018026CDA0-0x000000018026CDF0
	private IEnumerator Rise(); // 0x0000000180C11FD0-0x0000000180C12030
	[IteratorStateMachine] // 0x000000018026D000-0x000000018026D050
	private IEnumerator Shake(); // 0x0000000180C12290-0x0000000180C12300
	internal void PreReveal(); // 0x0000000180C11EE0-0x0000000180C11FD0
	[IteratorStateMachine] // 0x000000018026E4B0-0x000000018026E500
	private IEnumerator Roll(); // 0x0000000180C12030-0x0000000180C120A0
	[IteratorStateMachine] // 0x000000018026E680-0x000000018026E6D0
	internal IEnumerator MoveToReveal(); // 0x0000000180C11DA0-0x0000000180C11E00
	[IteratorStateMachine] // 0x000000018026FB00-0x000000018026FB50
	private IEnumerator PhoDrop(); // 0x0000000180C11E80-0x0000000180C11EE0
	[IteratorStateMachine] // 0x000000018026FCE0-0x000000018026FD30
	internal IEnumerator ShowResults(bool inResultsWin, bool inFlamesSelected); // 0x0000000180C12300-0x0000000180C12390
	[IteratorStateMachine] // 0x000000018026FFD0-0x0000000180270020
	private IEnumerator SetOrientationBasedOnFaceValue(float inTimeToOrient); // 0x0000000180C12210-0x0000000180C12290
	internal void Cleanup(bool inActive); // 0x0000000180C11B70-0x0000000180C11BF0
	internal void StartShake(); // 0x0000000180C12390-0x0000000180C12570
	private void OnTriggerEnter(Collider other); // 0x0000000180C11E00-0x0000000180C11E80
}

