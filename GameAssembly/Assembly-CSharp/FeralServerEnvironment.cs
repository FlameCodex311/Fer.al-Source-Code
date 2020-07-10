/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800B36B0-0x00000001800B36C0
public class FeralServerEnvironment : ServerEnvironment // TypeDefIndex: 10893
{
	// Fields
	[Header] // 0x00000001800F4DF0-0x00000001800F4E20
	public string directorHost; // 0x50
	public string paymentsServiceHost; // 0x58
	public string serviceApiHost; // 0x60
	[Space] // 0x00000001800F4F60-0x00000001800F4F70
	public string chatHost; // 0x68
	public int chatPort; // 0x70
	[Header] // 0x00000001800F5160-0x00000001800F5190
	public string jamNetHost; // 0x78
	[Header] // 0x00000001800F52C0-0x00000001800F5340
	[Range] // 0x00000001800F52C0-0x00000001800F5340
	[Tooltip] // 0x00000001800F52C0-0x00000001800F5340
	public float simulatedPacketLoss; // 0x80
	[Range] // 0x00000001800F5680-0x00000001800F56D0
	[Tooltip] // 0x00000001800F5680-0x00000001800F56D0
	public float simulatedMinimumLatency; // 0x84
	[Range] // 0x00000001800F5900-0x00000001800F5950
	[Tooltip] // 0x00000001800F5900-0x00000001800F5950
	public float simulatedRandomLatency; // 0x88

	// Constructors
	public FeralServerEnvironment(); // 0x00000001805E3F50-0x00000001805E3F60
}

