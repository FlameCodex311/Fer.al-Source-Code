/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GlobalShaderManager : SingletonManagerBase<GlobalShaderManager> // TypeDefIndex: 10689
{
	// Fields
	public List<ShaderTexture> textures; // 0x60
	public List<ShaderZeroOneRange> ranges; // 0x68
	public List<ShaderFloat> floats; // 0x70
	public List<ShaderVector> vectors; // 0x78

	// Properties
	private List<ShaderPropertyBase> AllProperties { get; } // 0x0000000181058520-0x00000001810585D0 

	// Nested types
	public abstract class ShaderPropertyBase // TypeDefIndex: 10690
	{
		// Fields
		public string propertyName; // 0x10

		// Constructors
		protected ShaderPropertyBase(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public abstract void Apply(Material inMaterial);
	}

	[Serializable]
	public class ShaderTexture : ShaderPropertyBase // TypeDefIndex: 10691
	{
		// Fields
		public Texture2D texture; // 0x18

		// Constructors
		public ShaderTexture(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000181060430-0x0000000181060460
	}

	[Serializable]
	public class ShaderZeroOneRange : ShaderPropertyBase // TypeDefIndex: 10692
	{
		// Fields
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float value; // 0x18

		// Constructors
		public ShaderZeroOneRange(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000181060400-0x0000000181060430
	}

	[Serializable]
	public class ShaderFloat : ShaderPropertyBase // TypeDefIndex: 10693
	{
		// Fields
		public float value; // 0x18

		// Constructors
		public ShaderFloat(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000181060400-0x0000000181060430
	}

	[Serializable]
	public class ShaderVector : ShaderPropertyBase // TypeDefIndex: 10694
	{
		// Fields
		public Vector3 value; // 0x18

		// Constructors
		public ShaderVector(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000181060460-0x0000000181060520
	}

	// Constructors
	public GlobalShaderManager(); // 0x0000000181058450-0x0000000181058520

	// Methods
	public void ApplyToMaterial(Material inMaterial); // 0x0000000181058280-0x0000000181058450
}

