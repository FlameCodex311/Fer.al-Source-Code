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
	public class JSONNumber : JSONNode // TypeDefIndex: 15401
	{
		// Fields
		private double m_Data; // 0x10
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x000000018043D4B0-0x000000018043D4C0 
		public override bool IsNumber { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override string Value { get; set; } // 0x0000000181355400-0x0000000181355460 0x0000000181355480-0x0000000181355540
		public override double AsDouble { get; set; } // 0x00000001813553E0-0x00000001813553F0 0x0000000181355460-0x0000000181355470
		public override long AsLong { get; set; } // 0x00000001813553F0-0x0000000181355400 0x0000000181355470-0x0000000181355480
	
		// Constructors
		public JSONNumber(double aData); // 0x00000001813552F0-0x0000000181355360
		public JSONNumber(string aData); // 0x0000000181355360-0x00000001813553E0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180EB6660-0x0000000180EB6680
		public override JSONNode Clone(); // 0x0000000181354EB0-0x0000000181354F50
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x00000001813552B0-0x00000001813552F0
		private static bool IsNumeric(object value); // 0x0000000181355190-0x00000001813552B0
		public override bool Equals(object obj); // 0x0000000181354F50-0x0000000181355180
		public override int GetHashCode(); // 0x0000000181355180-0x0000000181355190
	}
}
