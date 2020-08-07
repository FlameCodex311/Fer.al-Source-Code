/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 74: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9076-9106

namespace AmplifyImpostors
{
	public static class Texture2DEx // TypeDefIndex: 9095
	{
		// Fields
		private static readonly byte[] Footer; // 0x00
	
		// Nested types
		public enum Compression // TypeDefIndex: 9096
		{
			None = 0,
			RLE = 1
		}
	
		// Constructors
		static Texture2DEx(); // 0x000000018208A730-0x000000018208A790
	
		// Methods
		private static bool Equals(Color32 first, Color32 second); // 0x0000000180D42640-0x0000000180D42680
	
		// Extension methods
		public static byte[] EncodeToTGA(this Texture2D tex, Compression compression = Compression.RLE /* Metadata: 0x00778AF5 */); // 0x0000000182089E30-0x000000018208A730
	}
}
