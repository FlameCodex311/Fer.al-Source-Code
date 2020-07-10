/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
	public class MessageRouter // TypeDefIndex: 16026
	{
		// Fields
		public const string XT_EVENTID_PREFIX = "xt."; // Metadata: 0x007851CC
		private Dictionary<string, MessageRouteInfo> _table; // 0x10
		private Queue<NetworkMessage> _queuedMessages; // 0x18
		private Dictionary<string, float> _lastRequestTimes; // 0x20
		private Dictionary<string, float> _redundantCmdTimeOverrides; // 0x28
		internal static MethodInfo _defaultMessageHandlerMethod; // 0x00
		internal static MethodInfo _defaultTaggedMessageHandlerMethod; // 0x08
	
		// Nested types
		public delegate void MessageRoute(NetworkMessage inMsg); // TypeDefIndex: 16027; 0x0000000180786C90-0x0000000180787020
	
		public delegate bool ShouldQueuePredicate(); // TypeDefIndex: 16028; 0x0000000180EC25C0-0x0000000180EC27E0
	
		private static class ShouldQueue // TypeDefIndex: 16029
		{
			// Methods
			public static bool Never(); // 0x00000001803C28F0-0x00000001803C2900
			public static bool WhileLoading(); // 0x0000000180EC2850-0x0000000180EC2860
		}
	
		public class MultiMessage : ServerMessage // TypeDefIndex: 16030
		{
			// Fields
			public readonly List<INetMessageReader> Messages; // 0x30
	
			// Constructors
			public MultiMessage(INetMessageReader message); // 0x0000000180EBB9C0-0x0000000180EBBD40
		}
	
		// Constructors
		public MessageRouter(); // 0x0000000180EBB580-0x0000000180EBB980
	
		// Methods
		private void CreateRoutes(bool fake = false /* Metadata: 0x007851CB */); // 0x0000000180EBA1E0-0x0000000180EBA820
		public void CreateFakeRoutes(); // 0x0000000180EB9B00-0x0000000180EB9B10
		private void CreateRoutesForType(Type type); // 0x0000000180EB9B10-0x0000000180EBA1E0
		public static void OnWebServiceMessage(string jsonData); // 0x0000000180EBB260-0x0000000180EBB550
		[MessageRoute] // 0x00000001800E3DD0-0x00000001800E3DF0
		private static void HandleMultiMessage(MultiMessage message); // 0x0000000180EBA990-0x0000000180EBAAC0
		public static void OnServerMessage(INetMessageReader data); // 0x0000000180EBAE70-0x0000000180EBB260
		public static void OnFakeServerMessage(INetMessageReader incoming); // 0x0000000180EBAAC0-0x0000000180EBADB0
		private void OnMessage(NetworkMessage message, Queue<NetworkMessage> queue); // 0x0000000180EBADB0-0x0000000180EBAE70
		public void DequeueMessages(); // 0x0000000180EBA820-0x0000000180EBA990
		public void AddRedudantCmdOverride(string cmd, float redundantTime); // 0x0000000180EB9940-0x0000000180EB99B0
		private bool CanSendMessage(string cmd); // 0x0000000180EB99B0-0x0000000180EB9B00
		public void SendServiceRequest(PersistentServiceConnection connection, PersistentServiceRequest req); // 0x0000000180EBB550-0x0000000180EBB580
	}
}
