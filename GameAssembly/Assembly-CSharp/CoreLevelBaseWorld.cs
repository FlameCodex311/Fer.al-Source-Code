﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreLevelBaseWorld : CoreLevelBase // TypeDefIndex: 11096
{
	// Fields
	[Header] // 0x0000000180233190-0x00000001802331C0
	public List<Transform> spawnPoints; // 0x20
	public Vector2 randomSpawnPointRange; // 0x28
	[Header] // 0x0000000180233350-0x0000000180233380
	public float localMoverMaxSpeedMultiplier; // 0x30
	[Header] // 0x00000001802336F0-0x0000000180233720
	public PlayerCameraMode defaultPlayerCameraMode; // 0x34
	[Header] // 0x0000000180233900-0x0000000180233930
	public bool useCameraOptions; // 0x38
	public PlayerCameraOptions_CM cameraOptions; // 0x40

	// Properties
	public PlayerCameraOptions_CM CameraOptions { get; } // 0x0000000180A6CB50-0x0000000180A6CB60 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitFromManager>d__9 : IEnumerator<object> // TypeDefIndex: 11097
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform tSpawnPoint; // 0x20
		public CoreLevelBaseWorld <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitFromManager>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A78E20-0x0000000180A79170
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A79170-0x0000000180A791C0
	}

	// Constructors
	public CoreLevelBaseWorld(); // 0x0000000180A6CA80-0x0000000180A6CB50

	// Methods
	private void OnDrawGizmos(); // 0x0000000180A6C7A0-0x0000000180A6CA80
	[IteratorStateMachine] // 0x0000000180233BD0-0x0000000180233C20
	public override IEnumerator InitFromManager(Transform tSpawnPoint = null); // 0x0000000180A6C730-0x0000000180A6C7A0
}

