/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PushServiceConnection : PersistentServiceConnection // TypeDefIndex: 11121
{
	// Constructors
	public PushServiceConnection(); // 0x000000018102B7C0-0x000000018102B7D0

	// Methods
	public void Init(ServerEnvironment env); // 0x00000001803581E0-0x00000001803581F0
	protected override void SendConnectMessage(bool success, string error); // 0x00000001815EE560-0x00000001815EE5E0
	protected override void SendConnectionLostMessage(); // 0x00000001815EE5E0-0x00000001815EE650
	protected override void ListenForAuthorizationMessage(); // 0x00000001815EE4D0-0x00000001815EE560
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ListenForAuthorizationMessage>b__3_0(PushServiceAuthMessage m); // 0x000000018102B7B0-0x000000018102B7C0
}

