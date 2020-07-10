/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CreaturePedestal : MonoBehaviour // TypeDefIndex: 12291
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _loadingGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _spinGroup; // 0x28
	private ActorBase _spawnedCreature; // 0x30
	private CreatureCustomizationTarget _creatureCustomizationTarget; // 0x38
	private Waiter _loadWaiter; // 0x40

	// Properties
	public Transform SpinGroup { get; } // 0x0000000180369B60-0x0000000180369B70 
	public ActorBase SpawnedAvatar { get; } // 0x0000000180397720-0x0000000180397730 
	public CreatureCustomizationTarget CreatureCustomizationTarget { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public Transform FallbackCameraTarget { get; } // 0x0000000180F2F040-0x0000000180F2F060 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 12292
	{
		// Fields
		public UI_CreaturePedestal <>4__this; // 0x10
		public CreatureCustomizationTarget inTarget; // 0x18
		public Action<ActorBase> inOnCreatureLoaded; // 0x20
		public Action<GameObject, ActorInfo> <>9__2; // 0x28

		// Constructors
		public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetTarget>b__0(); // 0x0000000180F1F0A0-0x0000000180F1F350
		internal void <SetTarget>b__2(GameObject inActorBase, ActorInfo _actorInfo); // 0x0000000180F1F350-0x0000000180F1F610
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_1 // TypeDefIndex: 12293
	{
		// Fields
		public ActorBase oldCreature; // 0x10

		// Constructors
		public <>c__DisplayClass13_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetTarget>b__1(); // 0x0000000180F1F940-0x0000000180F1F9B0
	}

	// Constructors
	public UI_CreaturePedestal(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void SetTarget(CreatureCustomizationTarget inTarget, Action<ActorBase> inOnCreatureLoaded = null); // 0x0000000180F2EB30-0x0000000180F2ED80
	public void Hide(); // 0x0000000180F2EA50-0x0000000180F2EB30
	private void Update(); // 0x0000000180F2ED80-0x0000000180F2F040
}

