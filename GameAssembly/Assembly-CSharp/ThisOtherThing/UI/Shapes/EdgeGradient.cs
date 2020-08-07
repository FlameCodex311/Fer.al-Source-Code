/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x0000000180284620-0x0000000180284650
	public class EdgeGradient : MaskableGraphic, IShape // TypeDefIndex: 14655
	{
		// Fields
		public GradientProperty[] Properties; // 0xC8
		private Vector3 topLeft; // 0xD0
		private Color32 gradientColor; // 0xDC
	
		// Nested types
		public enum Positions // TypeDefIndex: 14656
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
		public class GradientProperty // TypeDefIndex: 14657
		{
			// Fields
			public float Size; // 0x10
			public Color32 Color; // 0x14
			public Positions Position; // 0x18
	
			// Constructors
			public GradientProperty(); // 0x0000000180F7CFF0-0x0000000180F7D040
		}
	
		// Constructors
		public EdgeGradient(); // 0x0000000180F7BE30-0x0000000180F7BFA0
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000180F7AE80-0x0000000180F7AEC0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F7AEC0-0x0000000180F7BE30
	}
}
