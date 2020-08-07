/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public struct fsResult // TypeDefIndex: 15923
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x00000001800A1EC0-0x00000001800A1ED0 
		public bool Succeeded { get; } // 0x00000001800A1FA0-0x00000001800A2000 
		public bool HasWarnings { get; } // 0x00000001800B9790-0x00000001800B97E0 
		public Exception AsException { get; } // 0x00000001800B9770-0x00000001800B9780 
		public IEnumerable<string> RawMessages { get; } // 0x00000001800B97E0-0x00000001800B9850 
		public string FormattedMessages { get; } // 0x00000001800B9780-0x00000001800B9790 
	
		// Constructors
		static fsResult(); // 0x00000001811B8A30-0x00000001811B8C40
	
		// Methods
		public static fsResult Warn(string warning); // 0x00000001811B89A0-0x00000001811B8A30
		public static fsResult Fail(string warning); // 0x00000001811B8840-0x00000001811B89A0
		public void AddMessage(string message); // 0x00000001800B9540-0x00000001800B9550
		public void AddMessages(fsResult result); // 0x00000001800B9550-0x00000001800B9600
		private fsResult Merge(fsResult other); // 0x00000001800B9730-0x00000001800B9760
		public static fsResult operator +(fsResult a, fsResult b); // 0x00000001811B8C40-0x00000001811B8D20
		public fsResult AssertSuccess(); // 0x00000001800B96D0-0x00000001800B9730
		public fsResult AssertSuccessWithoutWarnings(); // 0x00000001800B9600-0x00000001800B96D0
		public override string ToString(); // 0x00000001800B9760-0x00000001800B9770
	}
}
