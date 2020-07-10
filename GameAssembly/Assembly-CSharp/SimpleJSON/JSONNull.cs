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
	public class JSONNull : JSONNode // TypeDefIndex: 15403
	{
		// Fields
		private static JSONNull m_StaticInstance; // 0x00
		public static bool reuseSameInstance; // 0x08
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x000000018035E180-0x000000018035E190 
		public override bool IsNull { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override string Value { get; set; } // 0x0000000181354E80-0x0000000181354EB0 0x00000001803581E0-0x00000001803581F0
		public override bool AsBool { get; set; } // 0x00000001803C28F0-0x00000001803C2900 0x00000001803581E0-0x00000001803581F0
	
		// Constructors
		private JSONNull(); // 0x0000000181354E20-0x0000000181354E80
		static JSONNull(); // 0x0000000181354D80-0x0000000181354E20
	
		// Methods
		public static JSONNull CreateOrGet(); // 0x0000000181354BC0-0x0000000181354CA0
		public override Enumerator GetEnumerator(); // 0x0000000180EB6660-0x0000000180EB6680
		public override JSONNode Clone(); // 0x0000000181354B70-0x0000000181354BC0
		public override bool Equals(object obj); // 0x0000000181354CA0-0x0000000181354D30
		public override int GetHashCode(); // 0x000000018035FCC0-0x000000018035FCD0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000181354D30-0x0000000181354D80
	}
}
