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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Teleporter : ManagedBehaviour // TypeDefIndex: 12153
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _teleportTo; // 0x50
	private float _fadeOutTime; // 0x58
	private float _fadeWaitTime; // 0x5C
	private float _fadeInTime; // 0x60
	public static bool teleporting; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Teleport>d__6 : IEnumerator<object> // TypeDefIndex: 12154
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Teleporter <>4__this; // 0x20
		public WorldMapLocation inWorldMapLocation; // 0x28
		private CinemachineBlendDefinition <cBlend>5__2; // 0x30
		private CinemachineBlendDefinition.Style <cPriorStyle>5__3; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Teleport>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180961BE0-0x0000000180962210
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180962210-0x0000000180962260
	}

	// Constructors
	public Teleporter(); // 0x0000000180959B10-0x0000000180959B80
	static Teleporter(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	private void OnTriggerEnter(Collider inCollider); // 0x00000001809598B0-0x0000000180959AA0
	[IteratorStateMachine] // 0x000000018023FAC0-0x000000018023FB10
	private IEnumerator Teleport(WorldMapLocation inWorldMapLocation); // 0x0000000180959AA0-0x0000000180959B10
	private void FadeToBlack(float inTime = 1f /* Metadata: 0x007B95AB */); // 0x0000000180463680-0x0000000180463690
	private void FadeToGame(float inTime = 1f /* Metadata: 0x007B95AF */); // 0x0000000180463690-0x00000001804636A0
	public override void MOnDestroy(); // 0x0000000180959830-0x00000001809598B0
}

