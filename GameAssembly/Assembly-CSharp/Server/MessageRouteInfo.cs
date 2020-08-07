/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server
{
	internal class MessageRouteInfo // TypeDefIndex: 14410
	{
		// Fields
		public MethodInfo handlerMethod; // 0x10
		public MessageRouter.ShouldQueuePredicate shouldQueue; // 0x18
		public Type msgType; // 0x20
		private static object[] _args; // 0x00
	
		// Constructors
		public MessageRouteInfo(MethodInfo handlerMethod, Type msgType, QueueMessageMode queueMode); // 0x00000001803F4820-0x00000001803F48F0
		static MessageRouteInfo(); // 0x00000001803F47D0-0x00000001803F4820
	
		// Methods
		public virtual void OnMessage(NetworkMessage message); // 0x00000001803F46E0-0x00000001803F47D0
	}
}
