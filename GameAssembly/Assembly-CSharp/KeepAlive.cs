/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801D1400-0x00000001801D1430
public class KeepAlive : ManagedBehaviour // TypeDefIndex: 12436
{
	// Fields
	private int KICK_INTERVAL_SEC; // 0x50
	private int WARNING_INTERVAL_SEC; // 0x54
	private int SEND_INTERVAL_SEC; // 0x58
	private int SEND_INTERVAL_SEC_MINIGAME; // 0x5C
	private float _elapsedTime; // 0x60
	private bool _warningSent; // 0x64
	private bool _sendKeepAliveMessageNextSendInterval; // 0x65

	// Properties
	public bool IsUserIdleForLongTime { get; } // 0x000000018087A820-0x000000018087A840 

	// Constructors
	public KeepAlive(); // 0x000000018087A7B0-0x000000018087A820

	// Methods
	public override void MStart(); // 0x000000018087A1E0-0x000000018087A270
	public override void MOnDestroy(); // 0x00000001803774A0-0x00000001803774B0
	public override void MUpdate(); // 0x000000018087A270-0x000000018087A5A0
	private void RestartKeepAlive(); // 0x000000018087A610-0x000000018087A670
	private void SendKeepAlive(); // 0x000000018087A670-0x000000018087A6F0
	private void OnTouchReceived(); // 0x000000018087A5A0-0x000000018087A610
	private void WarnUserAboutLoomingKickage(); // 0x000000018087A6F0-0x000000018087A7B0
}

