/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public abstract class fsObjectProcessor // TypeDefIndex: 9301
	{
		// Constructors
		protected fsObjectProcessor(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public virtual bool CanProcess(Type type); // 0x0000000180E4ECE0-0x0000000180E4ED30
		public virtual void OnBeforeSerialize(Type storageType, object instance); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnBeforeDeserialize(Type storageType, ref fsData data); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnAfterDeserialize(Type storageType, object instance); // 0x00000001803774A0-0x00000001803774B0
	}
}
