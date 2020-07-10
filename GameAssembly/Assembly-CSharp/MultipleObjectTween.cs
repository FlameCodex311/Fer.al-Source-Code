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

public class MultipleObjectTween : ManagedBehaviour // TypeDefIndex: 11743
{
	// Fields
	[Header] // 0x0000000180107AD0-0x0000000180107B00
	public TweenInfo[] tweenInfos; // 0x50
	[Header] // 0x0000000180107D10-0x0000000180107D60
	[SerializeField] // 0x0000000180107D10-0x0000000180107D60
	private float _minRndDelay; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxRndDelay; // 0x5C
	[Header] // 0x00000001801080E0-0x0000000180108130
	[SerializeField] // 0x00000001801080E0-0x0000000180108130
	private bool _initAfterFirstScaleChange; // 0x60
	private Vector3 _originalScale; // 0x64
	private List<TransformInfo> _transformInfos; // 0x70

	// Nested types
	[Serializable]
	public class TweenInfo // TypeDefIndex: 11744
	{
		// Fields
		public string gameObjectName; // 0x10
		[Header] // 0x0000000180108D40-0x0000000180108D70
		public bool randomizePosition; // 0x18
		public Vector3 minRndPosition; // 0x1C
		public Vector3 maxRndPosition; // 0x28
		[Range] // 0x0000000180108EB0-0x0000000180108ED0
		public float minPositionTimer; // 0x34
		[Range] // 0x0000000180108EB0-0x0000000180108ED0
		public float maxPositionTimer; // 0x38
		[Header] // 0x00000001800E34E0-0x00000001800E3510
		public bool randomizeRotation; // 0x3C
		public Vector3 minRndRotation; // 0x40
		public Vector3 maxRndRotation; // 0x4C
		[Range] // 0x0000000180108EB0-0x0000000180108ED0
		public float minRotationTimer; // 0x58
		[Range] // 0x0000000180108EB0-0x0000000180108ED0
		public float maxRotationTimer; // 0x5C
		[Header] // 0x000000018010A7E0-0x000000018010A810
		public bool randomizeScale; // 0x60
		public Vector3 minRndScale; // 0x64
		public Vector3 maxRndScale; // 0x70
		[Range] // 0x0000000180108EB0-0x0000000180108ED0
		public float minScaleTimer; // 0x7C
		[Range] // 0x0000000180108EB0-0x0000000180108ED0
		public float maxScaleTimer; // 0x80
		[NonSerialized]
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public List<Transform> foundTransforms; // 0x88
		public FeralAudioInfo audioMove; // 0x90
		public FeralAudioInfo audioLoop; // 0x98
		[NonSerialized]
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public bool audioLoopTriggered; // 0xA0

		// Constructors
		public TweenInfo(); // 0x00000001812EBC10-0x00000001812EBE70
	}

	[Serializable]
	public class TransformInfo // TypeDefIndex: 11745
	{
		// Fields
		public Vector3 initialPosition; // 0x10
		public Transform transform; // 0x20

		// Constructors
		public TransformInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ScaleChange>d__9 : IEnumerator<object> // TypeDefIndex: 11746
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MultipleObjectTween <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ScaleChange>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F0BB0-0x00000001812F0D20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F0D20-0x00000001812F0D70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TweenObjectPosition>d__12 : IEnumerator<object> // TypeDefIndex: 11747
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTransform; // 0x20
		public TweenInfo inTweenInfo; // 0x28
		public MultipleObjectTween <>4__this; // 0x30
		private Vector3 <vOriginalPosition>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TweenObjectPosition>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F2590-0x00000001812F2880
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F2880-0x00000001812F28D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TweenObjectRotation>d__15 : IEnumerator<object> // TypeDefIndex: 11748
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTransform; // 0x20
		public TweenInfo inTweenInfo; // 0x28
		public MultipleObjectTween <>4__this; // 0x30
		private Vector3 <vOriginalRotation>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TweenObjectRotation>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F28D0-0x00000001812F2BA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F2BA0-0x00000001812F2BF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TweenObjectScale>d__16 : IEnumerator<object> // TypeDefIndex: 11749
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTransform; // 0x20
		public TweenInfo inTweenInfo; // 0x28
		public MultipleObjectTween <>4__this; // 0x30
		private Vector3 <vOriginalScale>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TweenObjectScale>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F2BF0-0x00000001812F2EB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F2EB0-0x00000001812F2F00
	}

	// Constructors
	public MultipleObjectTween(); // 0x00000001812E2DC0-0x00000001812E2E90

	// Methods
	public override void MStart(); // 0x00000001812E2250-0x00000001812E2310
	[IteratorStateMachine] // 0x0000000180108250-0x00000001801082A0
	private IEnumerator ScaleChange(); // 0x00000001812E25C0-0x00000001812E2620
	private void TweenAfterScale(); // 0x00000001812E2AD0-0x00000001812E2C40
	private void SetTweens(); // 0x00000001812E2620-0x00000001812E2AD0
	[IteratorStateMachine] // 0x0000000180108570-0x00000001801085C0
	private IEnumerator TweenObjectPosition(Transform inTransform, TweenInfo inTweenInfo); // 0x00000001812E2C40-0x00000001812E2CC0
	private void PlayMoveAudio(TweenInfo inTweenInfo); // 0x00000001812E2470-0x00000001812E25C0
	private void PlayLoopAudio(TweenInfo inTweenInfo); // 0x00000001812E2310-0x00000001812E2470
	[IteratorStateMachine] // 0x0000000180108750-0x00000001801087A0
	private IEnumerator TweenObjectRotation(Transform inTransform, TweenInfo inTweenInfo); // 0x00000001812E2CC0-0x00000001812E2D40
	[IteratorStateMachine] // 0x0000000180108A70-0x0000000180108AC0
	private IEnumerator TweenObjectScale(Transform inTransform, TweenInfo inTweenInfo); // 0x00000001812E2D40-0x00000001812E2DC0
}

