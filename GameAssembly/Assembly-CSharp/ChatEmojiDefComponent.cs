/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x000000018022B170-0x000000018022B1A0
public class ChatEmojiDefComponent : DefComponent // TypeDefIndex: 11618
{
	// Fields
	[ChartDef] // 0x000000018022B330-0x000000018022B3E0
	[ChartList] // 0x000000018022B330-0x000000018022B3E0
	public List<string> localizedChatCommandDefIds; // 0x18
	private List<string> _chatCommands; // 0x20
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string unicode; // 0x28

	// Properties
	public List<string> ChatCommands { get; } // 0x00000001804A17F0-0x00000001804A19D0 

	// Constructors
	public ChatEmojiDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public string GetDisplayString(); // 0x00000001804A16F0-0x00000001804A17F0
}

