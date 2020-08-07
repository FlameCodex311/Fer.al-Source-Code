/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TaggedMessage : Message, ITaggedMessage // TypeDefIndex: 11137
{
	// Fields
	protected string _tag; // 0x18

	// Constructors
	protected TaggedMessage(); // 0x00000001803F46D0-0x00000001803F46E0
	public TaggedMessage(string inTag); // 0x00000001803F92E0-0x00000001803F9310
	public TaggedMessage(string inEventId, string inTag); // 0x000000018086C860-0x000000018086C890

	// Methods
	public string GetTag(); // 0x0000000180372430-0x0000000180372440
}

