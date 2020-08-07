/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public static class IGraphAssignableExtensions // TypeDefIndex: 15695
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 15696
		{
			// Fields
			public IGraphAssignable assignable; // 0x10
			public Action<bool> callback; // 0x18
	
			// Constructors
			public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <TryStartSubGraph>b__0(bool result); // 0x0000000180CD1EB0-0x0000000180CD1F30
		}
	
		// Extension methods
		public static Graph CheckInstance(this IGraphAssignable assignable); // 0x0000000180CC9E80-0x0000000180CCA120
		public static bool TryStartSubGraph(this IGraphAssignable assignable, Component agent, Action<bool> callback = null); // 0x0000000180CCA5B0-0x0000000180CCA7B0
		public static bool TryStopSubGraph(this IGraphAssignable assignable); // 0x0000000180CCA7B0-0x0000000180CCA870
		public static bool TryPauseSubGraph(this IGraphAssignable assignable); // 0x0000000180CCA120-0x0000000180CCA1E0
		public static bool TryResumeSubGraph(this IGraphAssignable assignable); // 0x0000000180CCA4F0-0x0000000180CCA5B0
		public static bool TryUpdateSubGraph(this IGraphAssignable assignable); // 0x0000000180CCA870-0x0000000180CCA980
		public static void TryWriteMappedVariables(this IGraphAssignable assignable); // 0x0000000180CCA980-0x0000000180CCAC90
		public static void TryReadMappedVariables(this IGraphAssignable assignable); // 0x0000000180CCA1E0-0x0000000180CCA4F0
		public static void ValidateSubGraphAndParameters(this IGraphAssignable assignable); // 0x0000000180CCAC90-0x0000000180CCAED0
		public static void AutoLinkByName(this IGraphAssignable assignable); // 0x0000000180CC9B00-0x0000000180CC9E80
	}
}
