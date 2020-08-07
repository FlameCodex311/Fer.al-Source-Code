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

public class TerraceTreasurePuzzle : ManagedBehaviour // TypeDefIndex: 14290
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <finalTreasure>d__21 : IEnumerator<object> // TypeDefIndex: 14291
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TerraceTreasurePuzzle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <finalTreasure>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001809628A0-0x0000000180962A50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180962A50-0x0000000180962AA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ResetGame>d__23 : IEnumerator<object> // TypeDefIndex: 14292
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TerraceTreasurePuzzle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ResetGame>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180961680-0x0000000180961B90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180961B90-0x0000000180961BE0
	}

	// Constructors
	public TerraceTreasurePuzzle(); // 0x000000018095EF10-0x000000018095EF70

	// Methods
	public override void MStart(); // 0x000000018095A700-0x000000018095A810
	[IteratorStateMachine] // 0x00000001802097A0-0x00000001802097F0
	public IEnumerator finalTreasure(); // 0x000000018095EF70-0x000000018095EFD0
	public void BlockMoveUp(GameObject blockMove); // 0x0000000180959FF0-0x000000018095A100
	[IteratorStateMachine] // 0x0000000180209A40-0x0000000180209A90
	public IEnumerator ResetGame(); // 0x000000018095EE40-0x000000018095EEA0
	public void CheckTreasure(); // 0x000000018095A100-0x000000018095A620
	public void EndGame(); // 0x000000018095A620-0x000000018095A700
	public void BlockDisabler(GameObject[] obj, int startVal, int endVal); // 0x0000000180959F00-0x0000000180959FF0
	public void ParticleDisabler(GameObject[] obj, int startVal); // 0x000000018095EDA0-0x000000018095EE40
	public void WaterLevelReset(GameObject[] watObj, int starVal); // 0x000000018095EEA0-0x000000018095EF10
	public override void MUpdate(); // 0x000000018095A810-0x000000018095EDA0
}

