/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 75: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8958-8976

public static class ftUniqueIDRegistry // TypeDefIndex: 8976
{
	// Fields
	public static Dictionary<int, int> Mapping; // 0x00
	public static Dictionary<int, int> MappingInv; // 0x08

	// Constructors
	static ftUniqueIDRegistry(); // 0x00000001822C0CF0-0x00000001822C0D80

	// Methods
	public static void Deregister(int id); // 0x00000001822C0980-0x00000001822C0AD0
	public static void Register(int id, int value); // 0x00000001822C0BE0-0x00000001822C0CF0
	public static int GetInstanceId(int id); // 0x00000001822C0AD0-0x00000001822C0B60
	public static int GetUID(int instanceId); // 0x00000001822C0B60-0x00000001822C0BE0
}

