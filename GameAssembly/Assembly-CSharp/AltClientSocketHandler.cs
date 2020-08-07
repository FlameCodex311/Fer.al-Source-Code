/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class AltClientSocketHandler // TypeDefIndex: 10385
{
	// Fields
	protected readonly TcpClient client; // 0x10
	protected readonly string separatorSequence; // 0x18
	protected readonly char[] separatorSequenceChars; // 0x20
	protected readonly Encoding encoding; // 0x28
	protected AltIClientSocketHandlerDelegate clientSocketHandlerDelegate; // 0x30

	// Constructors
	public AltClientSocketHandler(TcpClient client, AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, string separatorString, Encoding encoding); // 0x000000018214E290-0x000000018214E300

	// Methods
	public void Cleanup(); // 0x000000018214DCB0-0x000000018214DCD0
	public void SendResponse(string response); // 0x000000018214E1A0-0x000000018214E290
	public void Run(); // 0x000000018214DCD0-0x000000018214E1A0
}

