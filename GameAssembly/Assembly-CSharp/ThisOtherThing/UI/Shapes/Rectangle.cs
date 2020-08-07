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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x0000000180286400-0x0000000180286430
	public class Rectangle : MaskableGraphic, IShape // TypeDefIndex: 14663
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
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Sprite _sprite; // 0x100
		private RoundedRects.RoundedCornerUnitPositionData unitPositionData; // 0x108
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x128
		public Action OnCornersChanged; // 0x138
	
		// Properties
		public Sprite Sprite { get; set; } // 0x000000018037F030-0x000000018037F040 0x0000000180F87A30-0x0000000180F87A50
		public override Texture mainTexture { get; } // 0x0000000180F87890-0x0000000180F87A30 
	
		// Constructors
		public Rectangle(); // 0x0000000180F876C0-0x0000000180F87890
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000180F86720-0x0000000180F86770
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F86770-0x0000000180F875A0
		protected override void UpdateMaterial(); // 0x0000000180F875A0-0x0000000180F876C0
	}
}
