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
	[AddComponentMenu] // 0x0000000180284B40-0x0000000180284B70
	public class Line : MaskableGraphic, IShape // TypeDefIndex: 14660
	{
		// Fields
		public GeoUtils.ShapeProperties ShapeProperties; // 0xC8
		public PointsList.PointListsProperties PointListsProperties; // 0xD0
		public Lines.LineProperties LineProperties; // 0xD8
		public GeoUtils.OutlineProperties OutlineProperties; // 0xE0
		public GeoUtils.ShadowsProperties ShadowProperties; // 0xE8
		public GeoUtils.AntiAliasingProperties AntiAliasingProperties; // 0xF0
		public Sprite Sprite; // 0xF8
		private PointsList.PointsData[] pointsListData; // 0x100
		private GeoUtils.EdgeGradientData edgeGradientData; // 0x108
	
		// Properties
		public override Texture mainTexture { get; } // 0x0000000180F7E060-0x0000000180F7E200 
	
		// Constructors
		public Line(); // 0x0000000180F7DF00-0x0000000180F7E060
	
		// Methods
		public void ForceMeshUpdate(); // 0x0000000180F7D0D0-0x0000000180F7D280
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180F7D280-0x0000000180F7DDE0
		protected override void UpdateMaterial(); // 0x0000000180F7DDE0-0x0000000180F7DF00
	}
}
