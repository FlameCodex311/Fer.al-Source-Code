/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PersistentServiceClient : WWTcpClient // TypeDefIndex: 12644
{
	// Constructors
	public PersistentServiceClient(bool debug, bool isSecured); // 0x00000001804E0FF0-0x00000001804E1000

	// Methods
	~PersistentServiceClient(); // 0x00000001803FED90-0x00000001803FEE30
	public void SendAuth(string token, string uuid); // 0x00000001804E0DF0-0x00000001804E0EC0
	public void Send(PersistentServiceRequest req); // 0x00000001803FF160-0x00000001803FF1B0
	protected override void WriteToSocket(string msg); // 0x00000001804E0EC0-0x00000001804E0FF0
	protected override void HandleMessage(string msg); // 0x00000001804E0B90-0x00000001804E0DF0
}

