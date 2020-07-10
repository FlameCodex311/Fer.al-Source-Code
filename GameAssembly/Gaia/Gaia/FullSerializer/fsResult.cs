/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public struct fsResult // TypeDefIndex: 9131
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x000000018020D6F0-0x000000018020D700 
		public bool Succeeded { get; } // 0x000000018000A660-0x000000018000A670 
		public bool HasWarnings { get; } // 0x00000001802A3940-0x00000001802A3990 
		public Exception AsException { get; } // 0x00000001802A3920-0x00000001802A3930 
		public IEnumerable<string> RawMessages { get; } // 0x00000001802A3990-0x00000001802A3A00 
		public string FormattedMessages { get; } // 0x00000001802A3930-0x00000001802A3940 
	
		// Constructors
		static fsResult(); // 0x00000001818FEAE0-0x00000001818FECF0
	
		// Methods
		public void AddMessage(string message); // 0x00000001802A36F0-0x00000001802A3700
		public void AddMessages(fsResult result); // 0x00000001802A3700-0x00000001802A37B0
		public fsResult Merge(fsResult other); // 0x00000001802A38F0-0x00000001802A3920
		public static fsResult Warn(string warning); // 0x00000001818FEA50-0x00000001818FEAE0
		public static fsResult Fail(string warning); // 0x00000001818FE8F0-0x00000001818FEA50
		public static fsResult operator +(fsResult a, fsResult b); // 0x00000001818FECF0-0x00000001818FEDD0
		public fsResult AssertSuccess(); // 0x00000001802A3880-0x00000001802A38F0
		public fsResult AssertSuccessWithoutWarnings(); // 0x00000001802A37B0-0x00000001802A3880
	}
}
