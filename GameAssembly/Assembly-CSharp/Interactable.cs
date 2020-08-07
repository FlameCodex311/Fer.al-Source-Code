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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Interactable : ManagedBehaviour // TypeDefIndex: 11962
{
	// Fields
	[RootSelector] // 0x00000001801F4C20-0x00000001801F4C80
	public string interactableDefId; // 0x50
	private string _interactableDefIdOverride; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _forceToTerrain; // 0x60
	public Vector3 interactImageOffsetModifier; // 0x64
	public Vector3 interactImageOffsetModifierFirstPerson; // 0x70
	public float interactRangeOverride; // 0x7C
	public EInteractableType interactableType; // 0x80
	[DeBeginGroup] // 0x00000001801F52F0-0x00000001801F5360
	[DeHeader] // 0x00000001801F52F0-0x00000001801F5360
	public InteractableStateInfo idleState; // 0x88
	public InteractableStateInfo interactingState; // 0x90
	public InteractableStateInfo interactedState; // 0x98
	[DeEndGroup] // 0x00000001801F5660-0x00000001801F56C0
	[Header] // 0x00000001801F5660-0x00000001801F56C0
	[SerializeField] // 0x00000001801F5660-0x00000001801F56C0
	private bool _jiggleWhileInteracting; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _jiggleMaxRotation; // 0xA4
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _jiggleRotationSpeed; // 0xB0
	[SerializeField] // 0x00000001801F5CC0-0x00000001801F5D10
	[Tooltip] // 0x00000001801F5CC0-0x00000001801F5D10
	private GameObject _interactedFx; // 0xB8
	[SerializeField] // 0x00000001801F7360-0x00000001801F73B0
	[Tooltip] // 0x00000001801F7360-0x00000001801F73B0
	private GameObject groupInteractedFX; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _destructionTimer; // 0xC8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _destructionObject; // 0xD0
	[SerializeField] // 0x00000001801F7980-0x00000001801F79D0
	[Tooltip] // 0x00000001801F7980-0x00000001801F79D0
	private AudioScriptableObject _audioStartInteract; // 0xD8
	[SerializeField] // 0x00000001801F7C60-0x00000001801F7CB0
	[Tooltip] // 0x00000001801F7C60-0x00000001801F7CB0
	private AudioScriptableObject _audioInteract; // 0xE0
	[Header] // 0x00000001801F7E80-0x00000001801F7EF0
	[SerializeField] // 0x00000001801F7E80-0x00000001801F7EF0
	[Tooltip] // 0x00000001801F7E80-0x00000001801F7EF0
	private bool _continuousHarvest; // 0xE8
	internal bool interacting; // 0xE9
	internal bool isSocialExpanseDigSpot; // 0xEA
	protected bool _allowInteraction; // 0xEB
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <distanceToPlayer>k__BackingField; // 0x198
	private static Transform _playerTransform; // 0x00

	// Properties
	public string InteractableDefId { get; } // 0x0000000180629090-0x00000001806293C0 
	public bool ForceToTerrain { get; set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018045A0C0-0x000000018045A0D0
	public bool doJiggle { get; } // 0x00000001806295E0-0x00000001806295F0 
	public Bounds bounds { get; } // 0x00000001806293C0-0x00000001806295D0 
	public Vector3 interactImageOffset { get; } // 0x00000001806297B0-0x0000000180629830 
	public Vector3 interactImageOffsetFirstPerson { get; } // 0x0000000180629640-0x00000001806297B0 
	public float interactRange { get; } // 0x0000000180629830-0x0000000180629880 
	public float interactTimer { get; } // 0x0000000180629880-0x0000000180629910 
	private string interactImageDefId { get; } // 0x00000001806295F0-0x0000000180629640 
	public string InteractTooltipDefId { get; } // 0x0000000180629040-0x0000000180629090 
	public InteractableDefComponent interactableDef { get; } // 0x0000000180629910-0x0000000180629A40 
	public float distanceToPlayer { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001806295D0-0x00000001806295E0 0x0000000180629B30-0x0000000180629B40
	protected static Transform playerTransform { get; } // 0x0000000180629A40-0x0000000180629B30 

	// Nested types
	[Serializable]
	public class InteractableStateInfo // TypeDefIndex: 11963
	{
		// Fields
		public AnimationClip animationClip; // 0x10
		public WrapMode animationWrapMode; // 0x18
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public EInteractableState interactableState; // 0x1C

		// Constructors
		public InteractableStateInfo(); // 0x0000000180626890-0x00000001806268A0
	}

	public enum EInteractableState // TypeDefIndex: 11964
	{
		NONE = 0,
		IDLE = 1,
		INTERACT_BEGIN = 2,
		INTERACTING = 3,
		INTERACTED = 4
	}

	public enum EInteractableMessage // TypeDefIndex: 11965
	{
		Start = 0,
		Cancel = 1,
		Finish = 2
	}

	public enum EInteractableType // TypeDefIndex: 11966
	{
		NONE = 0,
		DIG = 1,
		DIVE = 2,
		CUT = 3,
		NET = 4,
		BASH = 5
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FinalizeInteractablePoint>d__83 : IEnumerator<object> // TypeDefIndex: 11967
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Interactable <>4__this; // 0x20
		public bool shouldDestroy; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FinalizeInteractablePoint>d__83(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018062E600-0x000000018062E970
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018062E970-0x000000018062F060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Jiggle>d__92 : IEnumerator<object> // TypeDefIndex: 11968
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Interactable <>4__this; // 0x20
		private float <fTimer>5__2; // 0x28
		private Quaternion <qToRotation>5__3; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Jiggle>d__92(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018062FBD0-0x000000018062FEA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018062FEA0-0x000000018062FEF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass93_0 // TypeDefIndex: 11969
	{
		// Fields
		public Interactable <>4__this; // 0x10
		public EInteractableMessage inInteractableMessage; // 0x18

		// Constructors
		public <>c__DisplayClass93_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestInteraction>b__0(); // 0x0000000180631640-0x00000001806316F0
	}

	// Constructors
	public Interactable(); // 0x0000000180628F70-0x0000000180629040

	// Methods
	public virtual bool ContinuousHarvest(); // 0x0000000180626DB0-0x0000000180626DC0
	public override void MStartAfterLocal(); // 0x00000001806271C0-0x0000000180627670
	public override void MUpdate(); // 0x0000000180627670-0x00000001806278D0
	public override void MOnEnable(); // 0x00000001806271A0-0x00000001806271C0
	public override void MOnDisable(); // 0x0000000180627100-0x00000001806271A0
	public override void MOnDestroy(); // 0x00000001806270D0-0x0000000180627100
	internal void GiveToPlayer(string inDefId, int inAmount); // 0x0000000180626E30-0x0000000180626FC0
	private void ToggleInteractableParticles(bool inValue); // 0x0000000180628EE0-0x0000000180628F70
	[IteratorStateMachine] // 0x00000001801F98F0-0x00000001801F9940
	public IEnumerator FinalizeInteractablePoint(bool shouldDestroy); // 0x0000000180626DC0-0x0000000180626E30
	internal void Respawn(); // 0x00000001806286F0-0x0000000180628860
	protected void ShowPrompt(bool inShowPrompt); // 0x0000000180628DB0-0x0000000180628EE0
	public List<string> ActionIconDefIds(); // 0x0000000180626900-0x00000001806269B0
	public List<Action> InteractActions(); // 0x0000000180626FC0-0x0000000180627070
	public void OnInteractionStart(); // 0x0000000180627D50-0x0000000180627ED0
	public void OnInteractionCancel(); // 0x0000000180627C90-0x0000000180627D50
	public virtual void Interact(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void PlayAudioAndFX(); // 0x0000000180627ED0-0x00000001806280B0
	[IteratorStateMachine] // 0x00000001801F9C40-0x00000001801F9C90
	private IEnumerator Jiggle(); // 0x0000000180627070-0x00000001806270D0
	public virtual void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x00000001806280B0-0x00000001806286F0
	private void AddClips(InteractableStateInfo inInfo); // 0x00000001806269B0-0x0000000180626AB0
	private void SetInfo(InteractableStateInfo inInfo); // 0x0000000180628860-0x0000000180628DB0
	private void CalcInteractRange(); // 0x0000000180626CD0-0x0000000180626DB0
	private void CalcInteractImageOffset(); // 0x0000000180626BC0-0x0000000180626CD0
	private void CalcInteractImageOffsetFirstPerson(); // 0x0000000180626AB0-0x0000000180626BC0
	private void OnDrawGizmosSelected(); // 0x00000001806278D0-0x0000000180627C90
}

