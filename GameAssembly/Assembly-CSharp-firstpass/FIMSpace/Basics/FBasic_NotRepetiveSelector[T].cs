/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_NotRepetiveSelector<T> // TypeDefIndex: 10372
	{
		// Fields
		private int backRange;
		private List<int> previousElements;
		private List<T> elements;
		private int added;
	
		// Constructors
		public FBasic_NotRepetiveSelector(List<T> elements, int backRange);
	
		// Methods
		public static List<T> ArrayToList(T[] elements);
		public T GetElementNotRepetive();
		private int ChooseElementDontRepeat(List<T> elements, List<int> previousClips, int backCount);
	}
}
