/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Http
{
	public class HttpEvent // TypeDefIndex: 16006
	{
		// Fields
		public const string onHttpData = "OnHttpData"; // Metadata: 0x0078518A
		public const string onHttpError = "OnHttpError"; // Metadata: 0x00785198
		public const string onHttpConnect = "OnHttpConnect"; // Metadata: 0x007851A7
		public const string onHttpClose = "OnHttpClose"; // Metadata: 0x007851B8
		private string type; // 0x10
		private Hashtable parameters; // 0x18
	
		// Constructors
		public HttpEvent(string type, Hashtable parameters); // 0x00000001803DA900-0x00000001803DA940
	
		// Methods
		public new string GetType(); // 0x000000018036AC80-0x000000018036AC90
		public object GetParameter(string key); // 0x0000000180F56920-0x0000000180F56950
	}
}
