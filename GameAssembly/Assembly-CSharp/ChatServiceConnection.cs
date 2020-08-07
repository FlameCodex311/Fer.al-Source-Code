/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChatServiceConnection : PersistentServiceConnection // TypeDefIndex: 12493
{
	// Constructors
	public ChatServiceConnection(); // 0x0000000180520A40-0x0000000180520A50

	// Methods
	public void Init(ServerEnvironment env); // 0x0000000180520700-0x00000001805207C0
	protected override void SendConnectMessage(bool success, string error); // 0x0000000180520930-0x00000001805209C0
	protected override void SendConnectionLostMessage(); // 0x00000001805209C0-0x0000000180520A30
	protected override void ListenForAuthorizationMessage(); // 0x00000001805207C0-0x0000000180520850
	protected override void OnAuthorized(); // 0x0000000180520850-0x0000000180520890
	protected override void OnConnection(bool success, string error); // 0x0000000180520890-0x0000000180520930
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ListenForAuthorizationMessage>b__3_0(ChatAuthMessage m); // 0x0000000180520A30-0x0000000180520A40
}

