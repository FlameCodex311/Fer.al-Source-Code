/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ChatServiceConnection : PersistentServiceConnection // TypeDefIndex: 10970
{
	// Constructors
	public ChatServiceConnection(); // 0x000000018102B7C0-0x000000018102B7D0

	// Methods
	public void Init(ServerEnvironment env); // 0x000000018102B470-0x000000018102B530
	protected override void SendConnectMessage(bool success, string error); // 0x000000018102B6A0-0x000000018102B740
	protected override void SendConnectionLostMessage(); // 0x000000018102B740-0x000000018102B7B0
	protected override void ListenForAuthorizationMessage(); // 0x000000018102B530-0x000000018102B5C0
	protected override void OnAuthorized(); // 0x000000018102B5C0-0x000000018102B600
	protected override void OnConnection(bool success, string error); // 0x000000018102B600-0x000000018102B6A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ListenForAuthorizationMessage>b__3_0(ChatAuthMessage m); // 0x000000018102B7B0-0x000000018102B7C0
}

