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
	public class Arcs // TypeDefIndex: 14624
	{
		// Fields
		private static Vector3 tmpPosition; // 0x00
		private static Vector2 tmpInnerRadius; // 0x0C
		private static Vector2 tmpOuterRadius; // 0x14
		private static Vector2 tmpArcInnerRadius; // 0x1C
		private static Vector2 tmpArcOuterRadius; // 0x24
		private static Vector3 tmpOffsetCenter; // 0x2C
		private static Vector3 noOverlapInnerOffset; // 0x38
		private static Vector3 noOverlapOuterOffset; // 0x44
	
		// Nested types
		[Serializable]
		public class ArcProperties // TypeDefIndex: 14625
		{
			// Fields
			public ArcDirection Direction; // 0x10
			[Range] // 0x00000001801D3630-0x00000001801D3650
			public float Length; // 0x14
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <AdjustedResolution>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <AdjustedBaseAngle>k__BackingField; // 0x1C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <AdjustedDirection>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <SegmentAngle>k__BackingField; // 0x24
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <EndSegmentAngle>k__BackingField; // 0x28
			private Vector3 endSegmentUnitPosition; // 0x2C
			private Vector3 startTangent; // 0x38
			private Vector3 endTangent; // 0x44
			private Vector3 centerNormal; // 0x50
	
			// Properties
			public int AdjustedResolution { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
			public float AdjustedBaseAngle { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180918C20-0x0000000180918C30 0x0000000180918CF0-0x0000000180918D00
			public float AdjustedDirection { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180373AF0-0x0000000180373B00 0x0000000180373B00-0x0000000180373B10
			public float SegmentAngle { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018090BD10-0x000000018090BD20 0x000000018094A6A0-0x000000018094A6B0
			public float EndSegmentAngle { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
			public Vector3 EndSegmentUnitPosition { get; } // 0x000000018094A640-0x000000018094A660 
			public Vector3 StartTangent { get; } // 0x000000018094A680-0x000000018094A6A0 
			public Vector3 EndTangent { get; } // 0x000000018094A660-0x000000018094A680 
			public Vector3 CenterNormal { get; } // 0x000000018094A620-0x000000018094A640 
	
			// Nested types
			public enum ArcDirection // TypeDefIndex: 14626
			{
				Backward = 0,
				Centered = 1,
				Forward = 2
			}
	
			// Constructors
			public ArcProperties(); // 0x000000018094A550-0x000000018094A620
	
			// Methods
			public void UpdateAdjusted(int FullCircleResolution, float BaseAngle); // 0x000000018094A340-0x000000018094A550
		}
	
		// Constructors
		public Arcs(); // 0x0000000180373240-0x0000000180373250
		static Arcs(); // 0x000000018094EA20-0x000000018094EC30
	
		// Methods
		public static void AddSegment(ref VertexHelper vh, Vector2 center, Vector2 radius, Ellipses.EllipseProperties circleProperties, ArcProperties arcProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x000000018094CF90-0x000000018094EA20
		public static void AddArcRing(ref VertexHelper vh, Vector2 center, Vector2 radius, Ellipses.EllipseProperties ellipseProperties, ArcProperties arcProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData); // 0x000000018094A6B0-0x000000018094CF90
	}
}
