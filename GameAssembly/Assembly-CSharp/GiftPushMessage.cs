/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GiftPushMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 12828
{
	// Fields
	public readonly string[] itemIds; // 0x30
	public readonly int[] itemCounts; // 0x38
	public readonly int numGifts; // 0x40

	// Constructors
	public GiftPushMessage(string inItemId); // 0x0000000180681FA0-0x00000001806820A0
	public GiftPushMessage(INetMessageReader data); // 0x0000000180681D20-0x0000000180681FA0

	// Methods
	public string GetTag(); // 0x00000001805E74D0-0x00000001805E7500
}

