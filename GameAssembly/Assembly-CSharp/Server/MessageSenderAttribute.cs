/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	[AttributeUsage] // 0x00000001800C2100-0x00000001800C2120
	public class MessageSenderAttribute : Attribute // TypeDefIndex: 16039
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Cmd>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <AllowRedundant>k__BackingField; // 0x18
	
		// Properties
		public string Cmd { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public bool AllowRedundant { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
	
		// Constructors
		public MessageSenderAttribute(XtCmd cmd, bool allowRedundant = false /* Metadata: 0x007851E3 */); // 0x0000000180EBB980-0x0000000180EBB9C0
		public MessageSenderAttribute(string cmd, bool allowRedundant = false /* Metadata: 0x007851E4 */); // 0x0000000180B219D0-0x0000000180B21A10
	}
}
