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
	public class Rect_DirectConverter : fsDirectConverter<Rect> // TypeDefIndex: 9340
	{
		// Constructors
		public Rect_DirectConverter(); // 0x000000018150EBA0-0x000000018150EBE0
	
		// Methods
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized); // 0x000000018150E9A0-0x000000018150EBA0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model); // 0x000000018150E730-0x000000018150E9A0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018150E6F0-0x000000018150E730
	}
}
