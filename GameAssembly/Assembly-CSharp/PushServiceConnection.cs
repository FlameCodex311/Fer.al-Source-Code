/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PushServiceConnection : PersistentServiceConnection // TypeDefIndex: 12647
{
	// Constructors
	public PushServiceConnection(); // 0x0000000180520A40-0x0000000180520A50

	// Methods
	public void Init(ServerEnvironment env); // 0x00000001803774A0-0x00000001803774B0
	protected override void SendConnectMessage(bool success, string error); // 0x0000000180A2C170-0x0000000180A2C1F0
	protected override void SendConnectionLostMessage(); // 0x0000000180A2C1F0-0x0000000180A2C260
	protected override void ListenForAuthorizationMessage(); // 0x0000000180A2C0E0-0x0000000180A2C170
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ListenForAuthorizationMessage>b__3_0(PushServiceAuthMessage m); // 0x0000000180520A30-0x0000000180520A40
}

