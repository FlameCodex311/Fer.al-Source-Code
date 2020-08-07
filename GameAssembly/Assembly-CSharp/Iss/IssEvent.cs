/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Iss.Data;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss
{
	public class IssEvent : WWTcpEvent // TypeDefIndex: 14372
	{
		// Fields
		internal const string onExtensionResponseEvent = "OnExtensionResponse"; // Metadata: 0x007BA7F3
		internal const string onLoginEvent = "OnLogin"; // Metadata: 0x007BA80A
		internal const string onLogoutEvent = "OnLogout"; // Metadata: 0x007BA815
		internal const string onObjectReceivedEvent = "OnObjectReceived"; // Metadata: 0x007BA821
		internal const string onPublicMessageEvent = "OnPublicMessage"; // Metadata: 0x007BA835
		internal const string onRandomKeyEvent = "OnRandomKey"; // Metadata: 0x007BA848
		internal const string onRoomListUpdateEvent = "OnRoomListUpdate"; // Metadata: 0x007BA857
	
		// Nested types
		public delegate void OnAdminMessageDelegate(string message); // TypeDefIndex: 14373; 0x00000001805D0030-0x00000001805D0300
	
		public delegate void OnExtensionResponseDelegate(object dataObj, IssClient.XtMsgType type); // TypeDefIndex: 14374; 0x0000000180880100-0x00000001808805A0
	
		public delegate void OnJoinRoomDelegate(Room room); // TypeDefIndex: 14375; 0x00000001803F4920-0x00000001803F4CE0
	
		public delegate void OnJoinRoomErrorDelegate(string error); // TypeDefIndex: 14376; 0x00000001805D0030-0x00000001805D0300
	
		public delegate void OnLoginDelegate(bool success, string name, string error); // TypeDefIndex: 14377; 0x0000000180880630-0x0000000180880960
	
		public delegate void OnLogoutDelegate(); // TypeDefIndex: 14378; 0x00000001803FE8A0-0x00000001803FEA40
	
		public delegate void OnRandomKeyDelegate(string key); // TypeDefIndex: 14379; 0x00000001805D0030-0x00000001805D0300
	
		public delegate void OnRoomListUpdateDelegate(Hashtable roomList); // TypeDefIndex: 14380; 0x00000001803F4920-0x00000001803F4CE0
	
		// Constructors
		public IssEvent(string type, Hashtable parameters); // 0x0000000180874180-0x0000000180874190
	}
}
