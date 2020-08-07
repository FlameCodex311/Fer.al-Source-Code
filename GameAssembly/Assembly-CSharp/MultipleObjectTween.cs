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

public class MultipleObjectTween : ManagedBehaviour // TypeDefIndex: 13278
{
	// Fields
	[Header] // 0x00000001801E58D0-0x00000001801E5900
	public TweenInfo[] tweenInfos; // 0x50
	[Header] // 0x00000001801E5A60-0x00000001801E5AB0
	[SerializeField] // 0x00000001801E5A60-0x00000001801E5AB0
	private float _minRndDelay; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxRndDelay; // 0x5C
	[Header] // 0x00000001801E5FD0-0x00000001801E6020
	[SerializeField] // 0x00000001801E5FD0-0x00000001801E6020
	private bool _initAfterFirstScaleChange; // 0x60
	private Vector3 _originalScale; // 0x64
	private List<TransformInfo> _transformInfos; // 0x70

	// Nested types
	[Serializable]
	public class TweenInfo // TypeDefIndex: 13279
	{
		// Fields
		public string gameObjectName; // 0x10
		[Header] // 0x00000001801E71F0-0x00000001801E7220
		public bool randomizePosition; // 0x18
		public Vector3 minRndPosition; // 0x1C
		public Vector3 maxRndPosition; // 0x28
		[Range] // 0x00000001801E73D0-0x00000001801E73F0
		public float minPositionTimer; // 0x34
		[Range] // 0x00000001801E73D0-0x00000001801E73F0
		public float maxPositionTimer; // 0x38
		[Header] // 0x00000001801E7730-0x00000001801E7760
		public bool randomizeRotation; // 0x3C
		public Vector3 minRndRotation; // 0x40
		public Vector3 maxRndRotation; // 0x4C
		[Range] // 0x00000001801E73D0-0x00000001801E73F0
		public float minRotationTimer; // 0x58
		[Range] // 0x00000001801E73D0-0x00000001801E73F0
		public float maxRotationTimer; // 0x5C
		[Header] // 0x00000001801E8F10-0x00000001801E8F40
		public bool randomizeScale; // 0x60
		public Vector3 minRndScale; // 0x64
		public Vector3 maxRndScale; // 0x70
		[Range] // 0x00000001801E73D0-0x00000001801E73F0
		public float minScaleTimer; // 0x7C
		[Range] // 0x00000001801E73D0-0x00000001801E73F0
		public float maxScaleTimer; // 0x80
		[NonSerialized]
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<Transform> foundTransforms; // 0x88
		public FeralAudioInfo audioMove; // 0x90
		public FeralAudioInfo audioLoop; // 0x98
		[NonSerialized]
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool audioLoopTriggered; // 0xA0

		// Constructors
		public TweenInfo(); // 0x00000001807D7590-0x00000001807D77F0
	}

	[Serializable]
	public class TransformInfo // TypeDefIndex: 13280
	{
		// Fields
		public Vector3 initialPosition; // 0x10
		public Transform transform; // 0x20

		// Constructors
		public TransformInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ScaleChange>d__9 : IEnumerator<object> // TypeDefIndex: 13281
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MultipleObjectTween <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ScaleChange>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D94E0-0x00000001807D9650
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D9650-0x00000001807D96A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TweenObjectPosition>d__12 : IEnumerator<object> // TypeDefIndex: 13282
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTransform; // 0x20
		public TweenInfo inTweenInfo; // 0x28
		public MultipleObjectTween <>4__this; // 0x30
		private Vector3 <vOriginalPosition>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TweenObjectPosition>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807DA8D0-0x00000001807DABB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DABB0-0x00000001807DAC00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TweenObjectRotation>d__15 : IEnumerator<object> // TypeDefIndex: 13283
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTransform; // 0x20
		public TweenInfo inTweenInfo; // 0x28
		public MultipleObjectTween <>4__this; // 0x30
		private Vector3 <vOriginalRotation>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TweenObjectRotation>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807DAC00-0x00000001807DAEC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DAEC0-0x00000001807DAF10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TweenObjectScale>d__16 : IEnumerator<object> // TypeDefIndex: 13284
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTransform; // 0x20
		public TweenInfo inTweenInfo; // 0x28
		public MultipleObjectTween <>4__this; // 0x30
		private Vector3 <vOriginalScale>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TweenObjectScale>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807DAF10-0x00000001807DB1C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DB1C0-0x00000001807DB210
	}

	// Constructors
	public MultipleObjectTween(); // 0x00000001807C8920-0x00000001807C89F0

	// Methods
	public override void MStart(); // 0x00000001807C7E00-0x00000001807C7EC0
	[IteratorStateMachine] // 0x00000001801E6310-0x00000001801E6360
	private IEnumerator ScaleChange(); // 0x00000001807C8160-0x00000001807C81C0
	private void TweenAfterScale(); // 0x00000001807C8640-0x00000001807C87A0
	private void SetTweens(); // 0x00000001807C81C0-0x00000001807C8640
	[IteratorStateMachine] // 0x00000001801E6680-0x00000001801E66D0
	private IEnumerator TweenObjectPosition(Transform inTransform, TweenInfo inTweenInfo); // 0x00000001807C87A0-0x00000001807C8820
	private void PlayMoveAudio(TweenInfo inTweenInfo); // 0x00000001807C8020-0x00000001807C8160
	private void PlayLoopAudio(TweenInfo inTweenInfo); // 0x00000001807C7EC0-0x00000001807C8020
	[IteratorStateMachine] // 0x00000001801E6960-0x00000001801E69B0
	private IEnumerator TweenObjectRotation(Transform inTransform, TweenInfo inTweenInfo); // 0x00000001807C8820-0x00000001807C88A0
	[IteratorStateMachine] // 0x00000001801E6CA0-0x00000001801E6CF0
	private IEnumerator TweenObjectScale(Transform inTransform, TweenInfo inTweenInfo); // 0x00000001807C88A0-0x00000001807C8920
}

