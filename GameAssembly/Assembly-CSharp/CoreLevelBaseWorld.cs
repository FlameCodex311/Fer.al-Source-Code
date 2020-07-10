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

public class CoreLevelBaseWorld : CoreLevelBase // TypeDefIndex: 13425
{
	// Fields
	[Header] // 0x0000000180151BC0-0x0000000180151BF0
	public List<Transform> spawnPoints; // 0x20
	public Vector2 randomSpawnPointRange; // 0x28
	[Header] // 0x0000000180151CB0-0x0000000180151CE0
	public float localMoverMaxSpeedMultiplier; // 0x30
	[Header] // 0x0000000180105A30-0x0000000180105A60
	public PlayerCameraMode defaultPlayerCameraMode; // 0x34
	[Header] // 0x0000000180152040-0x0000000180152070
	public bool useCameraOptions; // 0x38
	public PlayerCameraOptions_CM cameraOptions; // 0x40

	// Properties
	public PlayerCameraOptions_CM CameraOptions { get; } // 0x00000001813125A0-0x00000001813125B0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitFromManager>d__9 : IEnumerator<object> // TypeDefIndex: 13426
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreLevelBaseWorld <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitFromManager>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181327EA0-0x0000000181328F50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181328F50-0x0000000181328FA0
	}

	// Constructors
	public CoreLevelBaseWorld(); // 0x00000001813124D0-0x00000001813125A0

	// Methods
	private void OnDrawGizmos(); // 0x00000001813121E0-0x00000001813124D0
	[IteratorStateMachine] // 0x0000000180152260-0x00000001801522B0
	public override IEnumerator InitFromManager(); // 0x0000000181312180-0x00000001813121E0
}

