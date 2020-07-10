/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;
using Services.Chat;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018010AB50-0x000000018010AB80
public class ChatConversationJoinedMessage : ServiceMessage, ITaggedMessage // TypeDefIndex: 11064
{
	// Fields
	public readonly ErrorInfo Error; // 0x28
	public readonly ChatConversationData Conversation; // 0x30

	// Properties
	public bool Success { get; } // 0x0000000180A44040-0x0000000180A44050 

	// Nested types
	public enum ErrorValue // TypeDefIndex: 11065
	{
		Unknown = 0,
		NotFound = 1,
		Privacy = 2
	}

	public class ErrorInfo // TypeDefIndex: 11066
	{
		// Fields
		public readonly ErrorValue Value; // 0x10
		public readonly ConversationPrivacy Privacy; // 0x14

		// Constructors
		public ErrorInfo(ErrorValue v, ConversationPrivacy p); // 0x00000001804F7840-0x00000001804F7880
	}

	// Constructors
	public ChatConversationJoinedMessage(JsonData jsonData); // 0x00000001810287B0-0x0000000181028920

	// Methods
	public string GetTag(); // 0x0000000181028760-0x00000001810287B0
}

