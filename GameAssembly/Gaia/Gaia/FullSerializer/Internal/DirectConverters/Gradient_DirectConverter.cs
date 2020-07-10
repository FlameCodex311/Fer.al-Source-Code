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
	public class Gradient_DirectConverter : fsDirectConverter<Gradient> // TypeDefIndex: 9171
	{
		// Constructors
		public Gradient_DirectConverter(); // 0x00000001818E6DA0-0x00000001818E6DE0
	
		// Methods
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized); // 0x00000001818E6B50-0x00000001818E6DA0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model); // 0x00000001818E68E0-0x00000001818E6B50
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E6890-0x00000001818E68E0
	}
}
