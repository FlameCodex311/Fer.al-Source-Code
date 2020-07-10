/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Data
{
	public class NewRoomDescriptor // TypeDefIndex: 16014
	{
		// Fields
		private string name; // 0x10
		private string password; // 0x18
		private int maxUsers; // 0x20
		private int maxSpectators; // 0x24
		private bool isGame; // 0x28
		private bool exitCurrentRoom; // 0x29
		private bool receiveUCount; // 0x2A
		private ArrayList variables; // 0x30
		private ExtensionDescriptor extension; // 0x38
	
		// Properties
		public string Name { get; } // 0x000000018036AC80-0x000000018036AC90 
		public string Password { get; } // 0x000000018038B150-0x000000018038B160 
		public int MaxUsers { get; } // 0x00000001803C2700-0x00000001803C2710 
		public int MaxSpectators { get; } // 0x00000001803C26F0-0x00000001803C2700 
		public bool IsGame { get; } // 0x00000001803A2790-0x00000001803A27A0 
		public bool ExitCurrentRoom { get; } // 0x00000001805C9DA0-0x00000001805C9DB0 
		public bool ReceiveUCount { get; } // 0x00000001809C8430-0x00000001809C8440 
		public ArrayList Variables { get; } // 0x0000000180397720-0x0000000180397730 
		public ExtensionDescriptor Extension { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
		// Nested types
		public class ExtensionDescriptor // TypeDefIndex: 16015
		{
			// Fields
			private string name; // 0x10
			private string script; // 0x18
	
			// Properties
			public string Name { get; } // 0x000000018036AC80-0x000000018036AC90 
			public string Script { get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			public ExtensionDescriptor(string name, string script); // 0x00000001803DA900-0x00000001803DA940
		}
	
		// Constructors
		public NewRoomDescriptor(string name, int maxUsers); // 0x0000000180F6B9B0-0x0000000180F6BA60
		public NewRoomDescriptor(string name, int maxUsers, bool isGame); // 0x0000000180F6BA60-0x0000000180F6BB10
		public NewRoomDescriptor(string name, int maxUsers, bool isGame, int maxSpectators, ArrayList variables, ExtensionDescriptor extension); // 0x0000000180F6B890-0x0000000180F6B930
		public NewRoomDescriptor(string name, int maxUsers, bool isGame, int maxSpectators, ArrayList variables, ExtensionDescriptor extension, string password, bool exitCurrentRoom, bool receiveUCount); // 0x0000000180F6B930-0x0000000180F6B9B0
	}
}
