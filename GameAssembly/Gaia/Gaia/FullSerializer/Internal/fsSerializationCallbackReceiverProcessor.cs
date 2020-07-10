/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor // TypeDefIndex: 9154
	{
		// Constructors
		public fsSerializationCallbackReceiverProcessor(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818FF260-0x00000001818FF2F0
		public override void OnBeforeSerialize(Type storageType, object instance); // 0x00000001818FF390-0x00000001818FF430
		public override void OnAfterDeserialize(Type storageType, object instance); // 0x00000001818FF2F0-0x00000001818FF390
	}
}
