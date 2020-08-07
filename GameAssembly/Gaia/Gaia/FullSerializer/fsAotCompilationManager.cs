/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public class fsAotCompilationManager // TypeDefIndex: 9282
	{
		// Fields
		private static Dictionary<Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Properties
		public static Dictionary<Type, string> AvailableAotCompilations { get; } // 0x0000000181510B80-0x0000000181510D40 
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 9283
		{
			// Fields
			public Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		public fsAotCompilationManager(); // 0x0000000180373240-0x0000000180373250
		static fsAotCompilationManager(); // 0x0000000181510AF0-0x0000000181510B80
	
		// Methods
		public static bool TryToPerformAotCompilation(Type type, out string aotCompiledClassInCSharp); // 0x0000000181510860-0x0000000181510AF0
		public static void AddAotCompilation(Type type, fsMetaProperty[] members, bool isConstructorPublic); // 0x000000018150F880-0x000000018150F950
		private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic); // 0x000000018150F950-0x0000000181510860
	}
}
