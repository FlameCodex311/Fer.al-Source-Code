/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public interface ISerializationCollector : ISerializationCollectable // TypeDefIndex: 15891
	{
		// Methods
		void OnPush(ISerializationCollector parent);
		void OnCollect(ISerializationCollectable child, int depth);
		void OnPop(ISerializationCollector parent);
	}
}
