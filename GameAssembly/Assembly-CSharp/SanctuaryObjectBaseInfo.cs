/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class SanctuaryObjectBaseInfo : WorldObjectInfo // TypeDefIndex: 10963
{
	// Fields
	public int index; // 0x18
	public Vector3 position; // 0x1C
	public Quaternion rotation; // 0x28
	public SanctuaryType type; // 0x38
	public Item item; // 0x40
	public string parentItemId; // 0x48
	public int stateId; // 0x50
	public int expansionIndex; // 0x54
	public List<int> enlargedAreas; // 0x58
	public List<RoomData> roomData; // 0x60

	// Constructors
	public SanctuaryObjectBaseInfo(int inGridIndex, Vector3 inPosition, Quaternion inRotation, int inStateId); // 0x00000001813645D0-0x0000000181364630
	public SanctuaryObjectBaseInfo(WorldObjectInfoMessage inInfoMessage); // 0x0000000181364200-0x00000001813645D0
}

