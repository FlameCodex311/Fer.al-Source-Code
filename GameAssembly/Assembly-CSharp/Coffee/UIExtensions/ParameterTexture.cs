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
	[Serializable]
	public class ParameterTexture // TypeDefIndex: 16333
	{
		// Fields
		private Texture2D _texture; // 0x10
		private bool _needUpload; // 0x18
		private int _propertyId; // 0x1C
		private readonly string _propertyName; // 0x20
		private readonly int _channels; // 0x28
		private readonly int _instanceLimit; // 0x2C
		private readonly byte[] _data; // 0x30
		private readonly Stack<int> _stack; // 0x38
		private static List<Action> updates; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16334
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Canvas.WillRenderCanvases <>9__16_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180787120-0x0000000180787180
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <Initialize>b__16_0(); // 0x0000000180786780-0x0000000180786870
		}
	
		// Constructors
		public ParameterTexture(int channels, int instanceLimit, string propertyName); // 0x0000000180785180-0x0000000180785280
	
		// Methods
		public void Register(IParameterTexture target); // 0x0000000180784DF0-0x0000000180784EA0
		public void Unregister(IParameterTexture target); // 0x0000000180785030-0x00000001807850D0
		public void SetData(IParameterTexture target, int channelId, byte value); // 0x0000000180784EA0-0x0000000180784F90
		public void SetData(IParameterTexture target, int channelId, float value); // 0x0000000180784F90-0x0000000180785030
		public void RegisterMaterial(Material mat); // 0x0000000180784D50-0x0000000180784DF0
		public float GetNormalizedIndex(IParameterTexture target); // 0x0000000180784AB0-0x0000000180784B20
		private void Initialize(); // 0x0000000180784B20-0x0000000180784D50
		private void UpdateParameterTexture(); // 0x00000001807850D0-0x0000000180785180
	}
}
