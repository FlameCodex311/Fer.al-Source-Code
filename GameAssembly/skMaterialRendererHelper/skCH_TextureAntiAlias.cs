/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 55: skMaterialRendererHelper.dll - Assembly: skMaterialRendererHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7163-7164

public class skCH_TextureAntiAlias // TypeDefIndex: 7164
{
	// Fields
	private RijndaelManaged _cryp; // 0x10
	private string _key; // 0x18
	private string _salt; // 0x20
	private byte[] _keyBytes; // 0x28
	private byte[] _ivBytes; // 0x30

	// Constructors
	public skCH_TextureAntiAlias(string renderSettings, string renderInit); // 0x0000000180E00630-0x0000000180E00700

	// Methods
	private void createCrypto(); // 0x0000000180E00700-0x0000000180E007E0
	private void cleanUp(); // 0x00000001808A3D40-0x00000001808A3D50
	public string DeProcess(string dataToDeProcess); // 0x0000000180E001A0-0x0000000180E00630
}

