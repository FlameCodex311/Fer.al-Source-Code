/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_TabStop : ManagedBehaviour // TypeDefIndex: 13649
{
	// Fields
	private static bool _hasTabbed; // 0x00
	public NavigationMode navigation; // 0x50
	public Selectable manualPrevious; // 0x58
	public List<Selectable> manualPreviousCandidates; // 0x60
	public Selectable manualNext; // 0x68
	public List<Selectable> manualNextCandidates; // 0x70
	private Selectable _selectable; // 0x78

	// Nested types
	[Serializable]
	public enum NavigationMode // TypeDefIndex: 13650
	{
		Vertical = 0,
		Horizontal = 1,
		Manual = 2
	}

	// Constructors
	public UI_TabStop(); // 0x0000000180F92690-0x0000000180F926F0
	static UI_TabStop(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public override void MOnEnable(); // 0x0000000180F921D0-0x0000000180F92210
	public override void MUpdate(); // 0x0000000180F92210-0x0000000180F92510
	private Selectable PickFromCandidates(List<Selectable> inCandidates); // 0x0000000180F92510-0x0000000180F92690
	private void LateUpdate(); // 0x0000000180F92170-0x0000000180F921D0
}

