/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Stage_UncraftingShop : UI_Stage_3DItem // TypeDefIndex: 13856
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ActorNPCSpawner _shopkeep; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Animator _centrifugeAnimator; // 0xC8

	// Constructors
	public UI_Stage_UncraftingShop(); // 0x00000001804CFB50-0x00000001804CFC00

	// Methods
	protected override void SendLoadedMessage(); // 0x00000001804D21C0-0x00000001804D2240
	protected override void SendInitializedMessage(); // 0x00000001804D2140-0x00000001804D21C0
	public void SetIsCrafting(bool inIsCrafting); // 0x00000001804D2240-0x00000001804D2310
}

