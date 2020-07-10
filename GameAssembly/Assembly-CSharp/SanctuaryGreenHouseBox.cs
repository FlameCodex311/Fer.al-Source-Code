/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SanctuaryGreenHouseBox : ManagedBehaviour // TypeDefIndex: 11736
{
	// Fields
	public SanctuaryGreenHousePlot[] plots; // 0x50
	public EType type; // 0x58
	public Transform cameraMount; // 0x60
	public Transform cameraTarget; // 0x68
	private EType _type; // 0x70
	private int _boxIndex; // 0x74
	private Transform _group; // 0x78

	// Properties
	public Transform group { get; } // 0x00000001812870F0-0x00000001812871B0 

	// Nested types
	public enum EType // TypeDefIndex: 11737
	{
		None = 0,
		Planter = 1,
		Community = 2
	}

	// Constructors
	public SanctuaryGreenHouseBox(); // 0x0000000181287090-0x00000001812870F0

	// Methods
	public static SanctuaryGreenHouseBox Create(Transform inParent, int inBoxIndex, EType inType, Transform inCamMount, Transform inCamTarget); // 0x0000000181286AE0-0x0000000181286B90
	public void Setup(int inBoxIndex, EType inType, Transform inCamMount, Transform inCamTarget); // 0x0000000181286F40-0x0000000181286F60
	private bool Unlocked(); // 0x0000000181286FD0-0x0000000181287090
	private void OnGUI(); // 0x0000000181286B90-0x0000000181286F40
	private void Unlock(); // 0x0000000181286F60-0x0000000181286FD0
}

