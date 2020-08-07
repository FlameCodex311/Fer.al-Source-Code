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

public class SocialExpanseDigSpot : MonoBehaviour // TypeDefIndex: 13235
{
	// Fields
	public ParticleSystem digFX; // 0x20
	public SocialExpanseDigSpotSettings socialExpanseDigSpotSetting; // 0x28
	private ParticleSystem[] _digFX; // 0x30
	private Interactable _interactable; // 0x38
	private Coroutine _alignCoroutine; // 0x40
	private Coroutine _moveCameraCoroutine; // 0x48
	private Transform _playerCameraTransform; // 0x50
	private Transform _playerTransform; // 0x58
	private GameObject _digCameraStartPosition; // 0x60
	private Vector3 _digCamStartPosition; // 0x68
	private Vector3 _digCamEndPosition; // 0x74
	private Vector3 _endMovePosition; // 0x80
	private bool _finished; // 0x8C

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AlignToDigSpot>d__17 : IEnumerator<object> // TypeDefIndex: 13236
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SocialExpanseDigSpot <>4__this; // 0x20
		private Vector3 <startMovePosition>5__2; // 0x28
		private Quaternion <startRotation>5__3; // 0x34
		private Quaternion <endRotation>5__4; // 0x44
		private float <t>5__5; // 0x54

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AlignToDigSpot>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180773D40-0x0000000180774220
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180774220-0x0000000180774270
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveCamera>d__18 : IEnumerator<object> // TypeDefIndex: 13237
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public bool inActivate; // 0x20
		public SocialExpanseDigSpot <>4__this; // 0x28
		private Quaternion <startRot>5__2; // 0x30
		private Quaternion <endRot>5__3; // 0x40
		private float <t>5__4; // 0x50
		private float <l>5__5; // 0x54
		private Vector3 <startPos>5__6; // 0x58
		private Vector3 <endPos>5__7; // 0x64

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveCamera>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807747C0-0x0000000180775830
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180775830-0x0000000180777100
	}

	// Constructors
	public SocialExpanseDigSpot(); // 0x00000001807728E0-0x0000000180772960

	// Methods
	private void Start(); // 0x00000001807727C0-0x00000001807728E0
	private void OnDestroy(); // 0x0000000180772150-0x0000000180772250
	private void OnSocialExpanseStart(SocialExpanseStartupMessage inMessage); // 0x0000000180772560-0x0000000180772670
	private void OnInteractableInteracted(InteractableInteractedMessage inMessage); // 0x0000000180772250-0x0000000180772560
	[IteratorStateMachine] // 0x00000001801DAA60-0x00000001801DAAB0
	private IEnumerator AlignToDigSpot(); // 0x0000000180771EA0-0x0000000180771F00
	[IteratorStateMachine] // 0x00000001801DAD50-0x00000001801DADA0
	private IEnumerator MoveCamera(bool inActivate); // 0x00000001807720E0-0x0000000180772150
	private void Interrupted(); // 0x0000000180771F00-0x00000001807720E0
	private void PlayDigFX(bool inPlay); // 0x0000000180772670-0x00000001807727C0
}

