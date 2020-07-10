/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public abstract class fsObjectProcessor // TypeDefIndex: 9129
	{
		// Constructors
		protected fsObjectProcessor(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public virtual bool CanProcess(Type type); // 0x00000001818FB530-0x00000001818FB580
		public virtual void OnBeforeSerialize(Type storageType, object instance); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnBeforeDeserialize(Type storageType, ref fsData data); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnAfterDeserialize(Type storageType, object instance); // 0x00000001803581E0-0x00000001803581F0
	}
}
