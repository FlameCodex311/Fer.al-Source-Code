/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 80: Unity.RenderPipelines.Core.Runtime.dll - Assembly: Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9438-9675

namespace Utilities
{
	public static class MaterialQualityUtilities // TypeDefIndex: 9441
	{
		// Fields
		public static string[] KeywordNames; // 0x00
		public static string[] EnumNames; // 0x08
		public static ShaderKeyword[] Keywords; // 0x10
	
		// Constructors
		static MaterialQualityUtilities(); // 0x0000000182060BD0-0x0000000182060F40
	
		// Methods
		public static MaterialQuality FromIndex(int index); // 0x0000000182060590-0x00000001820605A0
	
		// Extension methods
		public static MaterialQuality GetHighestQuality(this MaterialQuality levels); // 0x00000001820607A0-0x0000000182060840
		public static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel); // 0x00000001820605A0-0x00000001820607A0
		public static void SetGlobalShaderKeywords(this MaterialQuality level); // 0x0000000182060840-0x00000001820609A0
		public static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd); // 0x00000001820609A0-0x0000000182060B30
		public static int ToFirstIndex(this MaterialQuality level); // 0x0000000182060B30-0x0000000182060BD0
	}
}
