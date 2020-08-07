/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Http
{
	public class HttpEvent // TypeDefIndex: 14393
	{
		// Fields
		public const string onHttpData = "OnHttpData"; // Metadata: 0x007BA8B4
		public const string onHttpError = "OnHttpError"; // Metadata: 0x007BA8C2
		public const string onHttpConnect = "OnHttpConnect"; // Metadata: 0x007BA8D1
		public const string onHttpClose = "OnHttpClose"; // Metadata: 0x007BA8E2
		private string type; // 0x10
		private Hashtable parameters; // 0x18
	
		// Constructors
		public HttpEvent(string type, Hashtable parameters); // 0x0000000180372010-0x00000001803720F0
	
		// Methods
		public new string GetType(); // 0x0000000180372440-0x0000000180372450
		public object GetParameter(string key); // 0x00000001805E4510-0x00000001805E4540
	}
}
