/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SimpleJSON
{
	public class JSONBool : JSONNode // TypeDefIndex: 15402
	{
		// Fields
		private bool m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x0000000180855970-0x0000000180855980 
		public override bool IsBoolean { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override string Value { get; set; } // 0x0000000180EB67D0-0x0000000180EB67E0 0x0000000180EB67E0-0x0000000180EB6860
		public override bool AsBool { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
	
		// Constructors
		public JSONBool(bool aData); // 0x0000000180EB66E0-0x0000000180EB6750
		public JSONBool(string aData); // 0x0000000180EB6750-0x0000000180EB67D0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180EB6660-0x0000000180EB6680
		public override JSONNode Clone(); // 0x0000000180EB6540-0x0000000180EB65D0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180EB6680-0x0000000180EB66E0
		public override bool Equals(object obj); // 0x0000000180EB65D0-0x0000000180EB6660
		public override int GetHashCode(); // 0x000000018089EE70-0x000000018089EE80
	}
}
