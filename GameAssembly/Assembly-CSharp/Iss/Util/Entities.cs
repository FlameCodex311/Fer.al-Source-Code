/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Util
{
	public class Entities // TypeDefIndex: 15998
	{
		// Fields
		private static Hashtable ascTab; // 0x00
		private static Hashtable ascTabRev; // 0x08
		private static Hashtable hexTable; // 0x10
	
		// Constructors
		private Entities(); // 0x000000018036B6C0-0x000000018036B6D0
		static Entities(); // 0x00000001812BB110-0x00000001812BB1C0
	
		// Methods
		internal static void Initialize(); // 0x00000001812BA7A0-0x00000001812BB110
		public static string EncodeEntities(string st); // 0x00000001812BA520-0x00000001812BA740
		public static string DecodeEntities(string st); // 0x00000001812BA300-0x00000001812BA520
		private static int GetCharCode(string ent); // 0x00000001812BA740-0x00000001812BA7A0
	}
}
