/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server
{
	[AttributeUsage] // 0x00000001801D9CC0-0x00000001801D9CE0
	public class MessageSenderAttribute : Attribute // TypeDefIndex: 14426
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Cmd>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <AllowRedundant>k__BackingField; // 0x18
	
		// Properties
		public string Cmd { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public bool AllowRedundant { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
	
		// Constructors
		public MessageSenderAttribute(XtCmd cmd, bool allowRedundant = false /* Metadata: 0x007BA90D */); // 0x00000001803F6CF0-0x00000001803F6D30
		public MessageSenderAttribute(string cmd, bool allowRedundant = false /* Metadata: 0x007BA90E */); // 0x00000001803F6CB0-0x00000001803F6CF0
	}
}
