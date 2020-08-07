/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 9332
	{
		// Constructors
		public fsSerializationCallbackProcessor(); // 0x00000001803F46D0-0x00000001803F46E0
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181523310-0x00000001815233A0
		public override void OnBeforeSerialize(Type storageType, object instance); // 0x00000001815236F0-0x00000001815237A0
		public override void OnAfterSerialize(Type storageType, object instance, ref fsData data); // 0x0000000181523450-0x0000000181523510
		public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data); // 0x0000000181523510-0x00000001815236F0
		public override void OnAfterDeserialize(Type storageType, object instance); // 0x00000001815233A0-0x0000000181523450
	}
}
