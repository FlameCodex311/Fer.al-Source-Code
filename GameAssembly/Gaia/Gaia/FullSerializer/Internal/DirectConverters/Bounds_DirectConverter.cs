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
	public class Bounds_DirectConverter : fsDirectConverter<Bounds> // TypeDefIndex: 9335
	{
		// Constructors
		public Bounds_DirectConverter(); // 0x000000018150A070-0x000000018150A0B0
	
		// Methods
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized); // 0x0000000181509ED0-0x000000018150A070
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model); // 0x0000000181509D00-0x0000000181509ED0
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181509CB0-0x0000000181509D00
	}
}
