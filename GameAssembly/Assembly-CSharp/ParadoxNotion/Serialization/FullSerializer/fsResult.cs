/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public struct fsResult // TypeDefIndex: 15315
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x000000018020D6F0-0x000000018020D700 
		public bool Succeeded { get; } // 0x000000018000A660-0x000000018000A670 
		public bool HasWarnings { get; } // 0x000000018020D710-0x000000018020D760 
		public Exception AsException { get; } // 0x000000018020D6E0-0x000000018020D6F0 
		public IEnumerable<string> RawMessages { get; } // 0x000000018020D760-0x000000018020D890 
		public string FormattedMessages { get; } // 0x000000018020D700-0x000000018020D710 
	
		// Constructors
		static fsResult(); // 0x000000018117F100-0x000000018117F320
	
		// Methods
		public static fsResult Warn(string warning); // 0x000000018117F070-0x000000018117F100
		public static fsResult Fail(string warning); // 0x000000018117EF10-0x000000018117F070
		public void AddMessage(string message); // 0x000000018020D430-0x000000018020D4C0
		public void AddMessages(fsResult result); // 0x000000018020D4C0-0x000000018020D570
		private fsResult Merge(fsResult other); // 0x000000018020D6B0-0x000000018020D6E0
		public static fsResult operator +(fsResult a, fsResult b); // 0x000000018117F320-0x000000018117F400
		public fsResult AssertSuccess(); // 0x000000018020D640-0x000000018020D6B0
		public fsResult AssertSuccessWithoutWarnings(); // 0x000000018020D570-0x000000018020D640
	}
}
