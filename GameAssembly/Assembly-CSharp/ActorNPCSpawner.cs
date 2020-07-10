/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ActorNPCSpawner : ManagedBehaviour // TypeDefIndex: 10024
{
	// Fields
	private Animator _animator; // 0x50
	private ActorBase _actorBase; // 0x58
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static GameObject <CullingPointOverride>k__BackingField; // 0x00
	[RootSelector] // 0x000000018012D9C0-0x000000018012DA20
	public string actorPrefabDefID; // 0x60
	[RootSelector] // 0x000000018012DAA0-0x000000018012DB00
	public string actorNPCDefID; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private MinimapManager.EBlipType _minimapBlipType; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _minimapBlipForceDisplayOnExpandedMap; // 0x74
	private MinimapBlip _minimapBlip; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _facePlayer; // 0x80
	public LoadType loadType; // 0x84
	[InspectorDisableOrHideByValue] // 0x00000001801377F0-0x0000000180137840
	[SerializeField] // 0x00000001801377F0-0x0000000180137840
	private float _customLoadDistance; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool waitForLocalPlayerToLoad; // 0x8C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _npcBubbleIgnoreCollisionOverride; // 0x8D
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useIdleBreaks; // 0x8E
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject <actorSpawned>k__BackingField; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent OnLoaded; // 0x98
	private bool _instantiating; // 0xA0
	private bool _instantiated; // 0xA1
	private bool _isVisible; // 0xA2
	private bool _isMoving; // 0xA3
	private static RaycastHit[] _visibilityHitsNoAlloc; // 0x08

	// Properties
	public Animator Animator { get; } // 0x000000018140F810-0x000000018140F890 
	public ActorBase ActorBase { get; } // 0x000000018140F790-0x000000018140F810 
	public static GameObject CullingPointOverride { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018140F890-0x000000018140F950 0x000000018140F9C0-0x000000018140FA20
	public GameObject actorSpawned { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180382A80-0x0000000180382A90 0x000000018049D4D0-0x000000018049D4E0
	private bool IsAlwaysLoadType { get; } // 0x000000018140F950-0x000000018140F960 
	private bool IsCustomLoadType { get; } // 0x000000018140F960-0x000000018140F970 
	private float LoadDistance { get; } // 0x000000018140F970-0x000000018140F9C0 

	// Nested types
	[Serializable]
	public enum LoadType // TypeDefIndex: 10025
	{
		Always = 0,
		Far = 10,
		Close = 20,
		Custom = 30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <VisibilityRoutine>d__43 : IEnumerator<object> // TypeDefIndex: 10026
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorNPCSpawner <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <VisibilityRoutine>d__43(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018141D0A0-0x000000018141D370
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018141D370-0x0000000181423710
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass44_0 // TypeDefIndex: 10027
	{
		// Fields
		public ActorNPCSpawner <>4__this; // 0x10
		public BaseDef npcDef; // 0x18

		// Constructors
		public <>c__DisplayClass44_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <InstantiateActor>b__0(GameObject inGameObject, ActorInfo inInfo); // 0x000000018141CA10-0x000000018141CEE0
	}

	// Constructors
	public ActorNPCSpawner(); // 0x000000018140F710-0x000000018140F790
	static ActorNPCSpawner(); // 0x000000018140F6B0-0x000000018140F710

	// Methods
	public override void MStart(); // 0x000000018140EE90-0x000000018140EEB0
	public override void MStartAfterLocal(); // 0x000000018140EE70-0x000000018140EE90
	private void Init(); // 0x000000018140E9B0-0x000000018140EB40
	private Transform RaycastToCameraHitSomething(); // 0x000000018140F180-0x000000018140F4F0
	internal void SetMoving(bool inMoving); // 0x000000018140F4F0-0x000000018140F650
	[IteratorStateMachine] // 0x00000001801381D0-0x0000000180138220
	private IEnumerator VisibilityRoutine(); // 0x000000018140F650-0x000000018140F6B0
	private void InstantiateActor(); // 0x000000018140EB40-0x000000018140EE70
	private void OnDrawGizmosSelected(); // 0x000000018140EEB0-0x000000018140F180
}

