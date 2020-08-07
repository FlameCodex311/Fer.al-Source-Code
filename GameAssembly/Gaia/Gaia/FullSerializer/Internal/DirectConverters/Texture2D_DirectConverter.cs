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
	public class Texture2D_DirectConverter : fsDirectConverter<Texture2D> // TypeDefIndex: 9341
	{
		// Constructors
		public Texture2D_DirectConverter(); // 0x000000018150F270-0x000000018150F2B0
	
		// Methods
		protected override fsResult DoSerialize(Texture2D model, Dictionary<string, fsData> serialized); // 0x000000018150EF60-0x000000018150F270
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Texture2D model); // 0x000000018150EC30-0x000000018150EF60
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018150EBE0-0x000000018150EC30
	}
}
