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
	[AddComponentMenu] // 0x0000000180284480-0x00000001802844B0
	public class Arc : MaskableGraphic, IShape // TypeDefIndex: 14654
	{
		// Fields
		public GeoUtils.ShapeProperties ShapeProperties; // 0xC8
		public Ellipses.EllipseProperties EllipseProperties; // 0xD0
		public Arcs.ArcProperties ArcProperties; // 0xD8
		public Lines.LineProperties LineProperties; // 0xE0
		public PointsList.PointListProperties PointListProperties; // 0xE8
		private PointsList.PointsData PointsData; // 0xF0
		public GeoUtils.OutlineProperties OutlineProperties; // 0x170
		public GeoUtils.ShadowsProperties ShadowProperties; // 0x178
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0x180
		private GeoUtils.UnitPositionData unitPositionData; // 0x188
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x198
		private Vector2 radius; // 0x1A8
	
		// Constructors
		public Arc(); // 0x0000000180F7ABF0-0x0000000180F7ADC0
	
		// Methods
		protected override void OnEnable(); // 0x0000000180F798B0-0x0000000180F79940
		public void ForceMeshUpdate(); // 0x0000000180F79840-0x0000000180F798B0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F79940-0x0000000180F7ABF0
	}
}
