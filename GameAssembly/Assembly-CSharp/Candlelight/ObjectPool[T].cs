/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Candlelight
{
	internal class ObjectPool<T> // TypeDefIndex: 13825
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly Action<T> m_ActionOnGet;
		private readonly Action<T> m_ActionOnRelease;
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Count>k__BackingField;
	
		// Properties
		public int Count { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; }
		public int CountActive { get; }
		public int CountInactive { get; }
	
		// Constructors
		public ObjectPool(Action<T> actionOnGet, Action<T> actionOnRelease);
	
		// Methods
		public T Get();
		public void Release(T element);
	}
}
