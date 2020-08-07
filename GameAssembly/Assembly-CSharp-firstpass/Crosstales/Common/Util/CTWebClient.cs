/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public class CTWebClient : WebClient // TypeDefIndex: 9741
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Timeout>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <ConnectionLimit>k__BackingField; // 0xA4
	
		// Properties
		public int Timeout { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180476030-0x0000000180476040 0x00000001804794A0-0x00000001804794B0
		public int ConnectionLimit { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001807C4E60-0x00000001807C4E70 0x000000018107A350-0x000000018107A360
	
		// Constructors
		public CTWebClient(); // 0x000000018107A2E0-0x000000018107A310
		public CTWebClient(int timeout, int connectionLimit = 20 /* Metadata: 0x0077AA3B */); // 0x000000018107A310-0x000000018107A350
	
		// Methods
		public WebRequest CTGetWebRequest(string uri); // 0x000000018107A0F0-0x000000018107A170
		protected override WebRequest GetWebRequest(Uri uri); // 0x000000018107A170-0x000000018107A2E0
	}
}
