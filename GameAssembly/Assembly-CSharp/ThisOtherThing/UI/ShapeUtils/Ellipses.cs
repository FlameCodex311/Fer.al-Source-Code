/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ThisOtherThing.UI.ShapeUtils
{
	public class Ellipses // TypeDefIndex: 14627
	{
		// Fields
		private static Vector3 tmpVertPos; // 0x00
		private static Vector2 tmpUVPos; // 0x0C
		private static Vector3 tmpInnerRadius; // 0x14
		private static Vector3 tmpOuterRadius; // 0x20
	
		// Nested types
		[Serializable]
		public class EllipseProperties // TypeDefIndex: 14628
		{
			// Fields
			public EllipseFitting Fitting; // 0x10
			public float BaseAngle; // 0x14
			public ResolutionType Resolution; // 0x18
			public int FixedResolution; // 0x1C
			public float ResolutionMaxDistance; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <AdjustedResolution>k__BackingField; // 0x24
	
			// Properties
			public int AdjustedResolution { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180569610-0x0000000180569620
	
			// Nested types
			public enum EllipseFitting // TypeDefIndex: 14629
			{
				Ellipse = 0,
				UniformInner = 1,
				UniformOuter = 2
			}
	
			public enum ResolutionType // TypeDefIndex: 14630
			{
				Calculated = 0,
				Fixed = 1
			}
	
			// Constructors
			public EllipseProperties(); // 0x000000018094EE50-0x000000018094EE70
	
			// Methods
			public void OnCheck(); // 0x000000018094EC30-0x000000018094ECB0
			public void UpdateAdjusted(Vector2 radius, float offset); // 0x000000018094ECB0-0x000000018094EE50
		}
	
		// Constructors
		public Ellipses(); // 0x0000000180373240-0x0000000180373250
		static Ellipses(); // 0x0000000180950FE0-0x00000001809510F0
	
		// Methods
		public static void SetRadius(ref Vector2 radius, float width, float height, EllipseProperties properties); // 0x0000000180950EE0-0x0000000180950FE0
		public static void AddCircle(ref VertexHelper vh, Vector2 center, Vector2 radius, EllipseProperties ellipseProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x000000018094EE70-0x000000018094FC90
		public static void AddRing(ref VertexHelper vh, Vector2 center, Vector2 radius, GeoUtils.OutlineProperties outlineProperties, EllipseProperties ellipseProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x000000018094FC90-0x0000000180950EE0
	}
}
