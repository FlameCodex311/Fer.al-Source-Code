/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class ChatServiceRequests // TypeDefIndex: 12593
{
	// Nested types
	public class ChatStartSessionRequest : PersistentServiceRequest // TypeDefIndex: 12594
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string uuid; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string auth_token; // 0x20

		// Constructors
		public ChatStartSessionRequest(); // 0x0000000180520AC0-0x0000000180520B50
	}

	public class ChatPingRequest : PersistentServiceRequest // TypeDefIndex: 12595
	{
		// Constructors
		public ChatPingRequest(); // 0x00000001805206C0-0x0000000180520700
	}

	public class RoomJoinRequest : PersistentServiceRequest // TypeDefIndex: 12596
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected int roomId; // 0x18

		// Constructors
		public RoomJoinRequest(int roomId); // 0x0000000180534130-0x0000000180534180
	}

	public class RoomLeaveRequest : PersistentServiceRequest // TypeDefIndex: 12597
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string roomName; // 0x18

		// Constructors
		public RoomLeaveRequest(string roomName); // 0x0000000180534180-0x00000001805341D0
	}

	public class ChatMessageRequest : PersistentServiceRequest // TypeDefIndex: 12598
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string message; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversationId; // 0x20

		// Constructors
		public ChatMessageRequest(string message, string conversationId); // 0x0000000180520660-0x00000001805206C0
	}

	public class ConversationGetRequest : PersistentServiceRequest // TypeDefIndex: 12599
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversationId; // 0x18

		// Constructors
		public ConversationGetRequest(string inConversationId); // 0x0000000180533F80-0x0000000180533FD0
	}

	public class ConversationListRequest : PersistentServiceRequest // TypeDefIndex: 12600
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected int pageSize; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string cursor; // 0x20

		// Constructors
		public ConversationListRequest(string inCursor, int inPageSize); // 0x0000000180534020-0x0000000180534080
	}

	public class ConversationRequest : PersistentServiceRequest // TypeDefIndex: 12601
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversation_id; // 0x18

		// Constructors
		public ConversationRequest(string conversationId); // 0x00000001805340E0-0x0000000180534130
	}

	public class ConversationRenameRequest : PersistentServiceRequest // TypeDefIndex: 12602
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversation_id; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string title; // 0x20

		// Constructors
		public ConversationRenameRequest(string newTitle, string conversationId); // 0x0000000180534080-0x00000001805340E0
	}

	public class ConversationAddRequest : PersistentServiceRequest // TypeDefIndex: 12603
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversationId; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string participant; // 0x20

		// Constructors
		public ConversationAddRequest(string inConversationId, string inUserIdToAdd); // 0x0000000180533EB0-0x0000000180533F10
	}

	public class ConversationLeaveRequest : PersistentServiceRequest // TypeDefIndex: 12604
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversation_id; // 0x18

		// Constructors
		public ConversationLeaveRequest(string conversationId); // 0x0000000180533FD0-0x0000000180534020
	}

	public class ConversationCreateRequest : PersistentServiceRequest // TypeDefIndex: 12605
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string title; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string[] participants; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversationType; // 0x28

		// Constructors
		public ConversationCreateRequest(string inName, string inConversationType, string[] inParticipants); // 0x0000000180533F10-0x0000000180533F80
	}

	public class ChatConversationOpenPrivateRequest : PersistentServiceRequest // TypeDefIndex: 12606
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string participant; // 0x18

		// Constructors
		public ChatConversationOpenPrivateRequest(string inOtherParticipantUUID); // 0x0000000180520610-0x0000000180520660
	}

	public class ChatConversationHistoryRequest : PersistentServiceRequest // TypeDefIndex: 12607
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string conversationId; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected int pageSize; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string cursor; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool include_messages; // 0x30

		// Constructors
		public ChatConversationHistoryRequest(string inConversationId, string inCursor, int inPageSize, bool inIncludeMessages = true /* Metadata: 0x007B9BF8 */); // 0x0000000180520590-0x0000000180520610
	}
}

