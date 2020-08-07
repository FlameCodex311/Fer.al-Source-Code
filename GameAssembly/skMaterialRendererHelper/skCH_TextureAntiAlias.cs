/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 56: skMaterialRendererHelper.dll - Assembly: skMaterialRendererHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7329-7330

public class skCH_TextureAntiAlias // TypeDefIndex: 7330
{
	// Fields
	private RijndaelManaged _cryp; // 0x10
	private string _key; // 0x18
	private string _salt; // 0x20
	private byte[] _keyBytes; // 0x28
	private byte[] _ivBytes; // 0x30

	// Constructors
	public skCH_TextureAntiAlias(string renderSettings, string renderInit); // 0x00000001820E46F0-0x00000001820E47C0

	// Methods
	private void createCrypto(); // 0x00000001820E47C0-0x00000001820E48A0
	private void cleanUp(); // 0x000000018122D020-0x000000018122D030
	public string DeProcess(string dataToDeProcess); // 0x00000001820E4280-0x00000001820E46F0
}

