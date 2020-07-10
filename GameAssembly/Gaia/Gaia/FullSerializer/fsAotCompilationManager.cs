/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public class fsAotCompilationManager // TypeDefIndex: 9110
	{
		// Fields
		private static Dictionary<Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Properties
		public static Dictionary<Type, string> AvailableAotCompilations { get; } // 0x00000001818EAB50-0x00000001818EAD10 
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 9111
		{
			// Fields
			public Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		public fsAotCompilationManager(); // 0x000000018036B6C0-0x000000018036B6D0
		static fsAotCompilationManager(); // 0x00000001818EAAC0-0x00000001818EAB50
	
		// Methods
		public static bool TryToPerformAotCompilation(Type type, out string aotCompiledClassInCSharp); // 0x00000001818EA820-0x00000001818EAAC0
		public static void AddAotCompilation(Type type, fsMetaProperty[] members, bool isConstructorPublic); // 0x00000001818E9780-0x00000001818E9850
		private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic); // 0x00000001818E9850-0x00000001818EA820
	}
}
