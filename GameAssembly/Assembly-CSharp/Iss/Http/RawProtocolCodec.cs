/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Http
{
	public class RawProtocolCodec : IHttpProtocolCodec // TypeDefIndex: 14395
	{
		// Fields
		private const int SESSION_ID_LEN = 32; // Metadata: 0x007BA8F1
	
		// Constructors
		public RawProtocolCodec(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public string Encode(string sessionId, string message); // 0x00000001808809F0-0x0000000180880A40
		public string Decode(string message); // 0x0000000180880960-0x00000001808809F0
	}
}
