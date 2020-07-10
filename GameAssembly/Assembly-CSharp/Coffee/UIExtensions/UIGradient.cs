/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001800F9BA0-0x00000001800F9BF0
	[DisallowMultipleComponent] // 0x00000001800F9BA0-0x00000001800F9BF0
	public class UIGradient : BaseMeshEffect // TypeDefIndex: 15506
	{
		// Fields
		[SerializeField] // 0x00000001800F9DF0-0x00000001800F9E40
		[Tooltip] // 0x00000001800F9DF0-0x00000001800F9E40
		private Direction m_Direction; // 0x20
		[SerializeField] // 0x00000001800FA080-0x00000001800FA0D0
		[Tooltip] // 0x00000001800FA080-0x00000001800FA0D0
		private Color m_Color1; // 0x24
		[SerializeField] // 0x00000001800FA370-0x00000001800FA3C0
		[Tooltip] // 0x00000001800FA370-0x00000001800FA3C0
		private Color m_Color2; // 0x34
		[SerializeField] // 0x00000001800FA5F0-0x00000001800FA640
		[Tooltip] // 0x00000001800FA5F0-0x00000001800FA640
		private Color m_Color3; // 0x44
		[SerializeField] // 0x00000001800FA800-0x00000001800FA850
		[Tooltip] // 0x00000001800FA800-0x00000001800FA850
		private Color m_Color4; // 0x54
		[Range] // 0x00000001800FA9A0-0x00000001800FAA10
		[SerializeField] // 0x00000001800FA9A0-0x00000001800FAA10
		[Tooltip] // 0x00000001800FA9A0-0x00000001800FAA10
		private float m_Rotation; // 0x64
		[Range] // 0x00000001800FAC90-0x00000001800FAD00
		[SerializeField] // 0x00000001800FAC90-0x00000001800FAD00
		[Tooltip] // 0x00000001800FAC90-0x00000001800FAD00
		private float m_Offset1; // 0x68
		[Range] // 0x00000001800FC270-0x00000001800FC2E0
		[SerializeField] // 0x00000001800FC270-0x00000001800FC2E0
		[Tooltip] // 0x00000001800FC270-0x00000001800FC2E0
		private float m_Offset2; // 0x6C
		[SerializeField] // 0x00000001800FC6D0-0x00000001800FC720
		[Tooltip] // 0x00000001800FC6D0-0x00000001800FC720
		private GradientStyle m_GradientStyle; // 0x70
		[SerializeField] // 0x00000001800FC900-0x00000001800FC950
		[Tooltip] // 0x00000001800FC900-0x00000001800FC950
		private ColorSpace m_ColorSpace; // 0x74
		[SerializeField] // 0x00000001800FCC80-0x00000001800FCCD0
		[Tooltip] // 0x00000001800FCC80-0x00000001800FCCD0
		private bool m_IgnoreAspectRatio; // 0x78
		private static readonly Vector2[] s_SplitedCharacterPosition; // 0x00
	
		// Properties
		public Graphic targetGraphic { get; } // 0x0000000181484F30-0x0000000181484F40 
		public Direction direction { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001814878F0-0x0000000181487930
		public Color color1 { get; set; } // 0x0000000180E98260-0x0000000180E98270 0x00000001814876B0-0x0000000181487730
		public Color color2 { get; set; } // 0x0000000181487650-0x0000000181487660 0x0000000181487730-0x00000001814877B0
		public Color color3 { get; set; } // 0x00000001812834F0-0x0000000181283500 0x00000001814877B0-0x0000000181487830
		public Color color4 { get; set; } // 0x00000001811FE7A0-0x00000001811FE7B0 0x0000000181487830-0x00000001814878B0
		public float rotation { get; set; } // 0x0000000181487690-0x00000001814876B0 0x0000000181487A70-0x0000000181487B20
		public float offset { get; set; } // 0x0000000180487D00-0x0000000180487D10 0x0000000181487A20-0x0000000181487A70
		public Vector2 offset2 { get; set; } // 0x0000000181487660-0x0000000181487690 0x00000001814879B0-0x0000000181487A20
		public GradientStyle gradientStyle { get; set; } // 0x00000001803DAD00-0x00000001803DAD10 0x0000000181487930-0x0000000181487970
		public ColorSpace colorSpace { get; set; } // 0x00000001803DAD10-0x00000001803DAD20 0x00000001814878B0-0x00000001814878F0
		public bool ignoreAspectRatio { get; set; } // 0x00000001804A2540-0x00000001804A2550 0x0000000181487970-0x00000001814879B0
	
		// Nested types
		public enum Direction // TypeDefIndex: 15507
		{
			Horizontal = 0,
			Vertical = 1,
			Angle = 2,
			Diagonal = 3
		}
	
		public enum GradientStyle // TypeDefIndex: 15508
		{
			Rect = 0,
			Fit = 1,
			Split = 2
		}
	
		private struct Matrix2x3 // TypeDefIndex: 15509
		{
			// Fields
			public float m00; // 0x00
			public float m01; // 0x04
			public float m02; // 0x08
			public float m10; // 0x0C
			public float m11; // 0x10
			public float m12; // 0x14
	
			// Constructors
			public Matrix2x3(Rect rect, float cos, float sin); // 0x00000001802295D0-0x0000000180229680
	
			// Methods
			public static Vector2 operator *(Matrix2x3 m, Vector2 v); // 0x000000018127F170-0x000000018127F200
		}
	
		// Constructors
		public UIGradient(); // 0x00000001814875E0-0x0000000181487650
		static UIGradient(); // 0x0000000181487460-0x00000001814875E0
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x0000000181486C40-0x0000000181487460
	}
}
