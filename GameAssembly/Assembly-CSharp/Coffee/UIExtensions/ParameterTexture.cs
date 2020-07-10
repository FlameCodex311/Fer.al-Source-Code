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
	[Serializable]
	public class ParameterTexture // TypeDefIndex: 15494
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15495
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Canvas.WillRenderCanvases <>9__16_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181282130-0x0000000181282190
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <Initialize>b__16_0(); // 0x0000000181281590-0x0000000181281680
		}
	
		// Constructors
		public ParameterTexture(int channels, int instanceLimit, string propertyName); // 0x000000018127F9C0-0x000000018127FAC0
	
		// Methods
		public void Register(IParameterTexture target); // 0x000000018127F550-0x000000018127F600
		public void Unregister(IParameterTexture target); // 0x000000018127F860-0x000000018127F910
		public void SetData(IParameterTexture target, int channelId, byte value); // 0x000000018127F600-0x000000018127F700
		public void SetData(IParameterTexture target, int channelId, float value); // 0x000000018127F700-0x000000018127F860
		public void RegisterMaterial(Material mat); // 0x000000018127F4B0-0x000000018127F550
		public float GetNormalizedIndex(IParameterTexture target); // 0x000000018127F200-0x000000018127F270
		private void Initialize(); // 0x000000018127F270-0x000000018127F4B0
		private void UpdateParameterTexture(); // 0x000000018127F910-0x000000018127F9C0
	}
}
