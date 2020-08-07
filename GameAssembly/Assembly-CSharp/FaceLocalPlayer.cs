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

public class FaceLocalPlayer : ManagedBehaviour // TypeDefIndex: 11944
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <UseHeadOnly>k__BackingField; // 0x50
	private bool _ignoreRange; // 0x51
	private Transform _headNode; // 0x58
	private Transform _target; // 0x60
	[Header] // 0x00000001801DACB0-0x00000001801DAD00
	[SerializeField] // 0x00000001801DACB0-0x00000001801DAD00
	private float _bodyFacePlayerRange; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _bodyRotationSpeed; // 0x6C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _allowBodyPitch; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _bodyPitchDegreeLimit; // 0x74
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _facingAngleLimit; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _facePlayerCamera; // 0x7C
	[Header] // 0x00000001801ED7D0-0x00000001801ED820
	[SerializeField] // 0x00000001801ED7D0-0x00000001801ED820
	private string _neckNodeName; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _neckRotationSpeed; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _allowNeckPitch; // 0x8C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _neckPitchDegreeLimit; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _neckFacingAngleLimit; // 0x94

	// Properties
	public Transform Target { set; } // 0x0000000180866DA0-0x0000000180866E50
	internal bool UseHeadOnly { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379EC0-0x0000000180379ED0 0x000000018047A1C0-0x000000018047A1D0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForAvatarLocal>d__21 : IEnumerator<object> // TypeDefIndex: 11945
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForAvatarLocal>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018086C660-0x000000018086C700
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018086C700-0x000000018086C750
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForCameraLocal>d__22 : IEnumerator<object> // TypeDefIndex: 11946
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForCameraLocal>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018086C750-0x000000018086C810
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018086C810-0x000000018086C860
	}

	// Constructors
	public FaceLocalPlayer(); // 0x0000000180866D00-0x0000000180866DA0

	// Methods
	public override void MStart(); // 0x0000000180866380-0x0000000180866510
	[IteratorStateMachine] // 0x00000001801EE1A0-0x00000001801EE1F0
	private IEnumerator WaitForAvatarLocal(); // 0x0000000180866C60-0x0000000180866CB0
	[IteratorStateMachine] // 0x00000001801EE410-0x00000001801EE460
	private IEnumerator WaitForCameraLocal(); // 0x0000000180866CB0-0x0000000180866D00
	public override void MUpdate(); // 0x0000000180866510-0x0000000180866B90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MStart>b__20_0(QRoutine cb); // 0x0000000180866B90-0x0000000180866C00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MStart>b__20_1(QRoutine cb); // 0x0000000180866C00-0x0000000180866C60
}

