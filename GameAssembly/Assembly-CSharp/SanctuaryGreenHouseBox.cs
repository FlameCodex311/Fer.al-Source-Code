/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SanctuaryGreenHouseBox : ManagedBehaviour // TypeDefIndex: 13265
{
	// Fields
	public SanctuaryGreenHousePlot[] plots; // 0x50
	public EType type; // 0x58
	public EType boxType; // 0x5C
	public int boxIndex; // 0x60
	private Transform _group; // 0x68

	// Properties
	public Transform group { get; } // 0x00000001807AF9D0-0x00000001807AFA90 

	// Nested types
	public enum EType // TypeDefIndex: 13266
	{
		None = 0,
		Planter = 1,
		Community = 2
	}

	// Constructors
	public SanctuaryGreenHouseBox(); // 0x00000001807AF970-0x00000001807AF9D0

	// Methods
	public static SanctuaryGreenHouseBox Create(Transform inParent, string inPlotName, int inBoxIndex, EType inType); // 0x00000001807AF140-0x00000001807AF260
	public void Setup(string inPlotName, int inBoxIndex, EType inType); // 0x00000001807AF600-0x00000001807AF850
	private bool Unlocked(); // 0x00000001807AF8C0-0x00000001807AF970
	private void OnGUI(); // 0x00000001807AF260-0x00000001807AF600
	private void Unlock(); // 0x00000001807AF850-0x00000001807AF8C0
}

