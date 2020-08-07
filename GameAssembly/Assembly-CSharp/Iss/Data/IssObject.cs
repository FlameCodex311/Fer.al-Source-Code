/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Data
{
	public class IssObject // TypeDefIndex: 14400
	{
		// Fields
		private Hashtable map; // 0x10
	
		// Constructors
		public IssObject(); // 0x0000000180876480-0x00000001808764E0
	
		// Methods
		public void Put(object key, object value); // 0x00000001808763B0-0x0000000180876420
		public void PutNumber(object key, double value); // 0x0000000180876300-0x00000001808763B0
		public void PutBool(object key, bool value); // 0x0000000180876070-0x0000000180876120
		public void PutList(object key, IList collection); // 0x0000000180876210-0x0000000180876300
		public void PutDictionary(object key, IDictionary collection); // 0x0000000180876120-0x0000000180876210
		private void PopulateList(IssObject aobj, string key, IList collection); // 0x0000000180875CF0-0x0000000180876070
		private void PopulateDictionary(IssObject aobj, string key, IDictionary collection); // 0x0000000180875960-0x0000000180875CF0
		public object Get(object key); // 0x0000000180875900-0x0000000180875930
		public string GetString(object key); // 0x0000000180875880-0x0000000180875900
		public double GetNumber(object key); // 0x0000000180875670-0x0000000180875700
		public bool GetBool(object key); // 0x00000001808755E0-0x0000000180875670
		public IssObject GetObj(object key); // 0x00000001808757D0-0x0000000180875880
		public IssObject GetObj(int key); // 0x0000000180875700-0x00000001808757D0
		public int Size(); // 0x0000000180876450-0x0000000180876480
		public ICollection Keys(); // 0x0000000180875930-0x0000000180875960
		public void Remove(object key); // 0x0000000180876420-0x0000000180876450
	}
}
