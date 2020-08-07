/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MothsAndFlamesBetSpotManager : MonoBehaviour // TypeDefIndex: 10736
{
	// Fields
	public MothsAndFlamesBetSpot[] betSpots; // 0x20
	private MothsAndFlamesGame _game; // 0x28
	private MothsAndFlamesBetSpot _selectedBetSpot; // 0x30

	// Properties
	internal MothsAndFlamesBetSpot SelectedBetSpot { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x0000000180C117E0-0x0000000180C11910

	// Constructors
	public MothsAndFlamesBetSpotManager(); // 0x0000000180568C50-0x0000000180569020

	// Methods
	internal void ShowBetSpotIndicators(bool inShow); // 0x0000000180C11640-0x0000000180C116E0
	internal void Init(); // 0x0000000180C11360-0x0000000180C114A0
	internal void SelectedBet(MothsAndFlamesBetSpot inMothsAndFlamesBetSpot); // 0x0000000180C114A0-0x0000000180C11640
	internal void StopGlows(); // 0x0000000180C116E0-0x0000000180C117E0
}

