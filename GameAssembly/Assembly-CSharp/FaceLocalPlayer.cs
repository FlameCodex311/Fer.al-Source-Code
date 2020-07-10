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

public class FaceLocalPlayer : ManagedBehaviour // TypeDefIndex: 10434
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <UseHeadOnly>k__BackingField; // 0x50
	private bool _ignoreRange; // 0x51
	private Transform _headNode; // 0x58
	private Transform _target; // 0x60
	[Header] // 0x00000001800F5540-0x00000001800F5590
	[SerializeField] // 0x00000001800F5540-0x00000001800F5590
	private float _bodyFacePlayerRange; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _bodyRotationSpeed; // 0x6C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _allowBodyPitch; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _bodyPitchDegreeLimit; // 0x74
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _facingAngleLimit; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _facePlayerCamera; // 0x7C
	[Header] // 0x0000000180111040-0x0000000180111090
	[SerializeField] // 0x0000000180111040-0x0000000180111090
	private string _neckNodeName; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _neckRotationSpeed; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _allowNeckPitch; // 0x8C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _neckPitchDegreeLimit; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _neckFacingAngleLimit; // 0x94

	// Properties
	public Transform Target { set; } // 0x000000018148F3F0-0x000000018148F4A0
	internal bool UseHeadOnly { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180619B50-0x0000000180619B60 0x0000000180639DF0-0x0000000180639E00

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForAvatarLocal>d__21 : IEnumerator<object> // TypeDefIndex: 10435
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForAvatarLocal>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814AB580-0x00000001814AB620
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814AB620-0x00000001814AB670
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForCameraLocal>d__22 : IEnumerator<object> // TypeDefIndex: 10436
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForCameraLocal>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814AB670-0x00000001814AB730
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814AB730-0x00000001814AB780
	}

	// Constructors
	public FaceLocalPlayer(); // 0x000000018148F350-0x000000018148F3F0

	// Methods
	public override void MStart(); // 0x000000018148E9C0-0x000000018148EB50
	[IteratorStateMachine] // 0x0000000180111A60-0x0000000180111AB0
	private IEnumerator WaitForAvatarLocal(); // 0x000000018148F2B0-0x000000018148F300
	[IteratorStateMachine] // 0x0000000180111C20-0x0000000180111C70
	private IEnumerator WaitForCameraLocal(); // 0x000000018148F300-0x000000018148F350
	public override void MUpdate(); // 0x000000018148EB50-0x000000018148F1E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MStart>b__20_0(QRoutine cb); // 0x000000018148F1E0-0x000000018148F250
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MStart>b__20_1(QRoutine cb); // 0x000000018148F250-0x000000018148F2B0
}

