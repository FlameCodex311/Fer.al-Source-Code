/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class SponsorLogoLoader // TypeDefIndex: 13680
{
	// Methods
	public static string Load(Texture2D inputImage); // 0x000000018135DDE0-0x000000018135DEF0
	private static int GetSize(Texture2D inputImage); // 0x000000018135DD30-0x000000018135DDE0
	private static byte[] Decode(int msgLen, Texture2D inputImage); // 0x000000018135D930-0x000000018135D950
	private static byte[] Decode(int startOffset, int msgLen, Texture2D inputImage); // 0x000000018135D950-0x000000018135DCB0
	private static int CombineToInt(byte one, byte two, byte three, byte four); // 0x000000018135D910-0x000000018135D930
	private static byte GetLSB(float n); // 0x000000018135DCB0-0x000000018135DD30
	private static byte SetBitInByte(byte sourceByte, int indexInByte, byte bitVal); // 0x000000018135DEF0-0x000000018135DF20
}

