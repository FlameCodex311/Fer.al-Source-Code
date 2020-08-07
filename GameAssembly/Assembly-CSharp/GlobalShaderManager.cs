/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GlobalShaderManager : SingletonManagerBase<GlobalShaderManager> // TypeDefIndex: 12197
{
	// Fields
	public List<ShaderTexture> textures; // 0x60
	public List<ShaderZeroOneRange> ranges; // 0x68
	public List<ShaderFloat> floats; // 0x70
	public List<ShaderVector> vectors; // 0x78

	// Properties
	private List<ShaderPropertyBase> AllProperties { get; } // 0x0000000180683B90-0x0000000180683C40 

	// Nested types
	public abstract class ShaderPropertyBase // TypeDefIndex: 12198
	{
		// Fields
		public string propertyName; // 0x10

		// Constructors
		protected ShaderPropertyBase(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public abstract void Apply(Material inMaterial);
	}

	[Serializable]
	public class ShaderTexture : ShaderPropertyBase // TypeDefIndex: 12199
	{
		// Fields
		public Texture2D texture; // 0x18

		// Constructors
		public ShaderTexture(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000180687F80-0x0000000180687FB0
	}

	[Serializable]
	public class ShaderZeroOneRange : ShaderPropertyBase // TypeDefIndex: 12200
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float value; // 0x18

		// Constructors
		public ShaderZeroOneRange(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000180687F50-0x0000000180687F80
	}

	[Serializable]
	public class ShaderFloat : ShaderPropertyBase // TypeDefIndex: 12201
	{
		// Fields
		public float value; // 0x18

		// Constructors
		public ShaderFloat(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000180687F50-0x0000000180687F80
	}

	[Serializable]
	public class ShaderVector : ShaderPropertyBase // TypeDefIndex: 12202
	{
		// Fields
		public Vector3 value; // 0x18

		// Constructors
		public ShaderVector(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public override void Apply(Material inMaterial); // 0x0000000180687FB0-0x0000000180688070
	}

	// Constructors
	public GlobalShaderManager(); // 0x0000000180683AC0-0x0000000180683B90

	// Methods
	public void ApplyToMaterial(Material inMaterial); // 0x00000001806838F0-0x0000000180683AC0
}

