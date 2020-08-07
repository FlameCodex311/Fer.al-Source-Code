/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801CDAD0-0x00000001801CDAE0
public class FeralServerEnvironment : ServerEnvironment // TypeDefIndex: 12416
{
	// Fields
	[Header] // 0x00000001801CF020-0x00000001801CF050
	public string directorHost; // 0x50
	public string paymentsServiceHost; // 0x58
	public string serviceApiHost; // 0x60
	[Space] // 0x00000001801CF290-0x00000001801CF2A0
	public string chatHost; // 0x68
	public int chatPort; // 0x70
	[Header] // 0x00000001801CF2A0-0x00000001801CF2D0
	public string jamNetHost; // 0x78
	[Header] // 0x00000001801CF550-0x00000001801CF5D0
	[Range] // 0x00000001801CF550-0x00000001801CF5D0
	[Tooltip] // 0x00000001801CF550-0x00000001801CF5D0
	public float simulatedPacketLoss; // 0x80
	[Range] // 0x00000001801CF7C0-0x00000001801CF810
	[Tooltip] // 0x00000001801CF7C0-0x00000001801CF810
	public float simulatedMinimumLatency; // 0x84
	[Range] // 0x00000001801CF980-0x00000001801CF9D0
	[Tooltip] // 0x00000001801CF980-0x00000001801CF9D0
	public float simulatedRandomLatency; // 0x88

	// Constructors
	public FeralServerEnvironment(); // 0x000000018069E0F0-0x000000018069E100
}

