/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Util
{
	public class SyncArrayList // TypeDefIndex: 14388
	{
		// Fields
		private ArrayList me; // 0x10
	
		// Constructors
		public SyncArrayList(); // 0x0000000180881F80-0x0000000180881FE0
	
		// Methods
		public ArrayList ToArrayList(); // 0x0000000180372440-0x0000000180372450
		public void Add(object item); // 0x0000000180881440-0x0000000180881540
		public object ObjectAt(int index); // 0x0000000180881B60-0x0000000180881C70
		public void AddRange(ICollection c); // 0x0000000180881340-0x0000000180881440
		public int Capacity(); // 0x0000000180881540-0x0000000180881640
		public void Clear(); // 0x0000000180881640-0x0000000180881730
		public bool Contains(object item); // 0x0000000180881730-0x0000000180881840
		public int Count(); // 0x0000000180881840-0x0000000180881940
		public void Insert(int index, object Value); // 0x0000000180881A50-0x0000000180881B60
		public void Remove(object obj); // 0x0000000180881E80-0x0000000180881F80
		public void RemoveAt(int index); // 0x0000000180881C70-0x0000000180881D70
		public void RemoveRange(int index, int count); // 0x0000000180881D70-0x0000000180881E80
		public IEnumerator GetEnumerator(); // 0x0000000180881940-0x0000000180881A50
	}
}
