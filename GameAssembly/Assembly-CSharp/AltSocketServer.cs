/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class AltSocketServer // TypeDefIndex: 10390
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
	public int PortNumber { get; } // 0x000000018057D1C0-0x000000018057D1D0 
	public IPEndPoint LocalEndPoint { get; } // 0x00000001803C7290-0x00000001803C72A0 
	public int MaxClients { get; } // 0x0000000180379ED0-0x0000000180379EE0 
	public int ClientCount { get; } // 0x000000018214F290-0x000000018214F2C0 

	// Constructors
	public AltSocketServer(AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, int portNumber = 13000 /* Metadata: 0x0077BAE1 */, int maxClients = 1 /* Metadata: 0x0077BAE5 */, string separatorString = "\n" /* Metadata: 0x0077BAE9 */, Encoding encoding = null); // 0x000000018214F110-0x000000018214F290

	// Methods
	public void StartListeningForConnections(); // 0x000000018214F020-0x000000018214F0A0
	protected void ListenForConnection(); // 0x000000018214EF90-0x000000018214F020
	protected void AcceptCallback(IAsyncResult ar); // 0x000000018214E580-0x000000018214EC70
	public void StopListeningForConnections(); // 0x000000018214F0A0-0x000000018214F110
	public void Cleanup(); // 0x000000018214EC70-0x000000018214EF80
	public bool IsStarted(); // 0x000000018214EF80-0x000000018214EF90
}

