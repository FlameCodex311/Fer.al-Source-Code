/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001801EE880-0x00000001801EE8F0
	[CustomObfuscation] // 0x00000001801EE880-0x00000001801EE8F0
	internal class ExpandableArray_DataContainer<T> // TypeDefIndex: 6577
		where T : class, TGuloXjPHhMZpLpbUVpnvAAKNDg, new()
	{
		// Fields
		public readonly T injector;
		private T[] vRnBgbtDFZKXOlXCcReavdCuERi;
		private int gjDALYTocCLFyiIniNYqXjpHEBY;
		private int ocipvpafTPlvtsrGOMcGOEXbDlz;
		private int gMGJbVbsyykkvZohSKqzoZDgcQT;
		private int ETpSiVnQktiRrrxzYLZBZCgKJKx;
		private bool HcOEBfVsiqKEXUWaswROecDtRqk;
	
		// Properties
		public int Count { get; }
		public int Length { get; }
		public int MaxLength { get; }
		public int FreeSpace { get; }
		public T this[int index] { get => default; }
	
		// Nested types
		public interface TGuloXjPHhMZpLpbUVpnvAAKNDg : IComparable<T> // TypeDefIndex: 6578
		{
			// Methods
			void Set(T param_0000d6f6);
			bool Equals(T param_0000d6f7);
			void Clear();
		}
	
		// Constructors
		public ExpandableArray_DataContainer(int startingMaxLength, bool clearData = true /* Metadata: 0x00764D54 */, int expansionIncrement = 0 /* Metadata: 0x00764D55 */);
	
		// Methods
		public int Inject();
		public int InjectIfUnique();
		public int AddData(T item);
		public int AddIfUnique(T item);
		public bool ContainsData(T item);
		public int IndexOfData(T item);
		public void Clear();
		public void RemoveAt(int index);
		public void RemoveLast();
		public void Resize(int size);
		public void SortAscending();
		public void SortDescending();
		private void KUkuMqFVxdihWqNHdzgmImjpDeUf();
	}
}
