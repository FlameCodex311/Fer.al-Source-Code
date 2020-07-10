/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WWTcpEvent // TypeDefIndex: 11154
{
	// Fields
	internal const string onConnectionEvent = "OnConnection"; // Metadata: 0x007827AA
	internal const string onConnectionLostEvent = "OnConnectionLost"; // Metadata: 0x007827BA
	internal const string onMessageEvent = "OnMessage"; // Metadata: 0x007827CE
	internal const string onDebugMessageEvent = "OnDebugMessage"; // Metadata: 0x007827DB
	protected string type; // 0x10
	protected Hashtable parameters; // 0x18

	// Nested types
	public delegate void OnConnectionDelegate(bool success, string error); // TypeDefIndex: 11155; 0x0000000180FE6470-0x0000000180FE6760

	public delegate void OnConnectionLostDelegate(); // TypeDefIndex: 11156; 0x00000001804C7D50-0x00000001804C7EF0

	public delegate void OnMessageReceivedDelegate(string message); // TypeDefIndex: 11157; 0x000000018055D3E0-0x000000018055D680

	public delegate void OnDebugMessageDelegate(string message); // TypeDefIndex: 11158; 0x000000018055D3E0-0x000000018055D680

	// Constructors
	public WWTcpEvent(string type, Hashtable parameters); // 0x00000001803DA900-0x00000001803DA940

	// Methods
	public new string GetType(); // 0x000000018036AC80-0x000000018036AC90
	public object GetParameter(string key); // 0x0000000180F56920-0x0000000180F56950
}

