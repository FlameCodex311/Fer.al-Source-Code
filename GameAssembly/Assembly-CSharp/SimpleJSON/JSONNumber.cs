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
	public class JSONNumber : JSONNode // TypeDefIndex: 16056
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x00000001806C4390-0x00000001806C43A0 
		public override bool IsNumber { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override string Value { get; set; } // 0x0000000180769390-0x00000001807693F0 0x0000000180769410-0x00000001807694D0
		public override double AsDouble { get; set; } // 0x0000000180769370-0x0000000180769380 0x00000001807693F0-0x0000000180769400
		public override long AsLong { get; set; } // 0x0000000180769380-0x0000000180769390 0x0000000180769400-0x0000000180769410
	
		// Constructors
		public JSONNumber(double aData); // 0x0000000180769280-0x00000001807692F0
		public JSONNumber(string aData); // 0x00000001807692F0-0x0000000180769370
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180592A70-0x0000000180596140
		public override JSONNode Clone(); // 0x0000000180768E50-0x0000000180768EF0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180769240-0x0000000180769280
		private static bool IsNumeric(object value); // 0x0000000180769120-0x0000000180769240
		public override bool Equals(object obj); // 0x0000000180768EF0-0x0000000180769110
		public override int GetHashCode(); // 0x0000000180769110-0x0000000180769120
	}
}
