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
	[AddComponentMenu] // 0x0000000180286690-0x00000001802866C0
	public class Sector : MaskableGraphic, IShape // TypeDefIndex: 14664
	{
		// Fields
		public GeoUtils.ShapeProperties ShapeProperties; // 0xC8
		public Ellipses.EllipseProperties EllipseProperties; // 0xD0
		public Arcs.ArcProperties ArcProperties; // 0xD8
		public GeoUtils.ShadowsProperties ShadowProperties; // 0xE0
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0xE8
		private GeoUtils.UnitPositionData unitPositionData; // 0xF0
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x100
		private Vector2 radius; // 0x110
		private Rect pixelRect; // 0x118
	
		// Constructors
		public Sector(); // 0x0000000180F8D1C0-0x0000000180F8D2F0
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000180F7AE80-0x0000000180F7AEC0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F8CA90-0x0000000180F8D1C0
	}
}
