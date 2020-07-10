/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[Serializable]
	public abstract class IndexedItem<TKey, TValue> : IValidates // TypeDefIndex: 13900
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TKey _ID;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TValue _Value;
	
		// Properties
		public TKey ID { get; protected set; }
		public TValue Value { get; protected set; }
	
		// Constructors
		public IndexedItem();
		public IndexedItem(TKey ID, TValue value);
	
		// Methods
		public abstract bool IsValid();
	}
}
