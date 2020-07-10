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
	public class GameObject_DirectConverter : fsDirectConverter<GameObject> // TypeDefIndex: 9170
	{
		// Constructors
		public GameObject_DirectConverter(); // 0x00000001818E64C0-0x00000001818E6500
	
		// Methods
		protected override fsResult DoSerialize(GameObject model, Dictionary<string, fsData> serialized); // 0x00000001818E6120-0x00000001818E64C0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GameObject model); // 0x00000001818E5DD0-0x00000001818E6120
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818E5D80-0x00000001818E5DD0
	}
}
