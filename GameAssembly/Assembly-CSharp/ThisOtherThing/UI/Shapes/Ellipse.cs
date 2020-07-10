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
	[AddComponentMenu] // 0x00000001801594C0-0x00000001801594F0
	public class Ellipse : MaskableGraphic, IShape // TypeDefIndex: 13990
	{
		// Fields
		public GeoUtils.OutlineShapeProperties ShapeProperties; // 0xC8
		public Ellipses.EllipseProperties EllipseProperties; // 0xD0
		public GeoUtils.OutlineProperties OutlineProperties; // 0xD8
		public GeoUtils.ShadowsProperties ShadowProperties; // 0xE0
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0xE8
		public Sprite Sprite; // 0xF0
		private GeoUtils.UnitPositionData unitPositionData; // 0xF8
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x108
		private Vector2 radius; // 0x118
	
		// Properties
		public override Texture mainTexture { get; } // 0x00000001819F6260-0x00000001819F6400 
	
		// Constructors
		public Ellipse(); // 0x00000001819F6120-0x00000001819F6260
	
		// Methods
		public void ForceMeshUpdate(); // 0x00000001819F3FD0-0x00000001819F4010
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001819F53B0-0x00000001819F6000
		protected override void UpdateMaterial(); // 0x00000001819F6000-0x00000001819F6120
	}
}
