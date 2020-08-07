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
	public class JSONBool : JSONNode // TypeDefIndex: 16057
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000180765950-0x0000000180765960 
		public override bool IsBoolean { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override string Value { get; set; } // 0x0000000180765960-0x0000000180765970 0x0000000180765970-0x00000001807659F0
		public override bool AsBool { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
	
		// Constructors
		public JSONBool(bool aData); // 0x0000000180765860-0x00000001807658D0
		public JSONBool(string aData); // 0x00000001807658D0-0x0000000180765950
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180592A70-0x0000000180596140
		public override JSONNode Clone(); // 0x00000001807656D0-0x0000000180765760
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180765800-0x0000000180765860
		public override bool Equals(object obj); // 0x0000000180765760-0x00000001807657F0
		public override int GetHashCode(); // 0x00000001807657F0-0x0000000180765800
	}
}
