/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WWTcpEvent // TypeDefIndex: 12654
{
	// Fields
	internal const string onConnectionEvent = "OnConnection"; // Metadata: 0x007B9F2E
	internal const string onConnectionLostEvent = "OnConnectionLost"; // Metadata: 0x007B9F3E
	internal const string onMessageEvent = "OnMessage"; // Metadata: 0x007B9F52
	internal const string onDebugMessageEvent = "OnDebugMessage"; // Metadata: 0x007B9F5F
	protected string type; // 0x10
	protected Hashtable parameters; // 0x18

	// Nested types
	public delegate void OnConnectionDelegate(bool success, string error); // TypeDefIndex: 12655; 0x00000001805CFD20-0x00000001805D0030

	public delegate void OnConnectionLostDelegate(); // TypeDefIndex: 12656; 0x00000001803FE8A0-0x00000001803FEA40

	public delegate void OnMessageReceivedDelegate(string message); // TypeDefIndex: 12657; 0x00000001805D0030-0x00000001805D0300

	public delegate void OnDebugMessageDelegate(string message); // TypeDefIndex: 12658; 0x00000001805D0030-0x00000001805D0300

	// Constructors
	public WWTcpEvent(string type, Hashtable parameters); // 0x0000000180372010-0x00000001803720F0

	// Methods
	public new string GetType(); // 0x0000000180372440-0x0000000180372450
	public object GetParameter(string key); // 0x00000001805E4510-0x00000001805E4540
}

