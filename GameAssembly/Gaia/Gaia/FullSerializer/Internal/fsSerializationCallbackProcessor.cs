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
	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 9153
	{
		// Constructors
		public fsSerializationCallbackProcessor(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818FEDD0-0x00000001818FEE60
		public override void OnBeforeSerialize(Type storageType, object instance); // 0x00000001818FF1B0-0x00000001818FF260
		public override void OnAfterSerialize(Type storageType, object instance, ref fsData data); // 0x00000001818FEF10-0x00000001818FEFD0
		public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data); // 0x00000001818FEFD0-0x00000001818FF1B0
		public override void OnAfterDeserialize(Type storageType, object instance); // 0x00000001818FEE60-0x00000001818FEF10
	}
}
