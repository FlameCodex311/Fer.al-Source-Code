/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server
{
	internal class DefaultMessageRouteInfo : MessageRouteInfo // TypeDefIndex: 14411
	{
		// Fields
		public string eventId; // 0x28
		private static object[] _args; // 0x00
	
		// Nested types
		private delegate void MessageManagerDelegate<T>(string id, T msg); // TypeDefIndex: 14412; 0x00000000-0x00000000
	
		// Constructors
		public DefaultMessageRouteInfo(string eventId, Type msgType, QueueMessageMode queueMode); // 0x00000001803F36A0-0x00000001803F38E0
		static DefaultMessageRouteInfo(); // 0x00000001803F3650-0x00000001803F36A0
	
		// Methods
		public override void OnMessage(NetworkMessage message); // 0x00000001803F3550-0x00000001803F3650
	}
}
