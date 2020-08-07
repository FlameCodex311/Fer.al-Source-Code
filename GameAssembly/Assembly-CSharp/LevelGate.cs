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

[RequireComponent] // 0x000000018023B170-0x000000018023B1E0
public class LevelGate : ManagedBehaviour // TypeDefIndex: 12148
{
	// Fields
	[Header] // 0x000000018023B310-0x000000018023B390
	[RootSelector] // 0x000000018023B310-0x000000018023B390
	public string toLevelID; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LevelGateType type; // 0x58
	[Header] // 0x000000018023B650-0x000000018023B6A0
	[SerializeField] // 0x000000018023B650-0x000000018023B6A0
	private float _range; // 0x5C
	private float? _rangeSq; // 0x60
	private bool _particlesEnabled; // 0x68
	private float _particleDotLimit; // 0x6C
	[Header] // 0x000000018023B9E0-0x000000018023BA60
	[RootSelector] // 0x000000018023B9E0-0x000000018023BA60
	public string doorFxBundleId; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _fxSpawnPoint; // 0x78
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public List<ParticleSystem> doorParticles; // 0x80
	[Header] // 0x000000018023D010-0x000000018023D060
	[SerializeField] // 0x000000018023D010-0x000000018023D060
	private List<GameObject> gateEnabledObjects; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<GameObject> gateDisabledObjects; // 0x90
	[Header] // 0x00000001801D46E0-0x00000001801D4710
	public Transform returnSpawnPoint; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform exitSpawnPoint; // 0xA0
	public List<Transform> returnSpawnDestinations; // 0xA8
	private bool _nextTriggerSkip; // 0xB0
	private LevelDefComponent _levelDef; // 0xB8

	// Properties
	public float rangeSq { get; } // 0x000000018087FB00-0x000000018087FB70 
	public Transform fxSpawnPoint { get; } // 0x000000018087FA60-0x000000018087FB00 
	public bool NextTriggerSkip { get; set; } // 0x000000018087FA50-0x000000018087FA60 0x000000018087FB70-0x000000018087FB80
	private LevelDefComponent LevelDef { get; } // 0x000000018087F930-0x000000018087FA50 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DelayBeforeLoadingLevelForExitAnimation>d__29 : IEnumerator<object> // TypeDefIndex: 12149
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float inDelay; // 0x20
		public LevelGate <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DelayBeforeLoadingLevelForExitAnimation>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5AB00-0x0000000180C5ABC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5ABC0-0x0000000180C5AC10
	}

	// Constructors
	public LevelGate(); // 0x000000018087F860-0x000000018087F930

	// Methods
	private void OnDrawGizmos(); // 0x000000018087E7A0-0x000000018087F610
	public override void MStartAfterLocal(); // 0x000000018087DB20-0x000000018087E1D0
	private void OnTriggerEnter(Collider inCollider); // 0x000000018087F610-0x000000018087F7D0
	public void ExitToLevel(); // 0x000000018087D7F0-0x000000018087DA00
	[IteratorStateMachine] // 0x000000018023D560-0x000000018023D5B0
	private IEnumerator DelayBeforeLoadingLevelForExitAnimation(float inDelay = 0f /* Metadata: 0x007B95A7 */); // 0x000000018087D570-0x000000018087D5F0
	public void LoadLevel(); // 0x000000018087DA00-0x000000018087DB20
	public override void MUpdate(); // 0x000000018087E1D0-0x000000018087E7A0
	private void EnableParticles(); // 0x000000018087D6B0-0x000000018087D7F0
	private void DisableParticles(); // 0x000000018087D5F0-0x000000018087D6B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MStartAfterLocal>b__26_0(GameObject gFX); // 0x000000018087F7D0-0x000000018087F860
}

