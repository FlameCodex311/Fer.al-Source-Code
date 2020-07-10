/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x0000000180171D10-0x0000000180171D50
public class Match3TileType : ScriptableObject // TypeDefIndex: 12999
{
	// Fields
	public bool isMatchable; // 0x18
	public Color tileBaseColor; // 0x1C
	[Header] // 0x0000000180171F20-0x0000000180171F50
	public Sprite sprite; // 0x30
	public AnimationClip boosterFlyerVertical; // 0x38
	public AnimationClip boosterFlyerHorizontal; // 0x40
	public AnimationClip boosterTwinTrouble1; // 0x48
	public AnimationClip boosterTwinTrouble2; // 0x50
	public AnimationClip boosterPeacock; // 0x58
	public Sprite blockerEgg; // 0x60
	[Header] // 0x0000000180173430-0x0000000180173460
	public GameObject standardRemovalFxPrefab; // 0x68
	public GameObject twinTroubleremovalFxPrefab; // 0x70
	public GameObject doubleTwinTroubleremovalFxPrefab; // 0x78
	public GameObject FlyerVerticalFxPrefab; // 0x80
	public GameObject FlyerHorizontalFxPrefab; // 0x88
	public GameObject twinTroubleSpawnInFxPrefab; // 0x90
	public GameObject FlyerSpawnInFxPrefab; // 0x98
	public GameObject boosterSpawnInFxPrefab; // 0xA0
	public GameObject boosterActivateFxPrefab; // 0xA8
	public GameObject eggShineFxPrefab; // 0xB0
	public GameObject eggHatchFxPrefab; // 0xB8
	public GameObject clearedByPeacockFxPrefab; // 0xC0
	[Header] // 0x0000000180158150-0x0000000180158180
	public VoidEvent tileTypeAddedEvent; // 0xC8
	public VoidEvent boosterFlyerAddedEvent; // 0xD0
	public VoidEvent boosterTwinTroubleAddedEvent; // 0xD8
	public VoidEvent blockerAddedEvent; // 0xE0
	public VoidEvent tileTypeRemovedEvent; // 0xE8
	public VoidEvent boosterFlyerRemovedEvent; // 0xF0
	public VoidEvent boosterTwinTroubleRemovedEvent; // 0xF8
	public VoidEvent blockerRemovedEvent; // 0x100
	public VoidEvent clearedWithPeacockEvent; // 0x108
	[Header] // 0x00000001801737B0-0x00000001801737E0
	public int firstAvailableLevelNumber; // 0x110

	// Constructors
	public Match3TileType(); // 0x00000001810A3790-0x00000001810A37B0
}

