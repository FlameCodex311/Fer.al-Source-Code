/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Interactable : ManagedBehaviour // TypeDefIndex: 10474
{
	// Fields
	[RootSelector] // 0x0000000180122550-0x00000001801225B0
	public string interactableDefId; // 0x50
	private string _interactableDefIdOverride; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _forceToTerrain; // 0x60
	public Vector3 interactImageOffsetModifier; // 0x64
	public Vector3 interactImageOffsetModifierFirstPerson; // 0x70
	public float interactRangeOverride; // 0x7C
	public EInteractableType interactableType; // 0x80
	[DeBeginGroup] // 0x0000000180122970-0x00000001801229E0
	[DeHeader] // 0x0000000180122970-0x00000001801229E0
	public InteractableStateInfo idleState; // 0x88
	public InteractableStateInfo interactingState; // 0x90
	public InteractableStateInfo interactedState; // 0x98
	[DeEndGroup] // 0x0000000180122BB0-0x0000000180122C10
	[Header] // 0x0000000180122BB0-0x0000000180122C10
	[SerializeField] // 0x0000000180122BB0-0x0000000180122C10
	private bool _jiggleWhileInteracting; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _jiggleMaxRotation; // 0xA4
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _jiggleRotationSpeed; // 0xB0
	[SerializeField] // 0x0000000180124560-0x00000001801245B0
	[Tooltip] // 0x0000000180124560-0x00000001801245B0
	private GameObject _interactedFx; // 0xB8
	[SerializeField] // 0x00000001801247B0-0x0000000180124800
	[Tooltip] // 0x00000001801247B0-0x0000000180124800
	private GameObject groupInteractedFX; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _destructionTimer; // 0xC8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _destructionObject; // 0xD0
	[SerializeField] // 0x0000000180124B30-0x0000000180124B80
	[Tooltip] // 0x0000000180124B30-0x0000000180124B80
	private AudioScriptableObject _audioStartInteract; // 0xD8
	[SerializeField] // 0x0000000180124D70-0x0000000180124DC0
	[Tooltip] // 0x0000000180124D70-0x0000000180124DC0
	private AudioScriptableObject _audioInteract; // 0xE0
	internal bool interacting; // 0xE8
	protected bool _allowInteraction; // 0xE9
	private MinimapBlip _minimapBlip; // 0xF0
	private bool _wasInRange; // 0xF8
	private bool _showPrompt; // 0xF9
	private bool _doJiggle; // 0xFA
	private Quaternion qInitialRotation; // 0xFC
	private WWSimpleAnimation _wwSimpleAnimation; // 0x110
	private ParticleSystem[] _fxInteracting; // 0x118
	internal NetworkedObjectInfo networkedObjectInfo; // 0x120
	private Bounds? _bounds; // 0x128
	internal bool isSnoozing; // 0x144
	private Vector3? _interactImageOffset; // 0x148
	private Vector3? _interactImageOffsetFirstPerson; // 0x158
	private float? _interactRange; // 0x168
	private float? _interactTimer; // 0x170
	private string _interactImageDefId; // 0x178
	private string _interactTooltipDefId; // 0x180
	private SocialExpanseChestObject _SocialExpanseChestObject; // 0x188
	private InteractableDefComponent _interactableDef; // 0x190
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <distanceToPlayer>k__BackingField; // 0x198
	private static Transform _playerTransform; // 0x00

	// Properties
	public string InteractableDefId { get; } // 0x0000000180F5FCE0-0x0000000180F60020 
	public bool ForceToTerrain { get; set; } // 0x00000001804785B0-0x00000001804785C0 0x000000018062BA40-0x000000018062BA50
	public bool doJiggle { get; } // 0x0000000180DD2000-0x0000000180DD2010 
	public Bounds bounds { get; } // 0x0000000180F60020-0x0000000180F60230 
	public Vector3 interactImageOffset { get; } // 0x0000000180F60400-0x0000000180F60480 
	public Vector3 interactImageOffsetFirstPerson { get; } // 0x0000000180F60290-0x0000000180F60400 
	public float interactRange { get; } // 0x0000000180F60480-0x0000000180F604D0 
	public float interactTimer { get; } // 0x0000000180F604D0-0x0000000180F60560 
	private string interactImageDefId { get; } // 0x0000000180F60240-0x0000000180F60290 
	public string InteractTooltipDefId { get; } // 0x0000000180F5FC90-0x0000000180F5FCE0 
	public InteractableDefComponent interactableDef { get; } // 0x0000000180F60560-0x0000000180F60690 
	public float distanceToPlayer { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F60230-0x0000000180F60240 0x0000000180F60780-0x0000000180F60790
	protected static Transform playerTransform { get; } // 0x0000000180F60690-0x0000000180F60780 

	// Nested types
	[Serializable]
	public class InteractableStateInfo // TypeDefIndex: 10475
	{
		// Fields
		public AnimationClip animationClip; // 0x10
		public WrapMode animationWrapMode; // 0x18
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public EInteractableState interactableState; // 0x1C

		// Constructors
		public InteractableStateInfo(); // 0x0000000180F5D420-0x0000000180F5D430
	}

	public enum EInteractableState // TypeDefIndex: 10476
	{
		NONE = 0,
		IDLE = 1,
		INTERACT_BEGIN = 2,
		INTERACTING = 3,
		INTERACTED = 4
	}

	public enum EInteractableMessage // TypeDefIndex: 10477
	{
		Start = 0,
		Cancel = 1,
		Finish = 2
	}

	public enum EInteractableType // TypeDefIndex: 10478
	{
		NONE = 0,
		DIG = 1,
		DIVE = 2,
		CUT = 3,
		NET = 4,
		BASH = 5
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FinalizeInteractablePoint>d__80 : IEnumerator<object> // TypeDefIndex: 10479
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Interactable <>4__this; // 0x20
		public bool shouldDestroy; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FinalizeInteractablePoint>d__80(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F6D490-0x0000000180F6D800
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F6D800-0x0000000180F6DF00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Jiggle>d__89 : IEnumerator<object> // TypeDefIndex: 10480
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Interactable <>4__this; // 0x20
		private float <fTimer>5__2; // 0x28
		private Quaternion <qToRotation>5__3; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Jiggle>d__89(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F6EAC0-0x0000000180F6EDA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F6EDA0-0x0000000180F6F4A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass90_0 // TypeDefIndex: 10481
	{
		// Fields
		public Interactable <>4__this; // 0x10
		public EInteractableMessage inInteractableMessage; // 0x18

		// Constructors
		public <>c__DisplayClass90_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestInteraction>b__0(); // 0x0000000180F70390-0x0000000180F70440
	}

	// Constructors
	public Interactable(); // 0x0000000180F5FBD0-0x0000000180F5FC90

	// Methods
	public override void MStartAfterLocal(); // 0x0000000180F5DD90-0x0000000180F5E250
	public override void MUpdate(); // 0x0000000180F5E250-0x0000000180F5E4C0
	public override void MOnEnable(); // 0x0000000180F5DD70-0x0000000180F5DD90
	public override void MOnDisable(); // 0x0000000180F5DCC0-0x0000000180F5DD70
	public override void MOnDestroy(); // 0x0000000180F5DC90-0x0000000180F5DCC0
	internal void GiveToPlayer(string inDefId, int inAmount); // 0x0000000180F5D9D0-0x0000000180F5DB70
	private void ToggleInteractableParticles(bool inValue); // 0x0000000180F5FB40-0x0000000180F5FBD0
	[IteratorStateMachine] // 0x00000001801255C0-0x0000000180125610
	public IEnumerator FinalizeInteractablePoint(bool shouldDestroy); // 0x0000000180F5D960-0x0000000180F5D9D0
	internal void Respawn(); // 0x0000000180F5F330-0x0000000180F5F4A0
	protected void ShowPrompt(bool inShowPrompt); // 0x0000000180F5FA10-0x0000000180F5FB40
	public List<string> ActionIconDefIds(); // 0x0000000180F5D490-0x0000000180F5D540
	public List<Action> InteractActions(); // 0x0000000180F5DB70-0x0000000180F5DC30
	public void OnInteractionStart(); // 0x0000000180F5E950-0x0000000180F5EAE0
	public void OnInteractionCancel(); // 0x0000000180F5E890-0x0000000180F5E950
	public virtual void Interact(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void PlayAudioAndFX(); // 0x0000000180F5EAE0-0x0000000180F5ECD0
	[IteratorStateMachine] // 0x00000001801257E0-0x0000000180125830
	private IEnumerator Jiggle(); // 0x0000000180F5DC30-0x0000000180F5DC90
	public virtual void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x0000000180F5ECD0-0x0000000180F5F330
	private void AddClips(InteractableStateInfo inInfo); // 0x0000000180F5D540-0x0000000180F5D640
	private void SetInfo(InteractableStateInfo inInfo); // 0x0000000180F5F4A0-0x0000000180F5FA10
	private void CalcInteractRange(); // 0x0000000180F5D880-0x0000000180F5D960
	private void CalcInteractImageOffset(); // 0x0000000180F5D760-0x0000000180F5D880
	private void CalcInteractImageOffsetFirstPerson(); // 0x0000000180F5D640-0x0000000180F5D760
	private void OnDrawGizmosSelected(); // 0x0000000180F5E4C0-0x0000000180F5E890
}

