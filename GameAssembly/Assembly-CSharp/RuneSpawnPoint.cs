/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class RuneSpawnPoint // TypeDefIndex: 13168
{
	// Fields
	public Transform spawnInPosition; // 0x10
	public Transform spawnRestPosition; // 0x18
	public float spawnInTime; // 0x20
	public float resetTime; // 0x24
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RuneGroup <RunePiece>k__BackingField; // 0x28

	// Properties
	public RuneGroup RunePiece { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40

	// Constructors
	public RuneSpawnPoint(); // 0x0000000180FD3610-0x0000000180FD3630

	// Methods
	public void SpawnInRunePiece(RuneGroup inRunePiece, float inOverrideSpawnInTime = -1f /* Metadata: 0x00783762 */); // 0x0000000180FD3500-0x0000000180FD3610
	public void ResetRunePiece(float inOverrideResetTime = -1f /* Metadata: 0x00783766 */); // 0x0000000180FD3420-0x0000000180FD3500
	public void Clear(); // 0x0000000180FD3370-0x0000000180FD3420
}

