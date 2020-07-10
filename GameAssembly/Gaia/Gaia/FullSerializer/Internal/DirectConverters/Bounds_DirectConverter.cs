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
	public class Bounds_DirectConverter : fsDirectConverter<Bounds> // TypeDefIndex: 9169
	{
		// Constructors
		public Bounds_DirectConverter(); // 0x00000001818E2D50-0x00000001818E2D90
	
		// Methods
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized); // 0x00000001818E2B00-0x00000001818E2D50
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model); // 0x00000001818E2870-0x00000001818E2B00
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E2820-0x00000001818E2870
	}
}
