/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Util
{
	public class SyncArrayList // TypeDefIndex: 16001
	{
		// Fields
		private ArrayList me; // 0x10
	
		// Constructors
		public SyncArrayList(); // 0x00000001812D4650-0x00000001812D46B0
	
		// Methods
		public ArrayList ToArrayList(); // 0x000000018036AC80-0x000000018036AC90
		public void Add(object item); // 0x00000001812D3B10-0x00000001812D3C10
		public object ObjectAt(int index); // 0x00000001812D4230-0x00000001812D4340
		public void AddRange(ICollection c); // 0x00000001812D3A10-0x00000001812D3B10
		public int Capacity(); // 0x00000001812D3C10-0x00000001812D3D10
		public void Clear(); // 0x00000001812D3D10-0x00000001812D3E00
		public bool Contains(object item); // 0x00000001812D3E00-0x00000001812D3F10
		public int Count(); // 0x00000001812D3F10-0x00000001812D4010
		public void Insert(int index, object Value); // 0x00000001812D4120-0x00000001812D4230
		public void Remove(object obj); // 0x00000001812D4550-0x00000001812D4650
		public void RemoveAt(int index); // 0x00000001812D4340-0x00000001812D4440
		public void RemoveRange(int index, int count); // 0x00000001812D4440-0x00000001812D4550
		public IEnumerator GetEnumerator(); // 0x00000001812D4010-0x00000001812D4120
	}
}
