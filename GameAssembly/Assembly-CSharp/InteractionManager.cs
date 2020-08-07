/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InteractionManager : SingletonManagerBase<InteractionManager> // TypeDefIndex: 12233
{
	// Fields
	private Interactable _currentInteractable; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <CanInteract>k__BackingField; // 0x68
	private List<Interactable> _currentInteractables; // 0x70
	private Interactable _primaryInteractable; // 0x78

	// Properties
	public Interactable CurrentInteractable { get; set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
	public bool CanInteract { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018037D390-0x000000018037D3A0 0x000000018039EC50-0x000000018039EC60
	public Interactable PrimaryInteractable { get; private set; } // 0x0000000180418A40-0x0000000180418A50 0x000000018062ADA0-0x000000018062AF10

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12234
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<Interactable> <>9__14_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180631750-0x00000001806317B0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <UpdatePrimaryInteractable>b__14_0(Interactable x, Interactable y); // 0x00000001806305D0-0x0000000180630620
	}

	// Constructors
	public InteractionManager(); // 0x000000018062AD30-0x000000018062ADA0

	// Methods
	private void OnInteractableItemInRange(InteractableItemInRangeMessage inMessage); // 0x0000000180629F00-0x0000000180629FD0
	private void UpdatePrimaryInteractable(); // 0x000000018062A4F0-0x000000018062AD30
	public override void MUpdate(); // 0x0000000180629EE0-0x0000000180629F00
	public override void Init(); // 0x0000000180629E00-0x0000000180629EE0
	public override void Deinit(); // 0x0000000180629B40-0x0000000180629C20
	public void RequestInteraction(Interactable.EInteractableMessage inInteractionType); // 0x000000018062A330-0x000000018062A390
	private void StartInteraction(); // 0x000000018062A4D0-0x000000018062A4F0
	private void EndInteraction(); // 0x0000000180629DE0-0x0000000180629E00
	public void DoInteraction(int inActionIndex); // 0x0000000180629C20-0x0000000180629DE0
	private void SendInteractableInteractedMessage(Interactable inInteractable, Interactable.EInteractableMessage inInteractableMessage); // 0x000000018062A390-0x000000018062A4D0
	internal void OnInteracted(Interactable inInteractable, Interactable.EInteractableMessage inInteractableMessage, InteractableState interactableState = InteractableState.Active /* Metadata: 0x007B964B */, string userUUID = null); // 0x0000000180629FD0-0x000000018062A110
	private void OnInventoryList(InventoryListResponse inMessage); // 0x000000018062A110-0x000000018062A330
}

