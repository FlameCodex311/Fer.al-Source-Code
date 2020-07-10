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

namespace ThisOtherThing.UI.ShapeUtils
{
	public class Rects // TypeDefIndex: 13979
	{
		// Fields
		private static Vector3 tmpPos; // 0x00
		private static Vector2 tmpUVPos; // 0x0C
		private static readonly Vector2[] defaultVertOffsets; // 0x18
	
		// Constructors
		public Rects(); // 0x000000018036B6C0-0x000000018036B6D0
		static Rects(); // 0x0000000181A08350-0x0000000181A08540
	
		// Methods
		public static void AddRect(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, Vector2 uv, bool flipUVX, bool flipUVY); // 0x0000000181A07D00-0x0000000181A07DE0
		public static void AddRect(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000181A07A30-0x0000000181A07D00
		public static void AddRectRing(ref VertexHelper vh, GeoUtils.OutlineProperties OutlineProperties, Vector2 center, float width, float height, Color32 color, Vector2 uv, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY); // 0x0000000181A06AA0-0x0000000181A06E50
		public static void AddRectVertRing(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, float totalWidth, float totalHeight, bool addRingIndices = false /* Metadata: 0x00784348 */, Vector2[] vertOffsets = null, bool flipUVX = false /* Metadata: 0x00784349 */, bool flipUVY = false /* Metadata: 0x0078434A */); // 0x0000000181A06E50-0x0000000181A07A30
		public static void AddRectQuadIndices(ref VertexHelper vh); // 0x0000000181A06A00-0x0000000181A06AA0
		public static void AddVerticalTwoColorRect(ref VertexHelper vh, Vector3 topLeft, float height, float width, Color32 topColor, Color32 bottomColor, Vector2 uv); // 0x0000000181A07DE0-0x0000000181A08350
		public static void AddHorizontalTwoColorRect(ref VertexHelper vh, Vector3 topLeft, float height, float width, Color32 leftColor, Color32 rightColor, Vector2 uv); // 0x0000000181A06480-0x0000000181A06A00
	}
}
