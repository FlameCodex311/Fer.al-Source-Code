/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server
{
	[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class MessageRouter // TypeDefIndex: 14413
	{
		// Fields
		public const string XT_EVENTID_PREFIX = "xt."; // Metadata: 0x007BA8F6
		private Dictionary<string, MessageRouteInfo> _table; // 0x10
		private Queue<NetworkMessage> _queuedMessages; // 0x18
		private Dictionary<string, float> _lastRequestTimes; // 0x20
		private Dictionary<string, float> _redundantCmdTimeOverrides; // 0x28
		internal static MethodInfo _defaultMessageHandlerMethod; // 0x00
		internal static MethodInfo _defaultTaggedMessageHandlerMethod; // 0x08
	
		// Nested types
		public delegate void MessageRoute(NetworkMessage inMsg); // TypeDefIndex: 14414; 0x00000001803F4920-0x00000001803F4CE0
	
		public delegate bool ShouldQueuePredicate(); // TypeDefIndex: 14415; 0x00000001804001B0-0x00000001804003D0
	
		private static class ShouldQueue // TypeDefIndex: 14416
		{
			// Methods
			public static bool Never(); // 0x0000000180380950-0x0000000180380960
			public static bool WhileLoading(); // 0x0000000180400440-0x00000001804006F0
		}
	
		public class MultiMessage : ServerMessage // TypeDefIndex: 14417
		{
			// Fields
			public readonly List<INetMessageReader> Messages; // 0x30
	
			// Constructors
			public MultiMessage(INetMessageReader message); // 0x00000001803F6D50-0x00000001803F70C0
		}
	
		// Constructors
		public MessageRouter(); // 0x00000001803F68B0-0x00000001803F6CB0
	
		// Methods
		private void CreateRoutes(bool fake = false /* Metadata: 0x007BA8F5 */); // 0x00000001803F5560-0x00000001803F5BA0
		public void CreateFakeRoutes(); // 0x00000001803F4EB0-0x00000001803F4EC0
		private void CreateRoutesForType(Type type); // 0x00000001803F4EC0-0x00000001803F5560
		public static void OnWebServiceMessage(string jsonData); // 0x00000001803F65A0-0x00000001803F6880
		[MessageRoute] // 0x00000001802266C0-0x00000001802266E0
		private static void HandleMultiMessage(MultiMessage message); // 0x00000001803F5D10-0x00000001803F5E40
		public static void OnServerMessage(INetMessageReader data); // 0x00000001803F61D0-0x00000001803F65A0
		public static void OnFakeServerMessage(INetMessageReader incoming); // 0x00000001803F5E40-0x00000001803F6110
		private void OnMessage(NetworkMessage message, Queue<NetworkMessage> queue); // 0x00000001803F6110-0x00000001803F61D0
		public void DequeueMessages(); // 0x00000001803F5BA0-0x00000001803F5D10
		public void AddRedudantCmdOverride(string cmd, float redundantTime); // 0x00000001803F4CF0-0x00000001803F4D60
		private bool CanSendMessage(string cmd); // 0x00000001803F4D60-0x00000001803F4EB0
		public void SendServiceRequest(PersistentServiceConnection connection, PersistentServiceRequest req); // 0x00000001803F6880-0x00000001803F68B0
	}
}
