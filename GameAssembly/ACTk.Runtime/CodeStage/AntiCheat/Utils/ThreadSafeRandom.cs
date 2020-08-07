/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Utils
{
	internal class ThreadSafeRandom // TypeDefIndex: 7335
	{
		// Fields
		private static readonly Random Global; // 0x00
		[ThreadStatic] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Random local; // 0x80000000
	
		// Constructors
		public ThreadSafeRandom(); // 0x0000000180373240-0x0000000180373250
		static ThreadSafeRandom(); // 0x000000018200ACB0-0x000000018200AD10
	
		// Methods
		public static int Next(int minInclusive, int maxExclusive); // 0x000000018200A9C0-0x000000018200ABF0
		public static long NextLong(long minInclusive, long maxExclusive); // 0x000000018200A6C0-0x000000018200A940
		public static void NextBytes(byte[] buffer); // 0x000000018200A110-0x000000018200A330
		public static void NextChars(char[] buffer); // 0x000000018200A330-0x000000018200A630
		public static int Next(); // 0x000000018200AC50-0x000000018200ACB0
		public static int Next(int maxExclusive); // 0x000000018200ABF0-0x000000018200AC50
		private static long NextLong(Random random, long minInclusive, long maxExclusive); // 0x000000018200A940-0x000000018200A9C0
		private static void NextChars(Random random, char[] buffer); // 0x000000018200A630-0x000000018200A6C0
	}
}
