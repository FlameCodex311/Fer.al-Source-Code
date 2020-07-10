/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu] // 0x0000000180159A00-0x0000000180159A30
	public class PixelLine : MaskableGraphic, IShape // TypeDefIndex: 13993
	{
		// Fields
		public float LineWeight; // 0xC8
		public GeoUtils.SnappedPositionAndOrientationProperties SnappedProperties; // 0xD0
		private Vector3 center; // 0xD8
	
		// Constructors
		public PixelLine(); // 0x00000001819FCC00-0x00000001819FCCB0
	
		// Methods
		public void ForceMeshUpdate(); // 0x00000001819F3FD0-0x00000001819F4010
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001819FC7D0-0x00000001819FCC00
	}
}
