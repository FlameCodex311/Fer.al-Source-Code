/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ChatThrottler // TypeDefIndex: 11921
{
	// Fields
	private int _chatSampleSize; // 0x10
	private float _maxChatsPerSecond; // 0x14
	private List<float> _chatTimes; // 0x18

	// Constructors
	public ChatThrottler(int chatSampleSize, float maxChatsPerSecond); // 0x000000018102BA10-0x000000018102BAC0

	// Methods
	public bool RequestChatPermission(); // 0x000000018102B8D0-0x000000018102BA10
}

