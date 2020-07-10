/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal.DirectConverters
{
	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 9173
	{
		// Constructors
		public LayerMask_DirectConverter(); // 0x00000001818E7DA0-0x00000001818E7DE0
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized); // 0x00000001818E7C50-0x00000001818E7DA0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model); // 0x00000001818E7AD0-0x00000001818E7C50
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E7A90-0x00000001818E7AD0
	}
}
