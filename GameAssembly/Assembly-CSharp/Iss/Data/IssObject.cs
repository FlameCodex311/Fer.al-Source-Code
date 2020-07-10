/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Data
{
	public class IssObject // TypeDefIndex: 16013
	{
		// Fields
		private Hashtable map; // 0x10
	
		// Constructors
		public IssObject(); // 0x0000000180F6B830-0x0000000180F6B890
	
		// Methods
		public void Put(object key, object value); // 0x0000000180F6B7C0-0x0000000180F6B830
		public void PutNumber(object key, double value); // 0x0000000180F6B710-0x0000000180F6B7C0
		public void PutBool(object key, bool value); // 0x0000000180F6B480-0x0000000180F6B530
		public void PutList(object key, IList collection); // 0x0000000180F6B620-0x0000000180F6B710
		public void PutDictionary(object key, IDictionary collection); // 0x0000000180F6B530-0x0000000180F6B620
		private void PopulateList(IssObject aobj, string key, IList collection); // 0x0000000180F6B0F0-0x0000000180F6B480
		private void PopulateDictionary(IssObject aobj, string key, IDictionary collection); // 0x0000000180F6AD50-0x0000000180F6B0F0
		public object Get(object key); // 0x0000000180F6ACF0-0x0000000180F6AD20
		public string GetString(object key); // 0x0000000180F6AC70-0x0000000180F6ACF0
		public double GetNumber(object key); // 0x0000000180F6AA60-0x0000000180F6AAF0
		public bool GetBool(object key); // 0x0000000180F6A9D0-0x0000000180F6AA60
		public IssObject GetObj(object key); // 0x0000000180F6ABC0-0x0000000180F6AC70
		public IssObject GetObj(int key); // 0x0000000180F6AAF0-0x0000000180F6ABC0
		public int Size(); // 0x000000018049E1E0-0x000000018049E210
		public ICollection Keys(); // 0x0000000180F6AD20-0x0000000180F6AD50
		public void Remove(object key); // 0x0000000180808A50-0x0000000180808A80
	}
}
