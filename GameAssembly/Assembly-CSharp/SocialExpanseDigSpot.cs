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

public class SocialExpanseDigSpot : MonoBehaviour // TypeDefIndex: 11708
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

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AlignToDigSpot>d__16 : IEnumerator<object> // TypeDefIndex: 11709
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AlignToDigSpot>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018135E2E0-0x000000018135E7D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018135E7D0-0x000000018135E9F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveCamera>d__17 : IEnumerator<object> // TypeDefIndex: 11710
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveCamera>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018135F050-0x0000000181360010
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181360010-0x0000000181360270
	}

	// Constructors
	public SocialExpanseDigSpot(); // 0x000000018135BED0-0x000000018135BF50

	// Methods
	private void Start(); // 0x000000018135BDC0-0x000000018135BED0
	private void OnDestroy(); // 0x000000018135B780-0x000000018135B880
	private void OnSocialExpanseStart(SocialExpanseStartupMessage inMessage); // 0x000000018135BB30-0x000000018135BC60
	private void OnInteractableInteracted(InteractableInteractedMessage inMessage); // 0x000000018135B880-0x000000018135BB30
	[IteratorStateMachine] // 0x00000001801009A0-0x00000001801009F0
	private IEnumerator AlignToDigSpot(); // 0x000000018135B660-0x000000018135B6C0
	[IteratorStateMachine] // 0x0000000180100BC0-0x0000000180100C10
	private IEnumerator MoveCamera(bool inActivate); // 0x000000018135B710-0x000000018135B780
	private void Interrupted(); // 0x000000018135B6C0-0x000000018135B710
	private void PlayDigFX(bool inPlay); // 0x000000018135BC60-0x000000018135BDC0
}

