/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GiftPushMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 11300
{
	// Fields
	public readonly string[] itemIds; // 0x30
	public readonly int[] itemCounts; // 0x38
	public readonly int numGifts; // 0x40

	// Constructors
	public GiftPushMessage(string inItemId); // 0x0000000181056890-0x00000001810569A0
	public GiftPushMessage(INetMessageReader data); // 0x0000000181056600-0x0000000181056890

	// Methods
	public string GetTag(); // 0x00000001810001A0-0x00000001810001D0
}

