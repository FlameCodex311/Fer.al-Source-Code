/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x0000000180161E00-0x0000000180161E60
	[HelpURL] // 0x0000000180161E00-0x0000000180161E60
	public class InteractionSystem : UnityEngine.MonoBehaviour // TypeDefIndex: 9426
	{
		// Fields
		[Tooltip] // 0x0000000180161F50-0x0000000180161F80
		public string targetTag; // 0x18
		[Tooltip] // 0x0000000180162090-0x00000001801620C0
		public float fadeInTime; // 0x20
		[Tooltip] // 0x00000001801623A0-0x00000001801623D0
		public float speed; // 0x24
		[Tooltip] // 0x0000000180162580-0x00000001801625B0
		public float resetToDefaultsSpeed; // 0x28
		[FormerlySerializedAs] // 0x0000000180162820-0x00000001801628A0
		[Header] // 0x0000000180162820-0x00000001801628A0
		[Tooltip] // 0x0000000180162820-0x00000001801628A0
		public Collider characterCollider; // 0x30
		[FormerlySerializedAs] // 0x0000000180162D00-0x0000000180162D60
		[Tooltip] // 0x0000000180162D00-0x0000000180162D60
		public Transform FPSCamera; // 0x38
		[Tooltip] // 0x0000000180163090-0x00000001801630C0
		public LayerMask camRaycastLayers; // 0x40
		[Tooltip] // 0x00000001801630F0-0x0000000180163120
		public float camRaycastDistance; // 0x44
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		[SerializeField] // 0x00000001801634B0-0x0000000180163510
		[Space] // 0x00000001801634B0-0x0000000180163510
		[Tooltip] // 0x00000001801634B0-0x0000000180163510
		private FullBodyBipedIK fullBody; // 0xC0
		[Tooltip] // 0x0000000180163670-0x00000001801636A0
		public InteractionLookAt lookAt; // 0xC8
		private InteractionEffector[] interactionEffectors; // 0xD0
		private bool initiated; // 0xD8
		private Collider lastCollider; // 0xE0
		private Collider c; // 0xE8
	
		// Properties
		public bool inInteraction { get; } // 0x0000000181AFFDA0-0x0000000181AFFFA0 
		public FullBodyBipedIK ik { get; set; } // 0x00000001804A1050-0x00000001804A1060 0x00000001804A0A80-0x00000001804A0A90
		public List<InteractionTrigger> triggersInRange { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 9427; 0x00000001808178C0-0x0000000180817B90
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 9428; 0x0000000181AF73E0-0x0000000181AF76C0
	
		// Constructors
		public InteractionSystem(); // 0x0000000181AFF670-0x0000000181AFFDA0
	
		// Methods
		[ContextMenu] // 0x000000018015D0D0-0x000000018015D100
		private void OpenTutorial1(); // 0x0000000181AFC9F0-0x0000000181AFCA30
		[ContextMenu] // 0x000000018015D1F0-0x000000018015D220
		private void OpenTutorial2(); // 0x0000000181AFCA30-0x0000000181AFCA70
		[ContextMenu] // 0x000000018015D480-0x000000018015D4B0
		private void OpenTutorial3(); // 0x0000000181AFCA70-0x0000000181AFCAB0
		[ContextMenu] // 0x000000018015D6A0-0x000000018015D6D0
		private void OpenTutorial4(); // 0x0000000181AFCAB0-0x0000000181AFCAF0
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x0000000181AFDC10-0x0000000181AFDC50
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000181AFA210-0x0000000181AFA250
		public bool IsInInteraction(FullBodyBipedEffector effectorType); // 0x0000000181AFB5B0-0x0000000181AFB7B0
		public bool IsPaused(FullBodyBipedEffector effectorType); // 0x0000000181AFB9E0-0x0000000181AFBBD0
		public bool IsPaused(); // 0x0000000181AFBBD0-0x0000000181AFBDD0
		public bool IsInSync(); // 0x0000000181AFB7B0-0x0000000181AFB9E0
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt); // 0x0000000181AFD230-0x0000000181AFD450
		public bool PauseInteraction(FullBodyBipedEffector effectorType); // 0x0000000181AFCC60-0x0000000181AFCE00
		public bool ResumeInteraction(FullBodyBipedEffector effectorType); // 0x0000000181AFD090-0x0000000181AFD230
		public bool StopInteraction(FullBodyBipedEffector effectorType); // 0x0000000181AFDA70-0x0000000181AFDC10
		public void PauseAll(); // 0x0000000181AFCB30-0x0000000181AFCC60
		public void ResumeAll(); // 0x0000000181AFCF60-0x0000000181AFD090
		public void StopAll(); // 0x0000000181AFD9E0-0x0000000181AFDA70
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType); // 0x0000000181AFAE10-0x0000000181AFAFB0
		public float GetProgress(FullBodyBipedEffector effectorType); // 0x0000000181AFB1D0-0x0000000181AFB370
		public float GetMinActiveProgress(); // 0x0000000181AFAFB0-0x0000000181AFB1D0
		public bool TriggerInteraction(int index, bool interrupt); // 0x0000000181AFEAA0-0x0000000181AFEDF0
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject); // 0x0000000181AFE2D0-0x0000000181AFE630
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget); // 0x0000000181AFE630-0x0000000181AFEAA0
		public InteractionTrigger.Range GetClosestInteractionRange(); // 0x0000000181AFA650-0x0000000181AFA800
		public InteractionObject GetClosestInteractionObjectInRange(); // 0x0000000181AFA480-0x0000000181AFA4E0
		public InteractionTarget GetClosestInteractionTargetInRange(); // 0x0000000181AFA800-0x0000000181AFA8F0
		public InteractionObject[] GetClosestInteractionObjectsInRange(); // 0x0000000181AFA4E0-0x0000000181AFA650
		public InteractionTarget[] GetClosestInteractionTargetsInRange(); // 0x0000000181AFA8F0-0x0000000181AFAAB0
		public bool TriggerEffectorsReady(int index); // 0x0000000181AFDC50-0x0000000181AFE1D0
		public InteractionTrigger.Range GetTriggerRange(int index); // 0x0000000181AFB370-0x0000000181AFB550
		public int GetClosestTriggerIndex(); // 0x0000000181AFAAB0-0x0000000181AFAE10
		private void Start(); // 0x0000000181AFD450-0x0000000181AFD9E0
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181AFB550-0x0000000181AFB580
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181AFB580-0x0000000181AFB5B0
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181AFB580-0x0000000181AFB5B0
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x0000000181AFBEA0-0x0000000181AFBF70
		public void OnTriggerEnter(Collider c); // 0x0000000181AFC7B0-0x0000000181AFC8C0
		public void OnTriggerExit(Collider c); // 0x0000000181AFC8C0-0x0000000181AFC9B0
		private bool ContactIsInRange(int index, out int bestRangeIndex); // 0x0000000181AFA250-0x0000000181AFA480
		private void OnDrawGizmosSelected(); // 0x0000000181AFC330-0x0000000181AFC410
		private void Update(); // 0x0000000181AFF280-0x0000000181AFF670
		private void Raycasting(); // 0x0000000181AFCE00-0x0000000181AFCF60
		private void UpdateTriggerEventBroadcasting(); // 0x0000000181AFEFA0-0x0000000181AFF280
		private void UpdateEffectors(); // 0x0000000181AFEDF0-0x0000000181AFEFA0
		private void OnPreFBBIK(); // 0x0000000181AFC710-0x0000000181AFC7B0
		private void OnPostFBBIK(); // 0x0000000181AFC4E0-0x0000000181AFC710
		private void OnFixTransforms(); // 0x0000000181AFC410-0x0000000181AFC4E0
		private void OnDestroy(); // 0x0000000181AFBF70-0x0000000181AFC330
		private bool IsValid(bool log); // 0x0000000181AFBDD0-0x0000000181AFBEA0
		private bool TriggerIndexIsValid(int index); // 0x0000000181AFE1D0-0x0000000181AFE2D0
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x0000000181AFCAF0-0x0000000181AFCB30
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x0000000181AFC9B0-0x0000000181AFC9F0
	}
}
