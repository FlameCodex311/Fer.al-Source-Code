/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 15341
	{
		// Constructors
		public LayerMask_DirectConverter(); // 0x000000018137E010-0x000000018137E050
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized); // 0x000000018137DF10-0x000000018137E010
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model); // 0x000000018137DDE0-0x000000018137DF10
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018137DDA0-0x000000018137DDE0
	}
}
