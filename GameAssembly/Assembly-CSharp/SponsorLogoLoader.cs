/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class SponsorLogoLoader // TypeDefIndex: 11347
{
	// Methods
	public static string Load(Texture2D inputImage); // 0x0000000180CB8D90-0x0000000180CB8E80
	private static int GetSize(Texture2D inputImage); // 0x0000000180CB8CF0-0x0000000180CB8D90
	private static byte[] Decode(int msgLen, Texture2D inputImage); // 0x0000000180CB88F0-0x0000000180CB8910
	private static byte[] Decode(int startOffset, int msgLen, Texture2D inputImage); // 0x0000000180CB8910-0x0000000180CB8C70
	private static int CombineToInt(byte one, byte two, byte three, byte four); // 0x0000000180CB88D0-0x0000000180CB88F0
	private static byte GetLSB(float n); // 0x0000000180CB8C70-0x0000000180CB8CF0
	private static byte SetBitInByte(byte sourceByte, int indexInByte, byte bitVal); // 0x0000000180CB8E80-0x0000000180CB8EB0
}

