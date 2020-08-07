/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Util
{
	public class Entities // TypeDefIndex: 14385
	{
		// Fields
		private static Hashtable ascTab; // 0x00
		private static Hashtable ascTabRev; // 0x08
		private static Hashtable hexTable; // 0x10
	
		// Constructors
		private Entities(); // 0x0000000180373240-0x0000000180373250
		static Entities(); // 0x000000018086D660-0x000000018086D710
	
		// Methods
		internal static void Initialize(); // 0x000000018086CD20-0x000000018086D660
		public static string EncodeEntities(string st); // 0x000000018086CAB0-0x000000018086CCC0
		public static string DecodeEntities(string st); // 0x000000018086C890-0x000000018086CAB0
		private static int GetCharCode(string ent); // 0x000000018086CCC0-0x000000018086CD20
	}
}
