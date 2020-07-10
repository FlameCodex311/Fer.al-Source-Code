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
	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe> // TypeDefIndex: 9172
	{
		// Constructors
		public Keyframe_DirectConverter(); // 0x00000001818E7A50-0x00000001818E7A90
	
		// Methods
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized); // 0x00000001818E74A0-0x00000001818E7A50
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model); // 0x00000001818E6E40-0x00000001818E74A0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E6DE0-0x00000001818E6E40
	}
}
