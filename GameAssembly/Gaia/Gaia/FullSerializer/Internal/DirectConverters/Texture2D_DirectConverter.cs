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
	public class Texture2D_DirectConverter : fsDirectConverter<Texture2D> // TypeDefIndex: 9175
	{
		// Constructors
		public Texture2D_DirectConverter(); // 0x00000001818E9000-0x00000001818E9040
	
		// Methods
		protected override fsResult DoSerialize(Texture2D model, Dictionary<string, fsData> serialized); // 0x00000001818E8AE0-0x00000001818E9000
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Texture2D model); // 0x00000001818E86A0-0x00000001818E8AE0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E8650-0x00000001818E86A0
	}
}
