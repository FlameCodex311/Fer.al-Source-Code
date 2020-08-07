/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WWTcpClient : IDisposable // TypeDefIndex: 12653
{
	// Fields
	protected Hashtable messageHandlers; // 0x10
	protected string host; // 0x18
	protected int port; // 0x20
	protected TcpClient socketConnection; // 0x28
	private NetworkStream _networkStream; // 0x30
	private SslStream _sslStream; // 0x38
	protected const int READ_BUFFER_SIZE = 4096; // Metadata: 0x007B9F2A
	protected byte[] byteBuffer; // 0x40
	protected byte[] messageBuffer; // 0x48
	protected int socketPollSleep; // 0x50
	protected bool connected; // 0x54
	protected bool connecting; // 0x55
	protected Thread thrSocketReader; // 0x58
	protected Thread thrConnect; // 0x60
	protected Thread thrHttpPoll; // 0x68
	protected Queue _queuedEvents; // 0x70
	protected object _queuedEventsLocker; // 0x78
	protected DateTime benchStartTime; // 0x80
	protected int majVersion; // 0x88
	protected int minVersion; // 0x8C
	protected int subVersion; // 0x90
	protected bool isDisposed; // 0x94
	private bool _isSecured; // 0x95
	public WWTcpEvent.OnConnectionDelegate onConnection; // 0x98
	public WWTcpEvent.OnConnectionLostDelegate onConnectionLost; // 0xA0
	public WWTcpEvent.OnMessageReceivedDelegate onMessageReceived; // 0xA8
	public WWTcpEvent.OnDebugMessageDelegate onDebugMessage; // 0xB0
	public bool runInQueueMode; // 0xB8
	public bool debugMode; // 0xB9
	protected object disconnectionLocker; // 0xC0

	// Properties
	protected Stream Stream { get; } // 0x00000001805E44F0-0x00000001805E4510 

	// Constructors
	public WWTcpClient(); // 0x00000001805E4270-0x00000001805E43A0
	public WWTcpClient(bool debug, bool isSecured); // 0x00000001805E43A0-0x00000001805E44F0

	// Methods
	~WWTcpClient(); // 0x000000018041BC40-0x000000018041BCE0
	public void Dispose(); // 0x00000001805E2AB0-0x00000001805E2B20
	protected virtual void Dispose(bool disposing); // 0x00000001805E2B20-0x00000001805E2B60
	public void Connect(string hostAdr, int port); // 0x00000001805E23C0-0x00000001805E26C0
	private void ConnectThread(); // 0x00000001805E20A0-0x00000001805E23C0
	public virtual void Disconnect(); // 0x00000001805E27B0-0x00000001805E2950
	public void ProcessEventQueue(); // 0x00000001805E3370-0x00000001805E35E0
	public void ProcessSingleEventInEventQueue(); // 0x00000001805E35E0-0x00000001805E3790
	public int NumEventsInEventQueue(); // 0x00000001805E3340-0x00000001805E3370
	public void SetSocketPollDelay(int delay); // 0x00000001803F82F0-0x00000001803F8300
	internal void __Logout(); // 0x00000001805E4250-0x00000001805E4270
	protected void Initialize(); // 0x00000001805E3320-0x00000001805E3340
	protected virtual void Initialize(bool isLogOut); // 0x00000001805E32C0-0x00000001805E3320
	protected virtual void HandleMessage(string msg); // 0x00000001805E2C60-0x00000001805E2D50
	protected virtual void SendString(string strMessage); // 0x00000001805E3790-0x00000001805E37B0
	protected virtual void SendString(string strMessage, bool log); // 0x00000001805E37B0-0x00000001805E3A60
	protected virtual void HandleSocketConnection(object sender, EventArgs e); // 0x00000001805E2D50-0x00000001805E2E80
	protected virtual void HandleSocketDisconnection(); // 0x00000001805E31F0-0x00000001805E32C0
	protected virtual void HandleIOError(string originalError); // 0x00000001805E2C00-0x00000001805E2C60
	protected virtual void WriteToSocket(string msg); // 0x00000001805E3CE0-0x00000001805E3E20
	protected void HandleSocketData(); // 0x00000001805E2E80-0x00000001805E31F0
	protected void ClearMessageBuffer(); // 0x00000001805E2060-0x00000001805E20A0
	protected ArrayList SplitBufferMessages(); // 0x00000001805E3A60-0x00000001805E3CE0
	protected void AddToMessageBuffer(byte[] buf, int count); // 0x00000001805E1F90-0x00000001805E2060
	protected void DispatchConnectionError(string errorMessage); // 0x00000001805E2950-0x00000001805E2A80
	internal void DispatchEvent(WWTcpEvent evt); // 0x00000001805E2A80-0x00000001805E2AB0
	internal void _EnqueueEvent(WWTcpEvent evt); // 0x00000001805E4180-0x00000001805E4250
	protected virtual void _DispatchEvent(WWTcpEvent evt); // 0x00000001805E3E20-0x00000001805E4180
	internal void DebugMessage(string message); // 0x00000001805E26C0-0x00000001805E27B0
	internal void ErrorTrace(string msg); // 0x00000001805E2B60-0x00000001805E2C00
}

