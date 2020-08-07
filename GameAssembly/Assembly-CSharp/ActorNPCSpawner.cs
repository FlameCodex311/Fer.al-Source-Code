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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ActorNPCSpawner : ManagedBehaviour // TypeDefIndex: 11515
{
	// Fields
	private Animator _animator; // 0x50
	private ActorBase _actorBase; // 0x58
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static GameObject <CullingPointOverride>k__BackingField; // 0x00
	[RootSelector] // 0x0000000180202990-0x00000001802029F0
	public string actorPrefabDefID; // 0x60
	[RootSelector] // 0x0000000180202CF0-0x0000000180202D50
	public string actorNPCDefID; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private MinimapManager.EBlipType _minimapBlipType; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _minimapBlipForceDisplayOnExpandedMap; // 0x74
	private MinimapBlip _minimapBlip; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _facePlayer; // 0x80
	public LoadType loadType; // 0x84
	[InspectorDisableOrHideByValue] // 0x0000000180210320-0x0000000180210370
	[SerializeField] // 0x0000000180210320-0x0000000180210370
	private float _customLoadDistance; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool waitForLocalPlayerToLoad; // 0x8C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _npcBubbleIgnoreCollisionOverride; // 0x8D
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useIdleBreaks; // 0x8E
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject <actorSpawned>k__BackingField; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent OnLoaded; // 0x98
	private bool _instantiating; // 0xA0
	private bool _instantiated; // 0xA1
	private bool _isVisible; // 0xA2
	private bool _isMoving; // 0xA3
	private static RaycastHit[] _visibilityHitsNoAlloc; // 0x08

	// Properties
	public Animator Animator { get; } // 0x000000018214D4B0-0x000000018214D530 
	public ActorBase ActorBase { get; } // 0x000000018214D430-0x000000018214D4B0 
	public static GameObject CullingPointOverride { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018214D530-0x000000018214D5F0 0x000000018214D660-0x000000018214D6C0
	public GameObject actorSpawned { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
	private bool IsAlwaysLoadType { get; } // 0x000000018214D5F0-0x000000018214D600 
	private bool IsCustomLoadType { get; } // 0x000000018214D600-0x000000018214D610 
	private float LoadDistance { get; } // 0x000000018214D610-0x000000018214D660 

	// Nested types
	[Serializable]
	public enum LoadType // TypeDefIndex: 11516
	{
		Always = 0,
		Far = 10,
		Close = 20,
		Custom = 30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <VisibilityRoutine>d__43 : IEnumerator<object> // TypeDefIndex: 11517
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActorNPCSpawner <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <VisibilityRoutine>d__43(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001821628B0-0x0000000182162B70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000182162B70-0x0000000182162FE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass44_0 // TypeDefIndex: 11518
	{
		// Fields
		public ActorNPCSpawner <>4__this; // 0x10
		public BaseDef npcDef; // 0x18

		// Constructors
		public <>c__DisplayClass44_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <InstantiateActor>b__0(GameObject inGameObject, ActorInfo inInfo); // 0x00000001821621F0-0x00000001821626B0
	}

	// Constructors
	public ActorNPCSpawner(); // 0x000000018214D3B0-0x000000018214D430
	static ActorNPCSpawner(); // 0x000000018214D350-0x000000018214D3B0

	// Methods
	public override void MStart(); // 0x000000018214CB40-0x000000018214CB60
	public override void MStartAfterLocal(); // 0x000000018214CB20-0x000000018214CB40
	private void Init(); // 0x000000018214C670-0x000000018214C800
	private Transform RaycastToCameraHitSomething(); // 0x000000018214CE20-0x000000018214D190
	internal void SetMoving(bool inMoving); // 0x000000018214D190-0x000000018214D2F0
	[IteratorStateMachine] // 0x0000000180211440-0x0000000180211490
	private IEnumerator VisibilityRoutine(); // 0x000000018214D2F0-0x000000018214D350
	private void InstantiateActor(); // 0x000000018214C800-0x000000018214CB20
	private void OnDrawGizmosSelected(); // 0x000000018214CB60-0x000000018214CE20
}

