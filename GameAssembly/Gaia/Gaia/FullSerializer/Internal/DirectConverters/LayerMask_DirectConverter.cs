/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal.DirectConverters
{
	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 9339
	{
		// Constructors
		public LayerMask_DirectConverter(); // 0x000000018150E650-0x000000018150E690
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized); // 0x000000018150E560-0x000000018150E650
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model); // 0x000000018150E440-0x000000018150E560
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018150E400-0x000000018150E440
	}
}
