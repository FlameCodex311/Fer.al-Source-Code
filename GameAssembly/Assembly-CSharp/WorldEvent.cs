/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldEvent : ManagedBehaviour // TypeDefIndex: 13759
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected int _id; // 0x50

	// Constructors
	public WorldEvent(); // 0x0000000180FFFBB0-0x0000000180FFFC10

	// Methods
	public override void MStart(); // 0x0000000180FFFCC0-0x0000000180FFFD70
	public override void MOnDestroy(); // 0x0000000180FFFC10-0x0000000180FFFCC0
	protected virtual void OnWorldEvent(WorldEventMessage inWorldEventMessage); // 0x00000001803581E0-0x00000001803581F0
}

