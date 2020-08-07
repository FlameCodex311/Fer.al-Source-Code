/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x00000001801E69B0-0x00000001801E69E0
public class ConversationAddResponse : ServiceMessage // TypeDefIndex: 12582
{
	// Fields
	public readonly string ConversationId; // 0x28
	public readonly string Participant; // 0x30
	public readonly string Error; // 0x38

	// Constructors
	public ConversationAddResponse(JsonData jsonData); // 0x000000018077EF60-0x000000018077F030
}

