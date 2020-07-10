/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 73: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8910-8940

namespace AmplifyImpostors
{
	public static class Texture2DEx // TypeDefIndex: 8929
	{
		// Fields
		private static readonly byte[] Footer; // 0x00
	
		// Nested types
		public enum Compression // TypeDefIndex: 8930
		{
			None = 0,
			RLE = 1
		}
	
		// Constructors
		static Texture2DEx(); // 0x00000001822B2F10-0x00000001822B2F70
	
		// Methods
		private static bool Equals(Color32 first, Color32 second); // 0x000000018188A300-0x000000018188A340
	
		// Extension methods
		public static byte[] EncodeToTGA(this Texture2D tex, Compression compression = Compression.RLE /* Metadata: 0x00743E07 */); // 0x00000001822B25E0-0x00000001822B2F10
	}
}
