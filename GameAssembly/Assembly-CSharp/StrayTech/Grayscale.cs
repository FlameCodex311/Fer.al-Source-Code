/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class Grayscale : MonoBehaviour // TypeDefIndex: 14515
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Shader _shader; // 0x20
		private Material _material; // 0x28
	
		// Constructors
		public Grayscale(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		private void Start(); // 0x0000000180CB5470-0x0000000180CB5500
		private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x0000000180CB5370-0x0000000180CB5470
		private void OnDisable(); // 0x0000000180CB52E0-0x0000000180CB5370
	}
}
