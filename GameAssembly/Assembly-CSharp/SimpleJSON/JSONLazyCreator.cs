/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SimpleJSON
{
	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 15404
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x00000001806A5520-0x00000001806A5530 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000180EB6E60-0x0000000180EB6F00 0x0000000180EB7370-0x0000000180EB7400
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000180EB6F00-0x0000000180EB6FA0 0x0000000180EB72D0-0x0000000180EB7370
		public override int AsInt { get; set; } // 0x0000000180EB6CC0-0x0000000180EB6D30 0x0000000180EB7160-0x0000000180EB71E0
		public override float AsFloat { get; set; } // 0x0000000180EB6C50-0x0000000180EB6CC0 0x0000000180EB70E0-0x0000000180EB7160
		public override double AsDouble { get; set; } // 0x0000000180EB6BE0-0x0000000180EB6C50 0x0000000180EB7070-0x0000000180EB70E0
		public override long AsLong { get; set; } // 0x0000000180EB6D30-0x0000000180EB6E00 0x0000000180EB71E0-0x0000000180EB72D0
		public override bool AsBool { get; set; } // 0x0000000180EB6B40-0x0000000180EB6BE0 0x0000000180EB6FC0-0x0000000180EB7070
		public override JSONArray AsArray { get; } // 0x0000000180EB6AE0-0x0000000180EB6B40 
		public override JSONObject AsObject { get; } // 0x0000000180EB6E00-0x0000000180EB6E60 
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode); // 0x0000000180EB69F0-0x0000000180EB6A60
		public JSONLazyCreator(JSONNode aNode, string aKey); // 0x0000000180EB6A60-0x0000000180EB6AE0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180EB6660-0x0000000180EB6680
		private T Set<T>(T aVal)
			where T : JSONNode;
		public override void Add(JSONNode aItem); // 0x0000000180EB6860-0x0000000180EB68F0
		public override void Add(string aKey, JSONNode aItem); // 0x0000000180EB68F0-0x0000000180EB6990
		public static bool operator ==(JSONLazyCreator a, object b); // 0x0000000180EB6990-0x0000000180EB69A0
		public static bool operator !=(JSONLazyCreator a, object b); // 0x0000000180EB6FA0-0x0000000180EB6FC0
		public override bool Equals(object obj); // 0x0000000180EB6990-0x0000000180EB69A0
		public override int GetHashCode(); // 0x000000018035FCC0-0x000000018035FCD0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180EB69A0-0x0000000180EB69F0
	}
}
