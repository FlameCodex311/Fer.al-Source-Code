/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	internal class DefaultMessageRouteInfo : MessageRouteInfo // TypeDefIndex: 16024
	{
		// Fields
		public string eventId; // 0x28
		private static object[] _args; // 0x00
	
		// Nested types
		private delegate void MessageManagerDelegate<T>(string id, T msg); // TypeDefIndex: 16025; 0x00000000-0x00000000
	
		// Constructors
		public DefaultMessageRouteInfo(string eventId, Type msgType, QueueMessageMode queueMode); // 0x0000000180EB4C60-0x0000000180EB4EC0
		static DefaultMessageRouteInfo(); // 0x0000000180EB4C10-0x0000000180EB4C60
	
		// Methods
		public override void OnMessage(NetworkMessage message); // 0x0000000180EB4B10-0x0000000180EB4C10
	}
}
