/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x0000000180260A80-0x0000000180260AE0
	[HelpURL] // 0x0000000180260A80-0x0000000180260AE0
	public class InteractionSystem : UnityEngine.MonoBehaviour // TypeDefIndex: 9960
	{
		// Fields
		[Tooltip] // 0x0000000180260D40-0x0000000180260D70
		public string targetTag; // 0x18
		[Tooltip] // 0x0000000180260E80-0x0000000180260EB0
		public float fadeInTime; // 0x20
		[Tooltip] // 0x0000000180262330-0x0000000180262360
		public float speed; // 0x24
		[Tooltip] // 0x0000000180262610-0x0000000180262640
		public float resetToDefaultsSpeed; // 0x28
		[FormerlySerializedAs] // 0x0000000180262870-0x00000001802628F0
		[Header] // 0x0000000180262870-0x00000001802628F0
		[Tooltip] // 0x0000000180262870-0x00000001802628F0
		public Collider characterCollider; // 0x30
		[FormerlySerializedAs] // 0x0000000180262C90-0x0000000180262CF0
		[Tooltip] // 0x0000000180262C90-0x0000000180262CF0
		public Transform FPSCamera; // 0x38
		[Tooltip] // 0x0000000180263020-0x0000000180263050
		public LayerMask camRaycastLayers; // 0x40
		[Tooltip] // 0x0000000180263190-0x00000001802631C0
		public float camRaycastDistance; // 0x44
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<InteractionTrigger> <triggersInRange>k__BackingField; // 0x48
		private List<InteractionTrigger> inContact; // 0x50
		private List<int> bestRangeIndexes; // 0x58
		public InteractionDelegate OnInteractionStart; // 0x60
		public InteractionDelegate OnInteractionPause; // 0x68
		public InteractionDelegate OnInteractionPickUp; // 0x70
		public InteractionDelegate OnInteractionResume; // 0x78
		public InteractionDelegate OnInteractionStop; // 0x80
		public InteractionEventDelegate OnInteractionEvent; // 0x88
		public RaycastHit raycastHit; // 0x90
		[SerializeField] // 0x0000000180264790-0x00000001802647F0
		[Space] // 0x0000000180264790-0x00000001802647F0
		[Tooltip] // 0x0000000180264790-0x00000001802647F0
		private FullBodyBipedIK fullBody; // 0xC0
		[Tooltip] // 0x0000000180264B20-0x0000000180264B50
		public InteractionLookAt lookAt; // 0xC8
		private InteractionEffector[] interactionEffectors; // 0xD0
		private bool initiated; // 0xD8
		private Collider lastCollider; // 0xE0
		private Collider c; // 0xE8
	
		// Properties
		public bool inInteraction { get; } // 0x0000000181638390-0x0000000181638580 
		public FullBodyBipedIK ik { get; set; } // 0x0000000180529360-0x0000000180529370 0x0000000180529410-0x0000000180529420
		public List<InteractionTrigger> triggersInRange { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 9961; 0x00000001811276C0-0x00000001811279A0
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 9962; 0x000000018162FE00-0x0000000181630130
	
		// Constructors
		public InteractionSystem(); // 0x0000000181637CA0-0x0000000181638390
	
		// Methods
		[ContextMenu] // 0x000000018025DB00-0x000000018025DB30
		private void OpenTutorial1(); // 0x00000001816351B0-0x00000001816351F0
		[ContextMenu] // 0x000000018025DD40-0x000000018025DD70
		private void OpenTutorial2(); // 0x00000001816351F0-0x0000000181635230
		[ContextMenu] // 0x000000018025DE30-0x000000018025DE60
		private void OpenTutorial3(); // 0x0000000181635230-0x0000000181635270
		[ContextMenu] // 0x000000018025DFF0-0x000000018025E020
		private void OpenTutorial4(); // 0x0000000181635270-0x00000001816352B0
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000181636350-0x0000000181636390
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x0000000181632B00-0x0000000181632B40
		public bool IsInInteraction(FullBodyBipedEffector effectorType); // 0x0000000181633DF0-0x0000000181633FD0
		public bool IsPaused(FullBodyBipedEffector effectorType); // 0x00000001816341F0-0x00000001816343D0
		public bool IsPaused(); // 0x00000001816343D0-0x00000001816345C0
		public bool IsInSync(); // 0x0000000181633FD0-0x00000001816341F0
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt); // 0x00000001816359B0-0x0000000181635BC0
		public bool PauseInteraction(FullBodyBipedEffector effectorType); // 0x0000000181635410-0x00000001816355A0
		public bool ResumeInteraction(FullBodyBipedEffector effectorType); // 0x0000000181635820-0x00000001816359B0
		public bool StopInteraction(FullBodyBipedEffector effectorType); // 0x00000001816361C0-0x0000000181636350
		public void PauseAll(); // 0x00000001816352F0-0x0000000181635410
		public void ResumeAll(); // 0x0000000181635700-0x0000000181635820
		public void StopAll(); // 0x0000000181636130-0x00000001816361C0
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType); // 0x00000001816336A0-0x0000000181633830
		public float GetProgress(FullBodyBipedEffector effectorType); // 0x0000000181633A50-0x0000000181633BE0
		public float GetMinActiveProgress(); // 0x0000000181633830-0x0000000181633A50
		public bool TriggerInteraction(int index, bool interrupt); // 0x0000000181637130-0x0000000181637450
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject); // 0x00000001816369C0-0x0000000181636CF0
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget); // 0x0000000181636CF0-0x0000000181637130
		public InteractionTrigger.Range GetClosestInteractionRange(); // 0x0000000181632F30-0x00000001816330D0
		public InteractionObject GetClosestInteractionObjectInRange(); // 0x0000000181632D70-0x0000000181632DD0
		public InteractionTarget GetClosestInteractionTargetInRange(); // 0x00000001816330D0-0x00000001816331A0
		public InteractionObject[] GetClosestInteractionObjectsInRange(); // 0x0000000181632DD0-0x0000000181632F30
		public InteractionTarget[] GetClosestInteractionTargetsInRange(); // 0x00000001816331A0-0x0000000181633350
		public bool TriggerEffectorsReady(int index); // 0x0000000181636390-0x00000001816368C0
		public InteractionTrigger.Range GetTriggerRange(int index); // 0x0000000181633BE0-0x0000000181633DB0
		public int GetClosestTriggerIndex(); // 0x0000000181633350-0x00000001816336A0
		private void Start(); // 0x0000000181635BC0-0x0000000181636130
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181633DB0-0x0000000181633DD0
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181633DD0-0x0000000181633DF0
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181633DD0-0x0000000181633DF0
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181634690-0x0000000181634760
		public void OnTriggerEnter(Collider c); // 0x0000000181634F80-0x0000000181635090
		public void OnTriggerExit(Collider c); // 0x0000000181635090-0x0000000181635170
		private bool ContactIsInRange(int index, out int bestRangeIndex); // 0x0000000181632B40-0x0000000181632D70
		private void OnDrawGizmosSelected(); // 0x0000000181634B20-0x0000000181634C00
		private void Update(); // 0x00000001816378C0-0x0000000181637CA0
		private void Raycasting(); // 0x00000001816355A0-0x0000000181635700
		private void UpdateTriggerEventBroadcasting(); // 0x00000001816375E0-0x00000001816378C0
		private void UpdateEffectors(); // 0x0000000181637450-0x00000001816375E0
		private void OnPreFBBIK(); // 0x0000000181634EE0-0x0000000181634F80
		private void OnPostFBBIK(); // 0x0000000181634CC0-0x0000000181634EE0
		private void OnFixTransforms(); // 0x0000000181634C00-0x0000000181634CC0
		private void OnDestroy(); // 0x0000000181634760-0x0000000181634B20
		private bool IsValid(bool log); // 0x00000001816345C0-0x0000000181634690
		private bool TriggerIndexIsValid(int index); // 0x00000001816368C0-0x00000001816369C0
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x00000001816352B0-0x00000001816352F0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x0000000181635170-0x00000001816351B0
	}
}
