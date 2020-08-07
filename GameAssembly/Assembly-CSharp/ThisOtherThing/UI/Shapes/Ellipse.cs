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
	[AddComponentMenu] // 0x00000001802847C0-0x00000001802847F0
	public class Ellipse : MaskableGraphic, IShape // TypeDefIndex: 14658
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
		public override Texture mainTexture { get; } // 0x0000000180F7CDF0-0x0000000180F7CF90 
	
		// Constructors
		public Ellipse(); // 0x0000000180F7CCC0-0x0000000180F7CDF0
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000180F7AE80-0x0000000180F7AEC0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F7BFA0-0x0000000180F7CBA0
		protected override void UpdateMaterial(); // 0x0000000180F7CBA0-0x0000000180F7CCC0
	}
}
