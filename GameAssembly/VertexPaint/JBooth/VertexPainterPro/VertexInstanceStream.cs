/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: VertexPaint.dll - Assembly: VertexPaint, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9676-9677

namespace JBooth.VertexPainterPro
{
	[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class VertexInstanceStream : UnityEngine.MonoBehaviour // TypeDefIndex: 9677
	{
		// Fields
		public bool keepRuntimeData; // 0x18
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Color[] _colors; // 0x20
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<Vector4> _uv0; // 0x28
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<Vector4> _uv1; // 0x30
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<Vector4> _uv2; // 0x38
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<Vector4> _uv3; // 0x40
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Vector3[] _positions; // 0x48
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Vector3[] _normals; // 0x50
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Vector4[] _tangents; // 0x58
		private bool enforcedColorChannels; // 0x60
		private Mesh meshStream; // 0x68
	
		// Properties
		public Color[] colors { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001820E3BB0-0x00000001820E3BF0
		public List<Vector4> uv0 { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001820E3C20-0x00000001820E3C30
		public List<Vector4> uv1 { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001820E3C30-0x00000001820E3C40
		public List<Vector4> uv2 { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001820E3C40-0x00000001820E3C50
		public List<Vector4> uv3 { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001820E3C50-0x00000001820E3C60
		public Vector3[] positions { get; set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001820E3C00-0x00000001820E3C10
		public Vector3[] normals { get; set; } // 0x0000000180378320-0x0000000180378330 0x00000001820E3BF0-0x00000001820E3C00
		public Vector4[] tangents { get; set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001820E3C10-0x00000001820E3C20
	
		// Constructors
		public VertexInstanceStream(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Start(); // 0x00000001820E3B30-0x00000001820E3BB0
		private void OnDestroy(); // 0x00000001820E3A90-0x00000001820E3B30
		private void EnforceOriginalMeshHasColors(Mesh stream); // 0x00000001820E3960-0x00000001820E3A90
		public Mesh Apply(bool markNoLongerReadable = true /* Metadata: 0x0077A1C3 */); // 0x00000001820E3410-0x00000001820E3960
	}
}
