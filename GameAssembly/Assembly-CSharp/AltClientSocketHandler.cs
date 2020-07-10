/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AltClientSocketHandler // TypeDefIndex: 12728
{
	// Fields
	protected readonly TcpClient client; // 0x10
	protected readonly string separatorSequence; // 0x18
	protected readonly char[] separatorSequenceChars; // 0x20
	protected readonly Encoding encoding; // 0x28
	protected AltIClientSocketHandlerDelegate clientSocketHandlerDelegate; // 0x30

	// Constructors
	public AltClientSocketHandler(TcpClient client, AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, string separatorString, Encoding encoding); // 0x0000000181034E30-0x0000000181034EA0

	// Methods
	public void Cleanup(); // 0x0000000181034830-0x0000000181034850
	public void SendResponse(string response); // 0x0000000181034D40-0x0000000181034E30
	public void Run(); // 0x0000000181034850-0x0000000181034D40
}

