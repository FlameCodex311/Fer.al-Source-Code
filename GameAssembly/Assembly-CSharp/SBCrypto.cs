/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class SBCrypto // TypeDefIndex: 10867
{
	// Methods
	public static byte[] CreateEncryptionKeyBytesFromHashKey(string hashKey); // 0x0000000180740F40-0x00000001807410B0
	public static string EncryptText(string plainText, string encryptionKey); // 0x0000000180741B80-0x0000000180741D30
	public static string EncryptPassword(string inPassword, string inKey); // 0x00000001807414C0-0x0000000180741890
	private static byte[] EncryptStringToBytes(string plainText, RijndaelManaged rijAlg); // 0x0000000180741890-0x0000000180741B80
	private static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV); // 0x00000001807410B0-0x00000001807414C0
	public static string StringToHexString(string inInput); // 0x0000000180741E50-0x0000000180741F90
	public static byte[] HexStringToByte(string hexString); // 0x0000000180741D30-0x0000000180741E50
	public static string ByteArrayToHexString(byte[] ba); // 0x0000000180740E50-0x0000000180740F40
}

