/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public class CTWebClient : WebClient // TypeDefIndex: 9955
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Timeout>k__BackingField; // 0xA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <ConnectionLimit>k__BackingField; // 0xA4
	
		// Properties
		public int Timeout { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A36F0-0x00000001804A3700 0x00000001815D0580-0x00000001815D0590
		public int ConnectionLimit { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A3700-0x00000001804A3710 0x00000001815D0570-0x00000001815D0580
	
		// Constructors
		public CTWebClient(); // 0x00000001815D0500-0x00000001815D0530
		public CTWebClient(int timeout, int connectionLimit = 20 /* Metadata: 0x00746770 */); // 0x00000001815D0530-0x00000001815D0570
	
		// Methods
		public WebRequest CTGetWebRequest(string uri); // 0x00000001815D0310-0x00000001815D0390
		protected override WebRequest GetWebRequest(Uri uri); // 0x00000001815D0390-0x00000001815D0500
	}
}
