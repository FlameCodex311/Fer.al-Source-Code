/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InteractionManager : SingletonManagerBase<InteractionManager> // TypeDefIndex: 10723
{
	// Fields
	private Interactable _currentInteractable; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <CanInteract>k__BackingField; // 0x68
	private List<Interactable> _currentInteractables; // 0x70
	private Interactable _primaryInteractable; // 0x78

	// Properties
	public Interactable CurrentInteractable { get; set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
	public bool CanInteract { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180622650-0x0000000180622660 0x00000001804638B0-0x00000001804638C0
	public Interactable PrimaryInteractable { get; private set; } // 0x0000000180369C70-0x0000000180369C80 0x0000000180F619A0-0x0000000180F61B10

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10724
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<Interactable> <>9__14_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F70440-0x0000000180F704A0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <UpdatePrimaryInteractable>b__14_0(Interactable x, Interactable y); // 0x0000000180F6F540-0x0000000180F6F5A0
	}

	// Constructors
	public InteractionManager(); // 0x0000000180F61930-0x0000000180F619A0

	// Methods
	private void OnInteractableItemInRange(InteractableItemInRangeMessage inMessage); // 0x0000000180F60B60-0x0000000180F60C30
	private void UpdatePrimaryInteractable(); // 0x0000000180F61150-0x0000000180F61930
	public override void MUpdate(); // 0x0000000180F60B40-0x0000000180F60B60
	public override void Init(); // 0x0000000180F60A60-0x0000000180F60B40
	public override void Deinit(); // 0x0000000180F60790-0x0000000180F60870
	public void RequestInteraction(Interactable.EInteractableMessage inInteractionType); // 0x0000000180F60F90-0x0000000180F60FF0
	private void StartInteraction(); // 0x0000000180F61130-0x0000000180F61150
	private void EndInteraction(); // 0x0000000180F60A40-0x0000000180F60A60
	public void DoInteraction(int inActionIndex); // 0x0000000180F60870-0x0000000180F60A40
	private void SendInteractableInteractedMessage(Interactable inInteractable, Interactable.EInteractableMessage inInteractableMessage); // 0x0000000180F60FF0-0x0000000180F61130
	internal void OnInteracted(Interactable inInteractable, Interactable.EInteractableMessage inInteractableMessage, InteractableState interactableState = InteractableState.Active /* Metadata: 0x00781F90 */, string userUUID = null); // 0x0000000180F60C30-0x0000000180F60D70
	private void OnInventoryList(InventoryListResponse inMessage); // 0x0000000180F60D70-0x0000000180F60F90
}

