/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization
{
	public abstract class SerializedMethodBaseInfo : ISerializationCallbackReceiver // TypeDefIndex: 15292
	{
		// Constructors
		protected SerializedMethodBaseInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public abstract MethodBase GetBase();
		public abstract bool HasChanged();
		public abstract string GetMethodString();
		public override string ToString(); // 0x00000001805B15A0-0x00000001805B15C0
		public abstract void OnBeforeSerialize();
		public abstract void OnAfterDeserialize();
	}
}
