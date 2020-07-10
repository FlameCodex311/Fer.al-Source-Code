/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Stage_UncraftingShop : UI_Stage_3DItem // TypeDefIndex: 12666
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ActorNPCSpawner _shopkeep; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Animator _centrifugeAnimator; // 0xC8

	// Constructors
	public UI_Stage_UncraftingShop(); // 0x0000000180F918E0-0x0000000180F918F0

	// Methods
	protected override void SendLoadedMessage(); // 0x0000000180F91790-0x0000000180F91810
	protected override void SendInitializedMessage(); // 0x0000000180F91710-0x0000000180F91790
	public void SetIsCrafting(bool inIsCrafting); // 0x0000000180F91810-0x0000000180F918E0
}

