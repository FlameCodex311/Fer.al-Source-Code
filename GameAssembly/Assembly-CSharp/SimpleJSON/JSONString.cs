/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SimpleJSON
{
	public class JSONString : JSONNode // TypeDefIndex: 16055
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x000000018043E010-0x000000018043E020 
		public override bool IsString { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override string Value { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	
		// Constructors
		public JSONString(string aData); // 0x000000018076A630-0x000000018076A6A0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180592A70-0x0000000180596140
		public override JSONNode Clone(); // 0x000000018076A3A0-0x000000018076A430
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x000000018076A570-0x000000018076A630
		public override bool Equals(object obj); // 0x000000018076A430-0x000000018076A540
		public override int GetHashCode(); // 0x000000018076A540-0x000000018076A570
	}
}
