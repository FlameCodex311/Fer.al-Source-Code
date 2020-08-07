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
	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor // TypeDefIndex: 9333
	{
		// Constructors
		public fsSerializationCallbackReceiverProcessor(); // 0x00000001803F46D0-0x00000001803F46E0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001815237A0-0x0000000181523830
		public override void OnBeforeSerialize(Type storageType, object instance); // 0x00000001815238D0-0x0000000181523970
		public override void OnAfterDeserialize(Type storageType, object instance); // 0x0000000181523830-0x00000001815238D0
	}
}
