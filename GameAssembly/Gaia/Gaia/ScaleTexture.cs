/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class ScaleTexture // TypeDefIndex: 9257
	{
		// Fields
		private static Color[] texColors; // 0x00
		private static Color[] newColors; // 0x08
		private static int w; // 0x10
		private static float ratioX; // 0x14
		private static float ratioY; // 0x18
		private static int w2; // 0x1C
		private static int finishCount; // 0x20
		private static Mutex mutex; // 0x28
	
		// Nested types
		public class ThreadData // TypeDefIndex: 9258
		{
			// Fields
			public int start; // 0x10
			public int end; // 0x14
	
			// Constructors
			public ThreadData(int s, int e); // 0x00000001804A4420-0x00000001804A4460
		}
	
		// Constructors
		public ScaleTexture(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static void Point(Texture2D tex, int newWidth, int newHeight); // 0x000000018155C240-0x000000018155C260
		public static void Bilinear(Texture2D tex, int newWidth, int newHeight); // 0x000000018155BF50-0x000000018155BF70
		private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear); // 0x000000018155C260-0x000000018155C6A0
		public static void BilinearScale(object obj); // 0x000000018155BA10-0x000000018155BF50
		public static void PointScale(object obj); // 0x000000018155C050-0x000000018155C240
		private static Color ColorLerpUnclamped(Color c1, Color c2, float value); // 0x000000018155BF70-0x000000018155C050
	}
}
