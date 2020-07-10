/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Teleporter : ManagedBehaviour // TypeDefIndex: 10650
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _teleportTo; // 0x50
	private float _fadeOutTime; // 0x58
	private float _fadeWaitTime; // 0x5C
	private float _fadeInTime; // 0x60
	public static bool teleporting; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Teleport>d__6 : IEnumerator<object> // TypeDefIndex: 10651
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Teleporter <>4__this; // 0x20
		private CinemachineBlendDefinition <cBlend>5__2; // 0x28
		private CinemachineBlendDefinition.Style <cPriorStyle>5__3; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Teleport>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812129C0-0x0000000181213060
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181213060-0x00000001812130B0
	}

	// Constructors
	public Teleporter(); // 0x0000000181209820-0x0000000181209890
	static Teleporter(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	private void OnTriggerEnter(Collider inCollider); // 0x0000000181209690-0x00000001812097C0
	[IteratorStateMachine] // 0x0000000180160CA0-0x0000000180160CF0
	private IEnumerator Teleport(); // 0x00000001812097C0-0x0000000181209820
	private void FadeToBlack(float inTime = 1f /* Metadata: 0x00781EE8 */); // 0x0000000180E24F40-0x0000000180E24F50
	private void FadeToGame(float inTime = 1f /* Metadata: 0x00781EEC */); // 0x0000000180E24F50-0x0000000180E24F60
	public override void MOnDestroy(); // 0x0000000181209610-0x0000000181209690
}

