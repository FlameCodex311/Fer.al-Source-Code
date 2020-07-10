/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class ChatServiceRequests // TypeDefIndex: 11068
{
	// Nested types
	public class ChatStartSessionRequest : PersistentServiceRequest // TypeDefIndex: 11069
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string uuid; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string auth_token; // 0x20

		// Constructors
		public ChatStartSessionRequest(); // 0x000000018102B840-0x000000018102B8D0
	}

	public class ChatPingRequest : PersistentServiceRequest // TypeDefIndex: 11070
	{
		// Constructors
		public ChatPingRequest(); // 0x000000018102B430-0x000000018102B470
	}

	public class RoomJoinRequest : PersistentServiceRequest // TypeDefIndex: 11071
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected int roomId; // 0x18

		// Constructors
		public RoomJoinRequest(int roomId); // 0x000000018102E900-0x000000018102E950
	}

	public class RoomLeaveRequest : PersistentServiceRequest // TypeDefIndex: 11072
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string roomName; // 0x18

		// Constructors
		public RoomLeaveRequest(string roomName); // 0x000000018102E950-0x000000018102E9A0
	}

	public class ChatMessageRequest : PersistentServiceRequest // TypeDefIndex: 11073
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string message; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversationId; // 0x20

		// Constructors
		public ChatMessageRequest(string message, string conversationId); // 0x000000018102B3D0-0x000000018102B430
	}

	public class ConversationGetRequest : PersistentServiceRequest // TypeDefIndex: 11074
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversationId; // 0x18

		// Constructors
		public ConversationGetRequest(string inConversationId); // 0x000000018102CFA0-0x000000018102CFF0
	}

	public class ConversationListRequest : PersistentServiceRequest // TypeDefIndex: 11075
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected int pageSize; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string cursor; // 0x20

		// Constructors
		public ConversationListRequest(string inCursor, int inPageSize); // 0x000000018102D040-0x000000018102D0A0
	}

	public class ConversationRequest : PersistentServiceRequest // TypeDefIndex: 11076
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversation_id; // 0x18

		// Constructors
		public ConversationRequest(string conversationId); // 0x000000018102D100-0x000000018102D150
	}

	public class ConversationRenameRequest : PersistentServiceRequest // TypeDefIndex: 11077
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversation_id; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string title; // 0x20

		// Constructors
		public ConversationRenameRequest(string newTitle, string conversationId); // 0x000000018102D0A0-0x000000018102D100
	}

	public class ConversationAddRequest : PersistentServiceRequest // TypeDefIndex: 11078
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversationId; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string participant; // 0x20

		// Constructors
		public ConversationAddRequest(string inConversationId, string inUserIdToAdd); // 0x000000018102CED0-0x000000018102CF30
	}

	public class ConversationLeaveRequest : PersistentServiceRequest // TypeDefIndex: 11079
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversation_id; // 0x18

		// Constructors
		public ConversationLeaveRequest(string conversationId); // 0x000000018102CFF0-0x000000018102D040
	}

	public class ConversationCreateRequest : PersistentServiceRequest // TypeDefIndex: 11080
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string title; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string[] participants; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversationType; // 0x28

		// Constructors
		public ConversationCreateRequest(string inName, string inConversationType, string[] inParticipants); // 0x000000018102CF30-0x000000018102CFA0
	}

	public class ChatConversationOpenPrivateRequest : PersistentServiceRequest // TypeDefIndex: 11081
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string participant; // 0x18

		// Constructors
		public ChatConversationOpenPrivateRequest(string inOtherParticipantUUID); // 0x0000000181028BE0-0x0000000181028C30
	}

	public class ChatConversationHistoryRequest : PersistentServiceRequest // TypeDefIndex: 11082
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string conversationId; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected int pageSize; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string cursor; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected bool include_messages; // 0x30

		// Constructors
		public ChatConversationHistoryRequest(string inConversationId, string inCursor, int inPageSize, bool inIncludeMessages = true /* Metadata: 0x007824B0 */); // 0x0000000181028430-0x00000001810284B0
	}
}

