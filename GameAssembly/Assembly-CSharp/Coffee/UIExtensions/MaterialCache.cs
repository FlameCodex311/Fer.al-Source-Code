/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	public class MaterialCache // TypeDefIndex: 16328
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ulong <hash>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <referenceCount>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Texture <texture>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material <material>k__BackingField; // 0x28
		public static List<MaterialCache> materialCaches; // 0x00
	
		// Properties
		public ulong hash { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public int referenceCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
		public Texture texture { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public Material material { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 16329
		{
			// Fields
			public ulong hash; // 0x10
	
			// Constructors
			public <>c__DisplayClass17_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <Register>b__0(MaterialCache x); // 0x0000000180786E80-0x0000000180786EA0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 16330
		{
			// Fields
			public ulong hash; // 0x10
	
			// Constructors
			public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <Register>b__0(MaterialCache x); // 0x0000000180786E80-0x0000000180786EA0
		}
	
		// Constructors
		public MaterialCache(); // 0x0000000180373240-0x0000000180373250
		static MaterialCache(); // 0x0000000180784850-0x0000000180784A20
	
		// Methods
		public static MaterialCache Register(ulong hash, Texture texture, Func<Material> onCreateMaterial); // 0x00000001807843B0-0x0000000180784610
		public static MaterialCache Register(ulong hash, Func<Material> onCreateMaterial); // 0x0000000180784610-0x00000001807847C0
		public static void Unregister(MaterialCache cache); // 0x00000001807847C0-0x0000000180784850
	}
}
