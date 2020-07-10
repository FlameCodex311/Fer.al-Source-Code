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

public class TerraceTreasurePuzzle : ManagedBehaviour // TypeDefIndex: 12718
{
	// Fields
	public CinemachineVirtualCamera virtualStartCam; // 0x50
	public Color activeColor; // 0x58
	public GameObject correctFX; // 0x68
	public GameObject[] blocks; // 0x70
	public GameObject[] waterLevels; // 0x78
	public GameObject[] waterParticles; // 0x80
	public GameObject[] treasureWater; // 0x88
	public GameObject startBlock; // 0x90
	public GameObject endBlock; // 0x98
	public float moveDuration; // 0xA0
	public float waitTime; // 0xA4
	private Camera _camera; // 0xA8
	private int _defaultLayerMask; // 0xB0
	private bool _treasure1; // 0xB4
	private bool _treasure2; // 0xB5
	private bool _treasure3; // 0xB6
	private bool _treasure4; // 0xB7
	private bool _treasure5; // 0xB8
	private bool _treasure6; // 0xB9
	private bool _treasure7; // 0xBA

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <finalTreasure>d__21 : IEnumerator<object> // TypeDefIndex: 12719
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TerraceTreasurePuzzle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <finalTreasure>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812138B0-0x0000000181213A70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181213A70-0x0000000181213AC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ResetGame>d__23 : IEnumerator<object> // TypeDefIndex: 12720
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TerraceTreasurePuzzle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ResetGame>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181212410-0x0000000181212970
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181212970-0x00000001812129C0
	}

	// Constructors
	public TerraceTreasurePuzzle(); // 0x000000018120EF90-0x000000018120EFF0

	// Methods
	public override void MStart(); // 0x000000018120A450-0x000000018120A570
	[IteratorStateMachine] // 0x0000000180119990-0x00000001801199E0
	public IEnumerator finalTreasure(); // 0x000000018120EFF0-0x000000018120F050
	public void BlockMoveUp(GameObject blockMove); // 0x0000000181209CF0-0x0000000181209E10
	[IteratorStateMachine] // 0x0000000180119BA0-0x0000000180119BF0
	public IEnumerator ResetGame(); // 0x000000018120EEB0-0x000000018120EF10
	public void CheckTreasure(); // 0x0000000181209E10-0x000000018120A370
	public void EndGame(); // 0x000000018120A370-0x000000018120A450
	public void BlockDisabler(GameObject[] obj, int startVal, int endVal); // 0x0000000181209BF0-0x0000000181209CF0
	public void ParticleDisabler(GameObject[] obj, int startVal); // 0x000000018120EE10-0x000000018120EEB0
	public void WaterLevelReset(GameObject[] watObj, int starVal); // 0x000000018120EF10-0x000000018120EF90
	public override void MUpdate(); // 0x000000018120A570-0x000000018120EE10
}

