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
	public class Ellipses // TypeDefIndex: 13959
	{
		// Fields
		private static Vector3 tmpVertPos; // 0x00
		private static Vector2 tmpUVPos; // 0x0C
		private static Vector3 tmpInnerRadius; // 0x14
		private static Vector3 tmpOuterRadius; // 0x20
	
		// Nested types
		[Serializable]
		public class EllipseProperties // TypeDefIndex: 13960
		{
			// Fields
			public EllipseFitting Fitting; // 0x10
			public float BaseAngle; // 0x14
			public ResolutionType Resolution; // 0x18
			public int FixedResolution; // 0x1C
			public float ResolutionMaxDistance; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <AdjustedResolution>k__BackingField; // 0x24
	
			// Properties
			public int AdjustedResolution { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
	
			// Nested types
			public enum EllipseFitting // TypeDefIndex: 13961
			{
				Ellipse = 0,
				UniformInner = 1,
				UniformOuter = 2
			}
	
			public enum ResolutionType // TypeDefIndex: 13962
			{
				Calculated = 0,
				Fixed = 1
			}
	
			// Constructors
			public EllipseProperties(); // 0x00000001819F5390-0x00000001819F53B0
	
			// Methods
			public void OnCheck(); // 0x00000001819F5170-0x00000001819F51F0
			public void UpdateAdjusted(Vector2 radius, float offset); // 0x00000001819F51F0-0x00000001819F5390
		}
	
		// Constructors
		public Ellipses(); // 0x000000018036B6C0-0x000000018036B6D0
		static Ellipses(); // 0x00000001811FDD40-0x00000001811FDE50
	
		// Methods
		public static void SetRadius(ref Vector2 radius, float width, float height, EllipseProperties properties); // 0x00000001811FDC40-0x00000001811FDD40
		public static void AddCircle(ref VertexHelper vh, Vector2 center, Vector2 radius, EllipseProperties ellipseProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x00000001811FBB20-0x00000001811FC9A0
		public static void AddRing(ref VertexHelper vh, Vector2 center, Vector2 radius, GeoUtils.OutlineProperties outlineProperties, EllipseProperties ellipseProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x00000001811FC9A0-0x00000001811FDC40
	}
}
