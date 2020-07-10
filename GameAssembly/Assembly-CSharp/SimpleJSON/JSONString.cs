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
	public class JSONString : JSONNode // TypeDefIndex: 15400
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public override bool IsString { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override string Value { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	
		// Constructors
		public JSONString(string aData); // 0x00000001813566E0-0x0000000181356750
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180EB6660-0x0000000180EB6680
		public override JSONNode Clone(); // 0x0000000181356470-0x0000000181356500
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000181356620-0x00000001813566E0
		public override bool Equals(object obj); // 0x0000000181356500-0x0000000181356620
		public override int GetHashCode(); // 0x000000018075E590-0x000000018075E5C0
	}
}
