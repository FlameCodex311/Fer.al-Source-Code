/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChatThrottler // TypeDefIndex: 13467
{
	// Fields
	private int _chatSampleSize; // 0x10
	private float _maxChatsPerSecond; // 0x14
	private List<float> _chatTimes; // 0x18

	// Constructors
	public ChatThrottler(int chatSampleSize, float maxChatsPerSecond); // 0x0000000180520C90-0x0000000180520D40

	// Methods
	public bool RequestChatPermission(); // 0x0000000180520B50-0x0000000180520C90
}

