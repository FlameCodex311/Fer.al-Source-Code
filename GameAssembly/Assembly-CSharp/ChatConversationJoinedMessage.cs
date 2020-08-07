/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;
using Services.Chat;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x00000001801E8DA0-0x00000001801E8DD0
public class ChatConversationJoinedMessage : ServiceMessage, ITaggedMessage // TypeDefIndex: 12589
{
	// Fields
	public readonly ErrorInfo Error; // 0x28
	public readonly ChatConversationData Conversation; // 0x30

	// Properties
	public bool Success { get; } // 0x00000001804A1260-0x00000001804A1270 

	// Nested types
	public enum ErrorValue // TypeDefIndex: 12590
	{
		Unknown = 0,
		NotFound = 1,
		Privacy = 2
	}

	public class ErrorInfo // TypeDefIndex: 12591
	{
		// Fields
		public readonly ErrorValue Value; // 0x10
		public readonly ConversationPrivacy Privacy; // 0x14

		// Constructors
		public ErrorInfo(ErrorValue v, ConversationPrivacy p); // 0x00000001804A4420-0x00000001804A4460
	}

	// Constructors
	public ChatConversationJoinedMessage(JsonData jsonData); // 0x00000001804A10F0-0x00000001804A1260

	// Methods
	public string GetTag(); // 0x00000001804A10A0-0x00000001804A10F0
}

