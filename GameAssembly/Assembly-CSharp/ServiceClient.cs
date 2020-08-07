/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ServiceClient : WWTcpClient // TypeDefIndex: 12649
{
	// Constructors
	public ServiceClient(bool debug); // 0x00000001803FF2E0-0x00000001803FF2F0

	// Methods
	~ServiceClient(); // 0x00000001803FED90-0x00000001803FEE30
	public void SendAuth(string token, string uuid); // 0x00000001803FF090-0x00000001803FF160
	public void Send(ServiceRequest req); // 0x00000001803FF160-0x00000001803FF1B0
	protected override void WriteToSocket(string msg); // 0x00000001803FF1B0-0x00000001803FF2E0
	protected override void HandleMessage(string msg); // 0x00000001803FEE30-0x00000001803FF090
}

