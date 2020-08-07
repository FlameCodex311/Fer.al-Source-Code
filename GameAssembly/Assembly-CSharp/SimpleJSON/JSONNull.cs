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
	public class JSONNull : JSONNode // TypeDefIndex: 16058
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x000000018040D640-0x000000018040D650 
		public override bool IsNull { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override string Value { get; set; } // 0x0000000180768E20-0x0000000180768E50 0x00000001803774A0-0x00000001803774B0
		public override bool AsBool { get; set; } // 0x0000000180380950-0x0000000180380960 0x00000001803774A0-0x00000001803774B0
	
		// Constructors
		private JSONNull(); // 0x0000000180768DC0-0x0000000180768E20
		static JSONNull(); // 0x0000000180768D20-0x0000000180768DC0
	
		// Methods
		public static JSONNull CreateOrGet(); // 0x0000000180768B60-0x0000000180768C40
		public override Enumerator GetEnumerator(); // 0x0000000180592A70-0x0000000180596140
		public override JSONNode Clone(); // 0x0000000180768B10-0x0000000180768B60
		public override bool Equals(object obj); // 0x0000000180768C40-0x0000000180768CD0
		public override int GetHashCode(); // 0x000000018037DDC0-0x000000018037DDD0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180768CD0-0x0000000180768D20
	}
}
