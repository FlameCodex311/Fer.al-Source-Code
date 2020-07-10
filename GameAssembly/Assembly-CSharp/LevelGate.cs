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

[RequireComponent] // 0x000000018015ACF0-0x000000018015AD60
public class LevelGate : ManagedBehaviour // TypeDefIndex: 10645
{
	// Fields
	[Header] // 0x000000018015AF70-0x000000018015AFF0
	[RootSelector] // 0x000000018015AF70-0x000000018015AFF0
	public string toLevelID; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LevelGateType type; // 0x58
	[Header] // 0x000000018015B340-0x000000018015B390
	[SerializeField] // 0x000000018015B340-0x000000018015B390
	private float _range; // 0x5C
	private float? _rangeSq; // 0x60
	private bool _particlesEnabled; // 0x68
	private float _particleDotLimit; // 0x6C
	[Header] // 0x000000018015B870-0x000000018015B8F0
	[RootSelector] // 0x000000018015B870-0x000000018015B8F0
	public string doorFxBundleId; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _fxSpawnPoint; // 0x78
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public List<ParticleSystem> doorParticles; // 0x80
	[Header] // 0x000000018015C030-0x000000018015C080
	[SerializeField] // 0x000000018015C030-0x000000018015C080
	private List<GameObject> gateEnabledObjects; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<GameObject> gateDisabledObjects; // 0x90
	[Header] // 0x0000000180100D40-0x0000000180100D70
	public Transform returnSpawnPoint; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform exitSpawnPoint; // 0xA0
	public List<Transform> returnSpawnDestinations; // 0xA8
	private bool _nextTriggerSkip; // 0xB0
	private LevelDefComponent _levelDef; // 0xB8

	// Properties
	public float rangeSq { get; } // 0x00000001812D09B0-0x00000001812D0A20 
	public Transform fxSpawnPoint { get; } // 0x00000001812D0910-0x00000001812D09B0 
	public bool NextTriggerSkip { get; set; } // 0x0000000180DD1FF0-0x0000000180DD2000 0x0000000180DD2170-0x0000000180DD2180
	private LevelDefComponent LevelDef { get; } // 0x00000001812D07F0-0x00000001812D0910 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DelayBeforeLoadingLevelForExitAnimation>d__29 : IEnumerator<object> // TypeDefIndex: 10646
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float inDelay; // 0x20
		public LevelGate <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DelayBeforeLoadingLevelForExitAnimation>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812D4E90-0x00000001812D5060
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812D5060-0x00000001812D5230
	}

	// Constructors
	public LevelGate(); // 0x00000001812D0720-0x00000001812D07F0

	// Methods
	private void OnDrawGizmos(); // 0x00000001812CF600-0x00000001812D04D0
	public override void MStartAfterLocal(); // 0x00000001812CE940-0x00000001812CF010
	private void OnTriggerEnter(Collider inCollider); // 0x00000001812D04D0-0x00000001812D0690
	public void ExitToLevel(); // 0x00000001812CE610-0x00000001812CE820
	[IteratorStateMachine] // 0x000000018015C990-0x000000018015C9E0
	private IEnumerator DelayBeforeLoadingLevelForExitAnimation(float inDelay = 0f /* Metadata: 0x00781EE4 */); // 0x00000001812CE390-0x00000001812CE400
	public void LoadLevel(); // 0x00000001812CE820-0x00000001812CE940
	public override void MUpdate(); // 0x00000001812CF010-0x00000001812CF600
	private void EnableParticles(); // 0x00000001812CE4D0-0x00000001812CE610
	private void DisableParticles(); // 0x00000001812CE400-0x00000001812CE4D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MStartAfterLocal>b__26_0(GameObject gFX); // 0x00000001812D0690-0x00000001812D0720
}

