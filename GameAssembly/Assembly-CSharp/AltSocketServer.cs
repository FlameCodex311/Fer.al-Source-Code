/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AltSocketServer // TypeDefIndex: 12733
{
	// Fields
	protected readonly AltTcpListener listener; // 0x10
	protected readonly AltIClientSocketHandlerDelegate clientSocketHandlerDelegate; // 0x18
	protected readonly string separatorString; // 0x20
	protected readonly Encoding encoding; // 0x28
	protected ArrayList clientHandlerThreads; // 0x30
	protected readonly int portNumber; // 0x38
	protected readonly IPEndPoint localEndPoint; // 0x40
	protected readonly int maxClients; // 0x48

	// Properties
	public int PortNumber { get; } // 0x00000001804999D0-0x00000001804999E0 
	public IPEndPoint LocalEndPoint { get; } // 0x0000000180369B30-0x0000000180369B40 
	public int MaxClients { get; } // 0x0000000180384C10-0x0000000180384C20 
	public int ClientCount { get; } // 0x0000000181035E70-0x0000000181035EA0 

	// Constructors
	public AltSocketServer(AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, int portNumber = 13000 /* Metadata: 0x00783036 */, int maxClients = 1 /* Metadata: 0x0078303A */, string separatorString = "\n" /* Metadata: 0x0078303E */, Encoding encoding = null); // 0x0000000181035CF0-0x0000000181035E70

	// Methods
	public void StartListeningForConnections(); // 0x0000000181035C00-0x0000000181035C80
	protected void ListenForConnection(); // 0x0000000181035B70-0x0000000181035C00
	protected void AcceptCallback(IAsyncResult ar); // 0x0000000181035120-0x0000000181035850
	public void StopListeningForConnections(); // 0x0000000181035C80-0x0000000181035CF0
	public void Cleanup(); // 0x0000000181035850-0x0000000181035B60
	public bool IsStarted(); // 0x0000000181035B60-0x0000000181035B70
}

