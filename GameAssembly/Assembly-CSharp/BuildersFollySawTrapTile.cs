/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollySawTrapTile : BuildersFollyTile // TypeDefIndex: 12828
{
	// Fields
	public Transform sawBlade; // 0xF8
	internal int currentGridIndex; // 0x100
	internal static bool resourceCollectingDone; // 0x00
	internal bool movingForward; // 0x104
	private BuildersFollyGame _game; // 0x108
	private Vector3 _startPos; // 0x110

	// Constructors
	public BuildersFollySawTrapTile(); // 0x00000001813C3250-0x00000001813C3260
	static BuildersFollySawTrapTile(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	private new void Start(); // 0x00000001813C2A80-0x00000001813C2B20
	internal void UpdateMove(); // 0x00000001813C30C0-0x00000001813C3250
	internal void UpdateGridPoint(); // 0x00000001813C2F80-0x00000001813C30C0
	private BuildersFollyTwiggle TwiggleTrapChq(); // 0x00000001813C2B20-0x00000001813C2F70
	internal void ResetTrap(); // 0x00000001813C29D0-0x00000001813C2A80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__6_0(); // 0x00000001813C2F70-0x00000001813C2F80
}

