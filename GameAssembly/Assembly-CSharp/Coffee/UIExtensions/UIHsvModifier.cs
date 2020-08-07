/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x0000000180209E20-0x0000000180209E50
	public class UIHsvModifier : UIEffectBase // TypeDefIndex: 16349
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect-HSV"; // Metadata: 0x007BBD5B
		private static readonly ParameterTexture _ptex; // 0x00
		[Header] // 0x0000000180209F20-0x0000000180209FB0
		[Range] // 0x0000000180209F20-0x0000000180209FB0
		[SerializeField] // 0x0000000180209F20-0x0000000180209FB0
		[Tooltip] // 0x0000000180209F20-0x0000000180209FB0
		private float m_Hue; // 0x38
		[Range] // 0x000000018020A340-0x000000018020A3B0
		[SerializeField] // 0x000000018020A340-0x000000018020A3B0
		[Tooltip] // 0x000000018020A340-0x000000018020A3B0
		private float m_Saturation; // 0x3C
		[Range] // 0x000000018020A6F0-0x000000018020A760
		[SerializeField] // 0x000000018020A6F0-0x000000018020A760
		[Tooltip] // 0x000000018020A6F0-0x000000018020A760
		private float m_Value; // 0x40
	
		// Properties
		public float saturation { get; set; } // 0x0000000180379EF0-0x0000000180379F00 0x000000018078DE10-0x000000018078DEB0
		public float value { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x000000018078DEB0-0x000000018078DF50
		public float hue { get; set; } // 0x0000000180788790-0x00000001807887A0 0x000000018078DD70-0x000000018078DE10
		public override ParameterTexture ptex { get; } // 0x000000018078DD10-0x000000018078DD70 
	
		// Constructors
		public UIHsvModifier(); // 0x000000018078DCB0-0x000000018078DD10
		static UIHsvModifier(); // 0x000000018078DC40-0x000000018078DCB0
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018078D8E0-0x000000018078DAA0
		protected override void SetDirty(); // 0x000000018078DAA0-0x000000018078DC40
	}
}
