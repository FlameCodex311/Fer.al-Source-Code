/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	public class ServerMessage : NetworkMessage // TypeDefIndex: 16032
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private INetMessageReader <Data>k__BackingField; // 0x28
	
		// Properties
		public override string Cmd { get; } // 0x0000000180EBFF50-0x0000000180EBFFA0 
		public INetMessageReader Data { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
		// Constructors
		public ServerMessage(INetMessageReader data); // 0x0000000180EBBF20-0x0000000180EBBF50
	}
}
