/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 76: BakeryRuntimeAssembly.dll - Assembly: BakeryRuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9124-9142

public static class ftUniqueIDRegistry // TypeDefIndex: 9142
{
	// Fields
	public static Dictionary<int, int> Mapping; // 0x00
	public static Dictionary<int, int> MappingInv; // 0x08

	// Constructors
	static ftUniqueIDRegistry(); // 0x00000001820BCCA0-0x00000001820BCD30

	// Methods
	public static void Deregister(int id); // 0x00000001820BC930-0x00000001820BCA80
	public static void Register(int id, int value); // 0x00000001820BCB90-0x00000001820BCCA0
	public static int GetInstanceId(int id); // 0x00000001820BCA80-0x00000001820BCB10
	public static int GetUID(int instanceId); // 0x00000001820BCB10-0x00000001820BCB90
}

