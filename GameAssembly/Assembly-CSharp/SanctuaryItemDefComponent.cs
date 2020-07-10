/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180137DF0-0x0000000180137E20
public class SanctuaryItemDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 10572
{
	// Fields
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isWallObject; // 0x18
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool collideWithPlayer; // 0x19
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isStatic; // 0x1A
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool canStack; // 0x1B
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool canStackOn; // 0x1C
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public ESanctuaryItemType objectType; // 0x20
	[ChartEnum] // 0x00000001800B5960-0x00000001800B5970
	public ESanctuaryStateInteract stateInteractType; // 0x24
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isPreplacedForNewAccounts; // 0x28
	[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
	public Vector3 preplacedPosition; // 0x2C
	[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
	public Vector3 preplacedRotation; // 0x38
	[ChartList] // 0x00000001800B5960-0x00000001800B5970
	public List<SanctuaryItemState> availableStates; // 0x48

	// Constructors
	public SanctuaryItemDefComponent(); // 0x0000000181362200-0x00000001813622C0

	// Methods
	public void OnClientOnlyItemCreated(Item item); // 0x00000001813621B0-0x0000000181362200
}

