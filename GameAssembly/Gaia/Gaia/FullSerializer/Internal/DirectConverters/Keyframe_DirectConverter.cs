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
	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 9338
	{
		// Constructors
		public Keyframe_DirectConverter(); // 0x000000018150E3C0-0x000000018150E400
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized); // 0x000000018150E0C0-0x000000018150E3C0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model); // 0x000000018150DD00-0x000000018150E0C0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018150DCA0-0x000000018150DD00
	}
}
