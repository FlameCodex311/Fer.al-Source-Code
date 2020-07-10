/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Http
{
	public class RawProtocolCodec : IHttpProtocolCodec // TypeDefIndex: 16008
	{
		// Fields
		private const int SESSION_ID_LEN = 32; // Metadata: 0x007851C7
	
		// Constructors
		public RawProtocolCodec(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public string Encode(string sessionId, string message); // 0x0000000180F6BBA0-0x0000000180F6BBF0
		public string Decode(string message); // 0x0000000180F6BB10-0x0000000180F6BBA0
	}
}
