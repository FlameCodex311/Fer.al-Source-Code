/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server
{
	public class ServerMessage : NetworkMessage // TypeDefIndex: 14419
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private INetMessageReader <Data>k__BackingField; // 0x28
	
		// Properties
		public override string Cmd { get; } // 0x00000001803FEC60-0x00000001803FECB0 
		public INetMessageReader Data { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Constructors
		public ServerMessage(INetMessageReader data); // 0x00000001803F72A0-0x00000001803F72D0
	}
}
