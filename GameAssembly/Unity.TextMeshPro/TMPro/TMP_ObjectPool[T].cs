/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	internal class TMP_ObjectPool<T> // TypeDefIndex: 8828
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <countAll>k__BackingField;
	
		// Properties
		public int countAll { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; }
		public int countActive { get; }
		public int countInactive { get; }
	
		// Constructors
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease);
	
		// Methods
		public T Get();
		public void Release(T element);
	}
}
