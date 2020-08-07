/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 15913
	{
		// Properties
		public override Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter();
	
		// Methods
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType);
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType);
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);
	}
}
