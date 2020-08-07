/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public struct fsResult // TypeDefIndex: 9303
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x00000001800A1EC0-0x00000001800A1ED0 
		public bool Succeeded { get; } // 0x00000001800A1FA0-0x00000001800A2000 
		public bool HasWarnings { get; } // 0x00000001800A1EE0-0x00000001800A1F30 
		public Exception AsException { get; } // 0x00000001800A1EB0-0x00000001800A1EC0 
		public IEnumerable<string> RawMessages { get; } // 0x00000001800A1F30-0x00000001800A1FA0 
		public string FormattedMessages { get; } // 0x00000001800A1ED0-0x00000001800A1EE0 
	
		// Constructors
		static fsResult(); // 0x0000000180E4F120-0x0000000180E4F340
	
		// Methods
		public void AddMessage(string message); // 0x00000001800A1C90-0x00000001800A1CA0
		public void AddMessages(fsResult result); // 0x00000001800A1CA0-0x00000001800A1D50
		public fsResult Merge(fsResult other); // 0x00000001800A1E80-0x00000001800A1EB0
		public static fsResult Warn(string warning); // 0x0000000180E4F090-0x0000000180E4F120
		public static fsResult Fail(string warning); // 0x0000000180E4EF30-0x0000000180E4F090
		public static fsResult operator +(fsResult a, fsResult b); // 0x0000000180E4F340-0x0000000180E4F420
		public fsResult AssertSuccess(); // 0x00000001800A1E20-0x00000001800A1E80
		public fsResult AssertSuccessWithoutWarnings(); // 0x00000001800A1D50-0x00000001800A1E20
	}
}
