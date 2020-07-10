/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI;
using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x0000000180159C80-0x0000000180159CB0
	public class Rectangle : MaskableGraphic, IShape // TypeDefIndex: 13995
	{
		// Fields
		public bool flipX; // 0xC8
		public bool flipY; // 0xC9
		public Vector2[] cornerOffsets; // 0xD0
		public GeoUtils.OutlineShapeProperties ShapeProperties; // 0xD8
		public RoundedRects.RoundedProperties RoundedProperties; // 0xE0
		public GeoUtils.OutlineProperties OutlineProperties; // 0xE8
		public GeoUtils.ShadowsProperties ShadowProperties; // 0xF0
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0xF8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Sprite _sprite; // 0x100
		private RoundedRects.RoundedCornerUnitPositionData unitPositionData; // 0x108
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x128
		public Action OnCornersChanged; // 0x138
	
		// Properties
		public Sprite Sprite { get; set; } // 0x00000001803BD370-0x00000001803BD380 0x0000000181A06460-0x0000000181A06480
		public override Texture mainTexture { get; } // 0x0000000181A062C0-0x0000000181A06460 
	
		// Constructors
		public Rectangle(); // 0x0000000181A060F0-0x0000000181A062C0
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000181A050E0-0x0000000181A05130
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000181A05130-0x0000000181A05FD0
		protected override void UpdateMaterial(); // 0x0000000181A05FD0-0x0000000181A060F0
	}
}
