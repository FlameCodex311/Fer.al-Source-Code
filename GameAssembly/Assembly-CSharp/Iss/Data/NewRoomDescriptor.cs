/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Data
{
	public class NewRoomDescriptor // TypeDefIndex: 14401
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
		public string Name { get; } // 0x0000000180372440-0x0000000180372450 
		public string Password { get; } // 0x0000000180372430-0x0000000180372440 
		public int MaxUsers { get; } // 0x00000001803FB670-0x00000001803FB680 
		public int MaxSpectators { get; } // 0x0000000180491DB0-0x0000000180491DC0 
		public bool IsGame { get; } // 0x00000001804C6790-0x00000001804C67A0 
		public bool ExitCurrentRoom { get; } // 0x0000000180880010-0x0000000180880020 
		public bool ReceiveUCount { get; } // 0x0000000180880020-0x0000000180880030 
		public ArrayList Variables { get; } // 0x00000001803745C0-0x00000001803745D0 
		public ExtensionDescriptor Extension { get; } // 0x00000001803743D0-0x00000001803743E0 
	
		// Nested types
		public class ExtensionDescriptor // TypeDefIndex: 14402
		{
			// Fields
			private string name; // 0x10
			private string script; // 0x18
	
			// Properties
			public string Name { get; } // 0x0000000180372440-0x0000000180372450 
			public string Script { get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			public ExtensionDescriptor(string name, string script); // 0x0000000180372010-0x00000001803720F0
		}
	
		// Constructors
		public NewRoomDescriptor(string name, int maxUsers); // 0x000000018087FEB0-0x000000018087FF60
		public NewRoomDescriptor(string name, int maxUsers, bool isGame); // 0x000000018087FF60-0x0000000180880010
		public NewRoomDescriptor(string name, int maxUsers, bool isGame, int maxSpectators, ArrayList variables, ExtensionDescriptor extension); // 0x000000018087FD90-0x000000018087FE30
		public NewRoomDescriptor(string name, int maxUsers, bool isGame, int maxSpectators, ArrayList variables, ExtensionDescriptor extension, string password, bool exitCurrentRoom, bool receiveUCount); // 0x000000018087FE30-0x000000018087FEB0
	}
}
