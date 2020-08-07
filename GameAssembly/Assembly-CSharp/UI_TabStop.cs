/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_TabStop : ManagedBehaviour // TypeDefIndex: 11316
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
	public enum NavigationMode // TypeDefIndex: 11317
	{
		Vertical = 0,
		Horizontal = 1,
		Manual = 2
	}

	// Constructors
	public UI_TabStop(); // 0x00000001804D3350-0x00000001804D33B0
	static UI_TabStop(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public override void MOnEnable(); // 0x00000001804D2EB0-0x00000001804D2EF0
	public override void MUpdate(); // 0x00000001804D2EF0-0x00000001804D31E0
	private Selectable PickFromCandidates(List<Selectable> inCandidates); // 0x00000001804D31E0-0x00000001804D3350
	private void LateUpdate(); // 0x00000001804D2E50-0x00000001804D2EB0
}

