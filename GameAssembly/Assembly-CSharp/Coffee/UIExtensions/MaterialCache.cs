/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	public class MaterialCache // TypeDefIndex: 15489
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ulong <hash>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <referenceCount>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Texture <texture>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Material <material>k__BackingField; // 0x28
		public static List<MaterialCache> materialCaches; // 0x00
	
		// Properties
		public ulong hash { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public int referenceCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
		public Texture texture { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public Material material { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 15490
		{
			// Fields
			public ulong hash; // 0x10
	
			// Constructors
			public <>c__DisplayClass17_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <Register>b__0(MaterialCache x); // 0x0000000181281C10-0x0000000181281C40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 15491
		{
			// Fields
			public ulong hash; // 0x10
	
			// Constructors
			public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <Register>b__0(MaterialCache x); // 0x0000000181281C10-0x0000000181281C40
		}
	
		// Constructors
		public MaterialCache(); // 0x000000018036B6C0-0x000000018036B6D0
		static MaterialCache(); // 0x000000018127EFA0-0x000000018127F170
	
		// Methods
		public static MaterialCache Register(ulong hash, Texture texture, Func<Material> onCreateMaterial); // 0x000000018127EB00-0x000000018127ED60
		public static MaterialCache Register(ulong hash, Func<Material> onCreateMaterial); // 0x000000018127ED60-0x000000018127EF10
		public static void Unregister(MaterialCache cache); // 0x000000018127EF10-0x000000018127EFA0
	}
}
