/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ServiceClient : WWTcpClient // TypeDefIndex: 11123
{
	// Constructors
	public ServiceClient(bool debug); // 0x0000000180EC05F0-0x0000000180EC0600

	// Methods
	~ServiceClient(); // 0x0000000180EC0080-0x0000000180EC0120
	public void SendAuth(string token, string uuid); // 0x0000000180EC03A0-0x0000000180EC0470
	public void Send(ServiceRequest req); // 0x0000000180EC0470-0x0000000180EC04C0
	protected override void WriteToSocket(string msg); // 0x0000000180EC04C0-0x0000000180EC05F0
	protected override void HandleMessage(string msg); // 0x0000000180EC0120-0x0000000180EC03A0
}

