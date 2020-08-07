/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ConversationReadStateChangedMessage : Message // TypeDefIndex: 12611
{
	// Fields
	public readonly string ConversationId; // 0x18
	public readonly bool IsRead; // 0x20
	public readonly int UnreadCount; // 0x24

	// Constructors
	public ConversationReadStateChangedMessage(string inConversationId, bool inIsRead, int inUnreadCount); // 0x000000018077F030-0x000000018077F080
}

