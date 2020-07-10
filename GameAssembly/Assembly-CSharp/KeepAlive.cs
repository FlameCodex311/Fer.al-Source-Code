/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800F7BB0-0x00000001800F7BE0
public class KeepAlive : ManagedBehaviour // TypeDefIndex: 10913
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
	public bool IsUserIdleForLongTime { get; } // 0x00000001812CB570-0x00000001812CB590 

	// Constructors
	public KeepAlive(); // 0x00000001812CB500-0x00000001812CB570

	// Methods
	public override void MStart(); // 0x00000001812CAF20-0x00000001812CAFB0
	public override void MOnDestroy(); // 0x00000001803581E0-0x00000001803581F0
	public override void MUpdate(); // 0x00000001812CAFB0-0x00000001812CB2F0
	private void RestartKeepAlive(); // 0x00000001812CB360-0x00000001812CB3C0
	private void SendKeepAlive(); // 0x00000001812CB3C0-0x00000001812CB440
	private void OnTouchReceived(); // 0x00000001812CB2F0-0x00000001812CB360
	private void WarnUserAboutLoomingKickage(); // 0x00000001812CB440-0x00000001812CB500
}

