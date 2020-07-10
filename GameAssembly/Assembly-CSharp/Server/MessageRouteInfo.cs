/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	internal class MessageRouteInfo // TypeDefIndex: 16023
	{
		// Fields
		public MethodInfo handlerMethod; // 0x10
		public MessageRouter.ShouldQueuePredicate shouldQueue; // 0x18
		public Type msgType; // 0x20
		private static object[] _args; // 0x00
	
		// Constructors
		public MessageRouteInfo(MethodInfo handlerMethod, Type msgType, QueueMessageMode queueMode); // 0x0000000180EB9870-0x0000000180EB9940
		static MessageRouteInfo(); // 0x0000000180EB9820-0x0000000180EB9870
	
		// Methods
		public virtual void OnMessage(NetworkMessage message); // 0x0000000180EB9720-0x0000000180EB9820
	}
}
