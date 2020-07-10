/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Utils
{
	internal class ThreadSafeRandom // TypeDefIndex: 7169
	{
		// Fields
		private static readonly Random Global; // 0x00
		[ThreadStatic] // 0x00000001800B36B0-0x00000001800B36C0
		private static Random local; // 0x80000000
	
		// Constructors
		public ThreadSafeRandom(); // 0x000000018036B6C0-0x000000018036B6D0
		static ThreadSafeRandom(); // 0x000000018229F770-0x000000018229F7D0
	
		// Methods
		public static int Next(int minInclusive, int maxExclusive); // 0x000000018229F470-0x000000018229F6B0
		public static long NextLong(long minInclusive, long maxExclusive); // 0x000000018229F170-0x000000018229F3F0
		public static void NextBytes(byte[] buffer); // 0x000000018229EBA0-0x000000018229EDC0
		public static void NextChars(char[] buffer); // 0x000000018229EDC0-0x000000018229F0D0
		public static int Next(); // 0x000000018229F710-0x000000018229F770
		public static int Next(int maxExclusive); // 0x000000018229F6B0-0x000000018229F710
		private static long NextLong(Random random, long minInclusive, long maxExclusive); // 0x000000018229F3F0-0x000000018229F470
		private static void NextChars(Random random, char[] buffer); // 0x000000018229F0D0-0x000000018229F170
	}
}
