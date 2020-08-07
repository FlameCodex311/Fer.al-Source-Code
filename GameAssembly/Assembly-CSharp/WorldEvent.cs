/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldEvent : ManagedBehaviour // TypeDefIndex: 11432
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected int _id; // 0x50

	// Constructors
	public WorldEvent(); // 0x00000001805E6E70-0x00000001805E6ED0

	// Methods
	public override void MStart(); // 0x00000001805E6F80-0x00000001805E7030
	public override void MOnDestroy(); // 0x00000001805E6ED0-0x00000001805E6F80
	protected virtual void OnWorldEvent(WorldEventMessage inWorldEventMessage); // 0x00000001803774A0-0x00000001803774B0
}

