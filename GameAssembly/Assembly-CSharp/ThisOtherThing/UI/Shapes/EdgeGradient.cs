/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x00000001801591C0-0x00000001801591F0
	public class EdgeGradient : MaskableGraphic, IShape // TypeDefIndex: 13987
	{
		// Fields
		public GradientProperty[] Properties; // 0xC8
		private Vector3 topLeft; // 0xD0
		private Color32 gradientColor; // 0xDC
	
		// Nested types
		public enum Positions // TypeDefIndex: 13988
		{
			Top = 0,
			Bottom = 1,
			Left = 2,
			Right = 3,
			OuterTop = 4,
			OuterBottom = 5,
			OuterLeft = 6,
			OuterRight = 7
		}
	
		[Serializable]
		public class GradientProperty // TypeDefIndex: 13989
		{
			// Fields
			public float Size; // 0x10
			public Color32 Color; // 0x14
			public Positions Position; // 0x18
	
			// Constructors
			public GradientProperty(); // 0x00000001819F6460-0x00000001819F64B0
		}
	
		// Constructors
		public EdgeGradient(); // 0x00000001819F5000-0x00000001819F5170
	
		// Methods
		public void ForceMeshUpdate(); // 0x00000001819F3FD0-0x00000001819F4010
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001819F4010-0x00000001819F5000
	}
}
