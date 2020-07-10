/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class SBCrypto // TypeDefIndex: 13201
{
	// Methods
	public static byte[] CreateEncryptionKeyBytesFromHashKey(string hashKey); // 0x0000000180E0F070-0x0000000180E0F1F0
	public static string EncryptText(string plainText, string encryptionKey); // 0x0000000180E0FB80-0x0000000180E0FD40
	public static string EncryptPassword(string inPassword, string inKey); // 0x0000000180E0F610-0x0000000180E0F880
	private static byte[] EncryptStringToBytes(string plainText, RijndaelManaged rijAlg); // 0x0000000180E0F880-0x0000000180E0FB80
	private static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV); // 0x0000000180E0F1F0-0x0000000180E0F610
	public static string StringToHexString(string inInput); // 0x0000000180E0FE60-0x0000000180E0FFB0
	public static byte[] HexStringToByte(string hexString); // 0x0000000180E0FD40-0x0000000180E0FE60
	public static string ByteArrayToHexString(byte[] ba); // 0x0000000180E0EF70-0x0000000180E0F070
}

