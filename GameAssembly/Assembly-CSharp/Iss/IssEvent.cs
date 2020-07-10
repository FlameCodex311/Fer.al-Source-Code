/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Iss.Data;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss
{
	public class IssEvent : WWTcpEvent // TypeDefIndex: 15985
	{
		// Fields
		internal const string onExtensionResponseEvent = "OnExtensionResponse"; // Metadata: 0x007850C9
		internal const string onLoginEvent = "OnLogin"; // Metadata: 0x007850E0
		internal const string onLogoutEvent = "OnLogout"; // Metadata: 0x007850EB
		internal const string onObjectReceivedEvent = "OnObjectReceived"; // Metadata: 0x007850F7
		internal const string onPublicMessageEvent = "OnPublicMessage"; // Metadata: 0x0078510B
		internal const string onRandomKeyEvent = "OnRandomKey"; // Metadata: 0x0078511E
		internal const string onRoomListUpdateEvent = "OnRoomListUpdate"; // Metadata: 0x0078512D
	
		// Nested types
		public delegate void OnAdminMessageDelegate(string message); // TypeDefIndex: 15986; 0x000000018055D3E0-0x000000018055D680
	
		public delegate void OnExtensionResponseDelegate(object dataObj, IssClient.XtMsgType type); // TypeDefIndex: 15987; 0x00000001812D3280-0x00000001812D3690
	
		public delegate void OnJoinRoomDelegate(Room room); // TypeDefIndex: 15988; 0x0000000180786C90-0x0000000180787020
	
		public delegate void OnJoinRoomErrorDelegate(string error); // TypeDefIndex: 15989; 0x000000018055D3E0-0x000000018055D680
	
		public delegate void OnLoginDelegate(bool success, string name, string error); // TypeDefIndex: 15990; 0x00000001812D3720-0x00000001812D3A10
	
		public delegate void OnLogoutDelegate(); // TypeDefIndex: 15991; 0x00000001804C7D50-0x00000001804C7EF0
	
		public delegate void OnRandomKeyDelegate(string key); // TypeDefIndex: 15992; 0x000000018055D3E0-0x000000018055D680
	
		public delegate void OnRoomListUpdateDelegate(Hashtable roomList); // TypeDefIndex: 15993; 0x0000000180786C90-0x0000000180787020
	
		// Constructors
		public IssEvent(string type, Hashtable parameters); // 0x00000001812BB5F0-0x00000001812BB600
	}
}
