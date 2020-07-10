/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PersistentServiceClient : WWTcpClient // TypeDefIndex: 11118
{
	// Constructors
	public PersistentServiceClient(bool debug, bool isSecured); // 0x0000000181173F30-0x0000000181173F40

	// Methods
	~PersistentServiceClient(); // 0x0000000180EC0080-0x0000000180EC0120
	public void SendAuth(string token, string uuid); // 0x0000000181173D40-0x0000000181173E00
	public void Send(PersistentServiceRequest req); // 0x0000000180EC0470-0x0000000180EC04C0
	protected override void WriteToSocket(string msg); // 0x0000000181173E00-0x0000000181173F30
	protected override void HandleMessage(string msg); // 0x0000000181173AC0-0x0000000181173D40
}

