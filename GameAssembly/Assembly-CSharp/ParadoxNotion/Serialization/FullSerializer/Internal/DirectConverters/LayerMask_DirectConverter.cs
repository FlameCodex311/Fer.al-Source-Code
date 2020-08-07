/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask> // TypeDefIndex: 15941
	{
		// Constructors
		public LayerMask_DirectConverter(); // 0x00000001806CCB70-0x00000001806CCBB0
	
		// Methods
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized); // 0x00000001806CCA70-0x00000001806CCB70
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model); // 0x00000001806CC940-0x00000001806CCA70
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806CC900-0x00000001806CC940
	}
}
