/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class RuneSpawnPoint // TypeDefIndex: 10833
{
	// Fields
	public Transform spawnInPosition; // 0x10
	public Transform spawnRestPosition; // 0x18
	public float spawnInTime; // 0x20
	public float resetTime; // 0x24
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RuneGroup <RunePiece>k__BackingField; // 0x28

	// Properties
	public RuneGroup RunePiece { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0

	// Constructors
	public RuneSpawnPoint(); // 0x000000018072ED10-0x000000018072ED30

	// Methods
	public void SpawnInRunePiece(RuneGroup inRunePiece, float inOverrideSpawnInTime = -1f /* Metadata: 0x0077C21D */); // 0x000000018072EC10-0x000000018072ED10
	public void ResetRunePiece(float inOverrideResetTime = -1f /* Metadata: 0x0077C221 */); // 0x000000018072EB30-0x000000018072EC10
	public void Clear(); // 0x000000018072EA80-0x000000018072EB30
}

