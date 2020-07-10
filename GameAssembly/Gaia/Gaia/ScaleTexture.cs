/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class ScaleTexture // TypeDefIndex: 9091
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
		public class ThreadData // TypeDefIndex: 9092
		{
			// Fields
			public int start; // 0x10
			public int end; // 0x14
	
			// Constructors
			public ThreadData(int s, int e); // 0x00000001804F7840-0x00000001804F7880
		}
	
		// Constructors
		public ScaleTexture(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static void Point(Texture2D tex, int newWidth, int newHeight); // 0x0000000181793360-0x0000000181793380
		public static void Bilinear(Texture2D tex, int newWidth, int newHeight); // 0x0000000181793060-0x0000000181793080
		private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear); // 0x0000000181793380-0x00000001817937D0
		public static void BilinearScale(object obj); // 0x0000000181792B00-0x0000000181793060
		public static void PointScale(object obj); // 0x0000000181793160-0x0000000181793360
		private static Color ColorLerpUnclamped(Color c1, Color c2, float value); // 0x0000000181793080-0x0000000181793160
	}
}
