/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public interface IGraphAssignable : IGraphElement // TypeDefIndex: 15700
	{
		// Properties
		Graph subGraph { get; set; }
		Graph currentInstance { get; set; }
		Dictionary<Graph, Graph> instances { get; set; }
		BBParameter subGraphParameter { get; }
		List<BBMappingParameter> variablesMap { get; set; }
	}
}
