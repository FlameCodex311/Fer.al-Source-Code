/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SimpleJSON
{
	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 16059
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { get; } // 0x000000018069B0C0-0x000000018069B0D0 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000180766140-0x00000001807661E0 0x0000000180766760-0x00000001807667F0
		public override JSONNode this[string aKey] { get => default; set {} } // 0x00000001807661E0-0x0000000180766280 0x00000001807666C0-0x0000000180766760
		public override int AsInt { get; set; } // 0x0000000180765ED0-0x0000000180765F80 0x00000001807664B0-0x0000000180766560
		public override float AsFloat { get; set; } // 0x0000000180765E20-0x0000000180765ED0 0x0000000180766400-0x00000001807664B0
		public override double AsDouble { get; set; } // 0x0000000180765D70-0x0000000180765E20 0x0000000180766350-0x0000000180766400
		public override long AsLong { get; set; } // 0x0000000180765F80-0x00000001807660E0 0x0000000180766560-0x00000001807666C0
		public override bool AsBool { get; set; } // 0x0000000180765CD0-0x0000000180765D70 0x00000001807662A0-0x0000000180766350
		public override JSONArray AsArray { get; } // 0x0000000180765C70-0x0000000180765CD0 
		public override JSONObject AsObject { get; } // 0x00000001807660E0-0x0000000180766140 
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode); // 0x0000000180765B80-0x0000000180765BF0
		public JSONLazyCreator(JSONNode aNode, string aKey); // 0x0000000180765BF0-0x0000000180765C70
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180592A70-0x0000000180596140
		private T Set<T>(T aVal)
			where T : JSONNode;
		public override void Add(JSONNode aItem); // 0x00000001807659F0-0x0000000180765A80
		public override void Add(string aKey, JSONNode aItem); // 0x0000000180765A80-0x0000000180765B20
		public static bool operator ==(JSONLazyCreator a, object b); // 0x0000000180765B20-0x0000000180765B30
		public static bool operator !=(JSONLazyCreator a, object b); // 0x0000000180766280-0x00000001807662A0
		public override bool Equals(object obj); // 0x0000000180765B20-0x0000000180765B30
		public override int GetHashCode(); // 0x000000018037DDC0-0x000000018037DDD0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180765B30-0x0000000180765B80
	}
}
