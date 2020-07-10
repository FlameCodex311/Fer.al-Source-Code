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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WWTcpClient : IDisposable // TypeDefIndex: 11153
{
	// Fields
	protected Hashtable messageHandlers; // 0x10
	protected string host; // 0x18
	protected int port; // 0x20
	protected TcpClient socketConnection; // 0x28
	private NetworkStream _networkStream; // 0x30
	private SslStream _sslStream; // 0x38
	protected const int READ_BUFFER_SIZE = 4096; // Metadata: 0x007827A6
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
	protected Stream Stream { get; } // 0x0000000180FFD260-0x0000000180FFD280 

	// Constructors
	public WWTcpClient(); // 0x0000000180FFCFE0-0x0000000180FFD110
	public WWTcpClient(bool debug, bool isSecured); // 0x0000000180FFD110-0x0000000180FFD260

	// Methods
	~WWTcpClient(); // 0x000000018036D110-0x000000018036D1B0
	public void Dispose(); // 0x0000000180FFB7E0-0x0000000180FFB850
	protected virtual void Dispose(bool disposing); // 0x0000000180FFB850-0x0000000180FFB890
	public void Connect(string hostAdr, int port); // 0x0000000180FFB0C0-0x0000000180FFB3E0
	private void ConnectThread(); // 0x0000000180FFAD90-0x0000000180FFB0C0
	public virtual void Disconnect(); // 0x0000000180FFB4E0-0x0000000180FFB680
	public void ProcessEventQueue(); // 0x0000000180FFC0B0-0x0000000180FFC320
	public void ProcessSingleEventInEventQueue(); // 0x0000000180FFC320-0x0000000180FFC4D0
	public int NumEventsInEventQueue(); // 0x0000000180FFC080-0x0000000180FFC0B0
	public void SetSocketPollDelay(int delay); // 0x0000000180478850-0x0000000180478860
	internal void __Logout(); // 0x0000000180A166B0-0x0000000180A166D0
	protected void Initialize(); // 0x0000000180FFC060-0x0000000180FFC080
	protected virtual void Initialize(bool isLogOut); // 0x0000000180FFC000-0x0000000180FFC060
	protected virtual void HandleMessage(string msg); // 0x0000000180FFB990-0x0000000180FFBA80
	protected virtual void SendString(string strMessage); // 0x0000000180FFC4D0-0x0000000180FFC4F0
	protected virtual void SendString(string strMessage, bool log); // 0x0000000180FFC4F0-0x0000000180FFC7C0
	protected virtual void HandleSocketConnection(object sender, EventArgs e); // 0x0000000180FFBA80-0x0000000180FFBBB0
	protected virtual void HandleSocketDisconnection(); // 0x0000000180FFBF30-0x0000000180FFC000
	protected virtual void HandleIOError(string originalError); // 0x0000000180FFB930-0x0000000180FFB990
	protected virtual void WriteToSocket(string msg); // 0x0000000180FFCA60-0x0000000180FFCBA0
	protected void HandleSocketData(); // 0x0000000180FFBBB0-0x0000000180FFBF30
	protected void ClearMessageBuffer(); // 0x0000000180FFAD50-0x0000000180FFAD90
	protected ArrayList SplitBufferMessages(); // 0x0000000180FFC7C0-0x0000000180FFCA60
	protected void AddToMessageBuffer(byte[] buf, int count); // 0x0000000180FFAC70-0x0000000180FFAD50
	protected void DispatchConnectionError(string errorMessage); // 0x0000000180FFB680-0x0000000180FFB7B0
	internal void DispatchEvent(WWTcpEvent evt); // 0x0000000180FFB7B0-0x0000000180FFB7E0
	internal void _EnqueueEvent(WWTcpEvent evt); // 0x0000000180FFCF10-0x0000000180FFCFE0
	protected virtual void _DispatchEvent(WWTcpEvent evt); // 0x0000000180FFCBA0-0x0000000180FFCF10
	internal void DebugMessage(string message); // 0x0000000180FFB3E0-0x0000000180FFB4E0
	internal void ErrorTrace(string msg); // 0x0000000180FFB890-0x0000000180FFB930
}

