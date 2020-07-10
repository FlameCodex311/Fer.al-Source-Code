/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class Grayscale : MonoBehaviour // TypeDefIndex: 13848
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Shader _shader; // 0x20
		private Material _material; // 0x28
	
		// Constructors
		public Grayscale(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		private void Start(); // 0x00000001812007B0-0x0000000181200840
		private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x00000001812006B0-0x00000001812007B0
		private void OnDisable(); // 0x0000000181200620-0x00000001812006B0
	}
}
