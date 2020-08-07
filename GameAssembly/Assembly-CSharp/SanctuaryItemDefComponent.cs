/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180211990-0x00000001802119C0
public class SanctuaryItemDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 12061
{
	// Fields
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isWallObject; // 0x18
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool collideWithPlayer; // 0x19
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isStatic; // 0x1A
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool canStack; // 0x1B
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool canStackOn; // 0x1C
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public ESanctuaryItemType objectType; // 0x20
	[ChartEnum] // 0x00000001801DE450-0x00000001801DE460
	public ESanctuaryStateInteract stateInteractType; // 0x24
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isPreplacedForNewAccounts; // 0x28
	[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
	public Vector3 preplacedPosition; // 0x2C
	[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
	public Vector3 preplacedRotation; // 0x38
	[ChartList] // 0x00000001801DE450-0x00000001801DE460
	public List<SanctuaryItemState> availableStates; // 0x48

	// Constructors
	public SanctuaryItemDefComponent(); // 0x0000000180BEAA70-0x0000000180BEAB30

	// Methods
	public void OnClientOnlyItemCreated(Item item); // 0x0000000180BEAA20-0x0000000180BEAA70
}

