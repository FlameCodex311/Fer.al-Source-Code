/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollySawTrapTile : BuildersFollyTile // TypeDefIndex: 10486
{
	// Fields
	public Transform sawBlade; // 0xF8
	internal int currentGridIndex; // 0x100
	internal static bool resourceCollectingDone; // 0x00
	internal bool movingForward; // 0x104
	private BuildersFollyGame _game; // 0x108
	private Vector3 _startPos; // 0x110

	// Constructors
	public BuildersFollySawTrapTile(); // 0x0000000180AB3690-0x0000000180AB36A0
	static BuildersFollySawTrapTile(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	private new void Start(); // 0x0000000180AB2EF0-0x0000000180AB2F90
	internal void UpdateMove(); // 0x0000000180AB3500-0x0000000180AB3690
	internal void UpdateGridPoint(); // 0x0000000180AB33C0-0x0000000180AB3500
	private BuildersFollyTwiggle TwiggleTrapChq(); // 0x0000000180AB2F90-0x0000000180AB33B0
	internal void ResetTrap(); // 0x0000000180AB2E40-0x0000000180AB2EF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__6_0(); // 0x0000000180AB33B0-0x0000000180AB33C0
}

