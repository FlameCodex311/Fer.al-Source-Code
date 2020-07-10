/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TaggedMessage : Message, ITaggedMessage // TypeDefIndex: 13466
{
	// Fields
	protected string _tag; // 0x18

	// Constructors
	protected TaggedMessage(); // 0x000000018037E800-0x000000018037E810
	public TaggedMessage(string inTag); // 0x00000001808A9F50-0x00000001808A9F80
	public TaggedMessage(string inEventId, string inTag); // 0x0000000180F53950-0x0000000180F53980

	// Methods
	public string GetTag(); // 0x000000018038B150-0x000000018038B160
}

