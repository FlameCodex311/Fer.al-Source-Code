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
	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 9174
	{
		// Constructors
		public Rect_DirectConverter(); // 0x00000001818E8610-0x00000001818E8650
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized); // 0x00000001818E8280-0x00000001818E8610
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model); // 0x00000001818E7E80-0x00000001818E8280
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E7E40-0x00000001818E7E80
	}
}
