/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public interface fsISerializationCallbacks // TypeDefIndex: 9124
	{
		// Methods
		void OnBeforeSerialize(Type storageType);
		void OnAfterSerialize(Type storageType, ref fsData data);
		void OnBeforeDeserialize(Type storageType, ref fsData data);
		void OnAfterDeserialize(Type storageType);
	}
}
