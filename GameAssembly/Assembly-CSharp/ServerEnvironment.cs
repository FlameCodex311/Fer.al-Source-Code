/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801CDAD0-0x00000001801CDAE0
public class ServerEnvironment : ScriptableObject // TypeDefIndex: 11220
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <OverrideGameServerHost>k__BackingField; // 0x4E

	// Properties
	public bool IsIngress { get; } // 0x00000001803FEC10-0x00000001803FEC30 
	public bool OverrideGameServerHost { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FEC30-0x00000001803FEC40 0x00000001803FEC40-0x00000001803FEC50

	// Constructors
	public ServerEnvironment(); // 0x00000001803FEC00-0x00000001803FEC10

	// Methods
	private void OnEnable(); // 0x00000001803FEB80-0x00000001803FEBB0
	public override string ToString(); // 0x00000001803FEBB0-0x00000001803FEC00
}

