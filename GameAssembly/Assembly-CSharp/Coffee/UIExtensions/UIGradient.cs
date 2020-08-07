/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x0000000180207CD0-0x0000000180207D20
	[DisallowMultipleComponent] // 0x0000000180207CD0-0x0000000180207D20
	public class UIGradient : BaseMeshEffect // TypeDefIndex: 16345
	{
		// Fields
		[SerializeField] // 0x0000000180207F70-0x0000000180207FC0
		[Tooltip] // 0x0000000180207F70-0x0000000180207FC0
		private Direction m_Direction; // 0x20
		[SerializeField] // 0x0000000180208250-0x00000001802082A0
		[Tooltip] // 0x0000000180208250-0x00000001802082A0
		private Color m_Color1; // 0x24
		[SerializeField] // 0x0000000180208510-0x0000000180208560
		[Tooltip] // 0x0000000180208510-0x0000000180208560
		private Color m_Color2; // 0x34
		[SerializeField] // 0x0000000180208790-0x00000001802087E0
		[Tooltip] // 0x0000000180208790-0x00000001802087E0
		private Color m_Color3; // 0x44
		[SerializeField] // 0x0000000180208A00-0x0000000180208A50
		[Tooltip] // 0x0000000180208A00-0x0000000180208A50
		private Color m_Color4; // 0x54
		[Range] // 0x0000000180208E30-0x0000000180208EA0
		[SerializeField] // 0x0000000180208E30-0x0000000180208EA0
		[Tooltip] // 0x0000000180208E30-0x0000000180208EA0
		private float m_Rotation; // 0x64
		[Range] // 0x0000000180209090-0x0000000180209100
		[SerializeField] // 0x0000000180209090-0x0000000180209100
		[Tooltip] // 0x0000000180209090-0x0000000180209100
		private float m_Offset1; // 0x68
		[Range] // 0x00000001802092A0-0x0000000180209310
		[SerializeField] // 0x00000001802092A0-0x0000000180209310
		[Tooltip] // 0x00000001802092A0-0x0000000180209310
		private float m_Offset2; // 0x6C
		[SerializeField] // 0x00000001802096C0-0x0000000180209710
		[Tooltip] // 0x00000001802096C0-0x0000000180209710
		private GradientStyle m_GradientStyle; // 0x70
		[SerializeField] // 0x0000000180209970-0x00000001802099C0
		[Tooltip] // 0x0000000180209970-0x00000001802099C0
		private ColorSpace m_ColorSpace; // 0x74
		[SerializeField] // 0x0000000180209C00-0x0000000180209C50
		[Tooltip] // 0x0000000180209C00-0x0000000180209C50
		private bool m_IgnoreAspectRatio; // 0x78
		private static readonly Vector2[] s_SplitedCharacterPosition; // 0x00
	
		// Properties
		public Graphic targetGraphic { get; } // 0x0000000180789490-0x00000001807894A0 
		public Direction direction { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x000000018078D6B0-0x000000018078D6F0
		public Color color1 { get; set; } // 0x00000001806CEAD0-0x00000001806CEAE0 0x000000018078D470-0x000000018078D4F0
		public Color color2 { get; set; } // 0x000000018078D400-0x000000018078D410 0x000000018078D4F0-0x000000018078D570
		public Color color3 { get; set; } // 0x0000000180788710-0x0000000180788720 0x000000018078D570-0x000000018078D5F0
		public Color color4 { get; set; } // 0x000000018078D410-0x000000018078D420 0x000000018078D5F0-0x000000018078D670
		public float rotation { get; set; } // 0x000000018078D450-0x000000018078D470 0x000000018078D830-0x000000018078D8E0
		public float offset { get; set; } // 0x00000001804C5F40-0x00000001804C5F50 0x000000018078D7E0-0x000000018078D830
		public Vector2 offset2 { get; set; } // 0x000000018078D420-0x000000018078D450 0x000000018078D770-0x000000018078D7E0
		public GradientStyle gradientStyle { get; set; } // 0x00000001804B4700-0x00000001804B4710 0x000000018078D6F0-0x000000018078D730
		public ColorSpace colorSpace { get; set; } // 0x00000001804428A0-0x00000001804428B0 0x000000018078D670-0x000000018078D6B0
		public bool ignoreAspectRatio { get; set; } // 0x0000000180453D00-0x0000000180453D10 0x000000018078D730-0x000000018078D770
	
		// Nested types
		public enum Direction // TypeDefIndex: 16346
		{
			Horizontal = 0,
			Vertical = 1,
			Angle = 2,
			Diagonal = 3
		}
	
		public enum GradientStyle // TypeDefIndex: 16347
		{
			Rect = 0,
			Fit = 1,
			Split = 2
		}
	
		private struct Matrix2x3 // TypeDefIndex: 16348
		{
			// Fields
			public float m00; // 0x00
			public float m01; // 0x04
			public float m02; // 0x08
			public float m10; // 0x0C
			public float m11; // 0x10
			public float m12; // 0x14
	
			// Constructors
			public Matrix2x3(Rect rect, float cos, float sin); // 0x000000018001B550-0x000000018001B580
	
			// Methods
			public static Vector2 operator *(Matrix2x3 m, Vector2 v); // 0x0000000180784A20-0x0000000180784AB0
		}
	
		// Constructors
		public UIGradient(); // 0x000000018078D390-0x000000018078D400
		static UIGradient(); // 0x000000018078D220-0x000000018078D390
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018078CA10-0x000000018078D220
	}
}
