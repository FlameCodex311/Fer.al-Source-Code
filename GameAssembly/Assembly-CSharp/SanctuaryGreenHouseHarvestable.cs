/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SanctuaryGreenHouseHarvestable : Interactable // TypeDefIndex: 11738
{
	// Fields
	private SanctuaryGreenHouseBox.EType _boxType; // 0x1A0
	private int _boxIndex; // 0x1A4
	private int _plotIndex; // 0x1A8

	// Constructors
	public SanctuaryGreenHouseHarvestable(); // 0x00000001812874B0-0x00000001812874D0

	// Methods
	public void Setup(string inInteractableDefId, SanctuaryGreenHouseBox.EType inBoxType, int inBoxIndex, int inPlotIndex); // 0x0000000181287380-0x00000001812874B0
	private void SetValidInteract(); // 0x00000001812872A0-0x0000000181287380
	public override void RequestInteraction(EInteractableMessage inInteractableMessage); // 0x00000001812871B0-0x00000001812872A0
}

