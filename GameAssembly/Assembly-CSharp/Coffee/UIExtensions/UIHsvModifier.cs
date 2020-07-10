/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001800FD120-0x00000001800FD150
	public class UIHsvModifier : UIEffectBase // TypeDefIndex: 15510
	{
		// Fields
		public const string shaderName = "UI/Hidden/UI-Effect-HSV"; // Metadata: 0x00784BEB
		private static readonly ParameterTexture _ptex; // 0x00
		[Header] // 0x00000001800FD310-0x00000001800FD3A0
		[Range] // 0x00000001800FD310-0x00000001800FD3A0
		[SerializeField] // 0x00000001800FD310-0x00000001800FD3A0
		[Tooltip] // 0x00000001800FD310-0x00000001800FD3A0
		private float m_Hue; // 0x38
		[Range] // 0x00000001800FD5F0-0x00000001800FD660
		[SerializeField] // 0x00000001800FD5F0-0x00000001800FD660
		[Tooltip] // 0x00000001800FD5F0-0x00000001800FD660
		private float m_Saturation; // 0x3C
		[Range] // 0x00000001800FD7A0-0x00000001800FD810
		[SerializeField] // 0x00000001800FD7A0-0x00000001800FD810
		[Tooltip] // 0x00000001800FD7A0-0x00000001800FD810
		private float m_Value; // 0x40
	
		// Properties
		public float saturation { get; set; } // 0x0000000180E426C0-0x0000000180E426D0 0x0000000181487FC0-0x0000000181488060
		public float value { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x0000000181488060-0x0000000181488100
		public float hue { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x0000000181487F20-0x0000000181487FC0
		public override ParameterTexture ptex { get; } // 0x0000000181487EC0-0x0000000181487F20 
	
		// Constructors
		public UIHsvModifier(); // 0x0000000181487E60-0x0000000181487EC0
		static UIHsvModifier(); // 0x0000000181487DF0-0x0000000181487E60
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x0000000181487B20-0x0000000181487CC0
		protected override void SetDirty(); // 0x0000000181487CC0-0x0000000181487DF0
	}
}
