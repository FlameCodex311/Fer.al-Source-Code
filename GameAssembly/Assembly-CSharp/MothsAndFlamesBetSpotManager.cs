/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MothsAndFlamesBetSpotManager : MonoBehaviour // TypeDefIndex: 13071
{
	// Fields
	public MothsAndFlamesBetSpot[] betSpots; // 0x20
	private MothsAndFlamesGame _game; // 0x28
	private MothsAndFlamesBetSpot _selectedBetSpot; // 0x30

	// Properties
	internal MothsAndFlamesBetSpot SelectedBetSpot { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001812DE610-0x00000001812DE6E0

	// Constructors
	public MothsAndFlamesBetSpotManager(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	internal void ShowBetSpotIndicators(bool inShow); // 0x00000001812DE470-0x00000001812DE510
	internal void Init(); // 0x00000001812DE180-0x00000001812DE2D0
	internal void SelectedBet(MothsAndFlamesBetSpot inMothsAndFlamesBetSpot); // 0x00000001812DE2D0-0x00000001812DE470
	internal void StopGlows(); // 0x00000001812DE510-0x00000001812DE610
}

