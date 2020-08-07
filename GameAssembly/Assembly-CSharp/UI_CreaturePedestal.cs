/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CreaturePedestal : MonoBehaviour // TypeDefIndex: 13875
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _loadingGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _spinGroup; // 0x28
	private ActorBase _spawnedCreature; // 0x30
	private CreatureCustomizationTarget _creatureCustomizationTarget; // 0x38
	private Waiter _loadWaiter; // 0x40

	// Properties
	public Transform SpinGroup { get; } // 0x00000001803745B0-0x00000001803745C0 
	public ActorBase SpawnedAvatar { get; } // 0x00000001803745C0-0x00000001803745D0 
	public CreatureCustomizationTarget CreatureCustomizationTarget { get; } // 0x00000001803743D0-0x00000001803743E0 
	public Transform FallbackCameraTarget { get; } // 0x000000018054C7B0-0x000000018054C7D0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 13876
	{
		// Fields
		public UI_CreaturePedestal <>4__this; // 0x10
		public CreatureCustomizationTarget inTarget; // 0x18
		public Action<ActorBase> inOnCreatureLoaded; // 0x20
		public Action<GameObject, ActorInfo> <>9__2; // 0x28

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetTarget>b__0(); // 0x000000018053D000-0x000000018053D2A0
		internal void <SetTarget>b__2(GameObject inActorBase, ActorInfo _actorInfo); // 0x000000018053D2A0-0x000000018053D550
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_1 // TypeDefIndex: 13877
	{
		// Fields
		public ActorBase oldCreature; // 0x10

		// Constructors
		public <>c__DisplayClass13_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetTarget>b__1(); // 0x000000018053D880-0x000000018053D8F0
	}

	// Constructors
	public UI_CreaturePedestal(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void SetTarget(CreatureCustomizationTarget inTarget, Action<ActorBase> inOnCreatureLoaded = null); // 0x000000018054C2B0-0x000000018054C500
	public void Hide(); // 0x000000018054C1E0-0x000000018054C2B0
	private void Update(); // 0x000000018054C500-0x000000018054C7B0
}

