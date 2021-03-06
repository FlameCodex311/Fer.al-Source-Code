﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight
{
	[Serializable]
	public abstract class IdentifiableBackingFieldCompatibleObjectWrapper<TId, T> : IdentifiableBackingFieldCompatibleObjectWrapper, IIdentifiable<TId> // TypeDefIndex: 14488
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TId m_Identifier;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T m_Data;
	
		// Properties
		public T Data { get; protected set; }
		public TId Identifier { get; protected set; }
	
		// Constructors
		protected IdentifiableBackingFieldCompatibleObjectWrapper(TId id, T data);
	
		// Methods
		public override object Clone();
		public override int GetSerializedPropertiesHash();
		protected virtual bool SetData(T data);
		protected virtual bool SetIdentifier(TId identifier);
	}
}
