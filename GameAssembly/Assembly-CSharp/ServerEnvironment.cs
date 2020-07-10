/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800B36B0-0x00000001800B36C0
public class ServerEnvironment : ScriptableObject // TypeDefIndex: 13549
{
	// Fields
	public ServerTier tier; // 0x18
	public string webAPIHost; // 0x20
	public string ingressHost; // 0x28
	public string gameServerHost; // 0x30
	public int gameServerPort; // 0x38
	public string blueboxHost; // 0x40
	public int blueboxPort; // 0x48
	public bool isDebug; // 0x4C
	public bool useSecure; // 0x4D
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <OverrideGameServerHost>k__BackingField; // 0x4E

	// Properties
	public bool IsIngress { get; } // 0x0000000180EBFEC0-0x0000000180EBFEE0 
	public bool OverrideGameServerHost { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EBFEE0-0x0000000180EBFEF0 0x0000000180EBFEF0-0x0000000180EBFF00

	// Constructors
	public ServerEnvironment(); // 0x00000001803A2BB0-0x00000001803A2BC0

	// Methods
	private void OnEnable(); // 0x0000000180EBFE40-0x0000000180EBFE70
	public override string ToString(); // 0x0000000180EBFE70-0x0000000180EBFEC0
}

