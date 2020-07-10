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

public class ScaleWhenLocalPlayerClose : ManagedBehaviour // TypeDefIndex: 11860
{
	// Fields
	private Transform _target; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioScaleUp; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioScaleDown; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioScaledUpLoop; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioScaledDownLoop; // 0x70
	[Header] // 0x000000018013EA20-0x000000018013EA90
	[SerializeField] // 0x000000018013EA20-0x000000018013EA90
	[Tooltip] // 0x000000018013EA20-0x000000018013EA90
	private float _distance; // 0x78
	[Header] // 0x000000018013EC60-0x000000018013ECD0
	[SerializeField] // 0x000000018013EC60-0x000000018013ECD0
	[Tooltip] // 0x000000018013EC60-0x000000018013ECD0
	private float _scaleToWithinDistance; // 0x7C
	[SerializeField] // 0x000000018013EE40-0x000000018013EE90
	[Tooltip] // 0x000000018013EE40-0x000000018013EE90
	private float _scaleTimeWithinDistance; // 0x80
	[Header] // 0x000000018013EF30-0x000000018013EFA0
	[SerializeField] // 0x000000018013EF30-0x000000018013EFA0
	[Tooltip] // 0x000000018013EF30-0x000000018013EFA0
	private float _scaleToOutsideDistance; // 0x84
	[SerializeField] // 0x000000018013EE40-0x000000018013EE90
	[Tooltip] // 0x000000018013EE40-0x000000018013EE90
	private float _scaleTimeOutsideDistance; // 0x88
	private bool? _withinRange; // 0x8C

	// Properties
	public bool? withinRange { get; } // 0x00000001804EB030-0x00000001804EB040 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForAvatarLocal>d__14 : IEnumerator<object> // TypeDefIndex: 11861
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForAvatarLocal>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EC9130-0x0000000180EC91D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EC91D0-0x0000000180EC9220
	}

	// Constructors
	public ScaleWhenLocalPlayerClose(); // 0x0000000181371960-0x00000001813719E0

	// Methods
	public override void MStart(); // 0x0000000181371310-0x00000001813713F0
	[IteratorStateMachine] // 0x000000018013F510-0x000000018013F560
	private IEnumerator WaitForAvatarLocal(); // 0x0000000181371910-0x0000000181371960
	public override void MUpdate(); // 0x00000001813713F0-0x0000000181371570
	private void Scale(float inScale, float inTimer); // 0x0000000181371570-0x0000000181371810
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MStart>b__13_0(QRoutine cb); // 0x0000000181371810-0x0000000181371870
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 <Scale>b__16_0(); // 0x0000000181371870-0x00000001813718C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Scale>b__16_1(Vector3 x); // 0x00000001813718C0-0x0000000181371910
}

