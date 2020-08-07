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

public class ScaleWhenLocalPlayerClose : ManagedBehaviour // TypeDefIndex: 13396
{
	// Fields
	private Transform _target; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioScaleUp; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioScaleDown; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioScaledUpLoop; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioScaledDownLoop; // 0x70
	[Header] // 0x00000001802258E0-0x0000000180225950
	[SerializeField] // 0x00000001802258E0-0x0000000180225950
	[Tooltip] // 0x00000001802258E0-0x0000000180225950
	private float _distance; // 0x78
	[Header] // 0x0000000180225BC0-0x0000000180225C30
	[SerializeField] // 0x0000000180225BC0-0x0000000180225C30
	[Tooltip] // 0x0000000180225BC0-0x0000000180225C30
	private float _scaleToWithinDistance; // 0x7C
	[SerializeField] // 0x0000000180226050-0x00000001802260A0
	[Tooltip] // 0x0000000180226050-0x00000001802260A0
	private float _scaleTimeWithinDistance; // 0x80
	[Header] // 0x00000001802262F0-0x0000000180226360
	[SerializeField] // 0x00000001802262F0-0x0000000180226360
	[Tooltip] // 0x00000001802262F0-0x0000000180226360
	private float _scaleToOutsideDistance; // 0x84
	[SerializeField] // 0x0000000180226050-0x00000001802260A0
	[Tooltip] // 0x0000000180226050-0x00000001802260A0
	private float _scaleTimeOutsideDistance; // 0x88
	private bool? _withinRange; // 0x8C

	// Properties
	public bool? withinRange { get; } // 0x00000001803FA7A0-0x00000001803FA7B0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForAvatarLocal>d__14 : IEnumerator<object> // TypeDefIndex: 13397
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForAvatarLocal>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180406020-0x00000001804060C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804060C0-0x0000000180406420
	}

	// Constructors
	public ScaleWhenLocalPlayerClose(); // 0x00000001803FA720-0x00000001803FA7A0

	// Methods
	public override void MStart(); // 0x00000001803FA0D0-0x00000001803FA1B0
	[IteratorStateMachine] // 0x0000000180226770-0x00000001802267C0
	private IEnumerator WaitForAvatarLocal(); // 0x00000001803FA6D0-0x00000001803FA720
	public override void MUpdate(); // 0x00000001803FA1B0-0x00000001803FA330
	private void Scale(float inScale, float inTimer); // 0x00000001803FA330-0x00000001803FA5D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MStart>b__13_0(QRoutine cb); // 0x00000001803FA5D0-0x00000001803FA630
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 <Scale>b__16_0(); // 0x00000001803FA630-0x00000001803FA680
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Scale>b__16_1(Vector3 x); // 0x00000001803FA680-0x00000001803FA6D0
}

