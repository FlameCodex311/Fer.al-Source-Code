/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class IdentityDisplayNamesResponse // TypeDefIndex: 12558
{
	// Fields
	public Identity[] found; // 0x10
	public string[] not_found; // 0x18

	// Nested types
	[Serializable]
	public struct Identity // TypeDefIndex: 12559
	{
		// Fields
		public string uuid; // 0x00
		public string display_name; // 0x08
	}

	// Constructors
	public IdentityDisplayNamesResponse(); // 0x0000000180373240-0x0000000180373250
	public IdentityDisplayNamesResponse(string uuid, string fakeName); // 0x00000001806237D0-0x0000000180623880
}

