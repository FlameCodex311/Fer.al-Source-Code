/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001801529F0-0x0000000180152A20
public class ChatEmojiDefComponent : DefComponent // TypeDefIndex: 10127
{
	// Fields
	[ChartDef] // 0x0000000180152BA0-0x0000000180152C50
	[ChartList] // 0x0000000180152BA0-0x0000000180152C50
	public List<string> localizedChatCommandDefIds; // 0x18
	private List<string> _chatCommands; // 0x20
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string unicode; // 0x28

	// Properties
	public List<string> ChatCommands { get; } // 0x0000000181028F10-0x00000001810290F0 

	// Constructors
	public ChatEmojiDefComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public string GetDisplayString(); // 0x0000000181028E10-0x0000000181028F10
}

