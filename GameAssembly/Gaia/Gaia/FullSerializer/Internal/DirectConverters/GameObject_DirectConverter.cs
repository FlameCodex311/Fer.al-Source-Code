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
	public class GameObject_DirectConverter : fsDirectConverter<GameObject> // TypeDefIndex: 9336
	{
		// Constructors
		public GameObject_DirectConverter(); // 0x000000018150D4B0-0x000000018150D4F0
	
		// Methods
		protected override fsResult DoSerialize(GameObject model, Dictionary<string, fsData> serialized); // 0x000000018150D270-0x000000018150D4B0
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GameObject model); // 0x000000018150D040-0x000000018150D270
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018150CFF0-0x000000018150D040
	}
}
