/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x0000000180108ED0-0x0000000180108F00
public class ConversationAddResponse : ServiceMessage // TypeDefIndex: 11057
{
	// Fields
	public readonly string ConversationId; // 0x28
	public readonly string Participant; // 0x30
	public readonly string Error; // 0x38

	// Constructors
	public ConversationAddResponse(JsonData jsonData); // 0x0000000181473880-0x0000000181473950
}

