/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 79: VertexPaint.dll - Assembly: VertexPaint, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9272-9273

namespace JBooth.VertexPainterPro
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class VertexInstanceStream : UnityEngine.MonoBehaviour // TypeDefIndex: 9273
	{
		// Fields
		public bool keepRuntimeData; // 0x18
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private Color[] _colors; // 0x20
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<Vector4> _uv0; // 0x28
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<Vector4> _uv1; // 0x30
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<Vector4> _uv2; // 0x38
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<Vector4> _uv3; // 0x40
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private Vector3[] _positions; // 0x48
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private Vector3[] _normals; // 0x50
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private Vector4[] _tangents; // 0x58
		private bool enforcedColorChannels; // 0x60
		private Mesh meshStream; // 0x68
	
		// Properties
		public Color[] colors { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x00000001822CF9B0-0x00000001822CF9F0
		public List<Vector4> uv0 { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x00000001822CFA20-0x00000001822CFA30
		public List<Vector4> uv1 { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001822CFA30-0x00000001822CFA40
		public List<Vector4> uv2 { get; set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001822CFA40-0x00000001822CFA50
		public List<Vector4> uv3 { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001822CFA50-0x00000001822CFA60
		public Vector3[] positions { get; set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001822CFA00-0x00000001822CFA10
		public Vector3[] normals { get; set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001822CF9F0-0x00000001822CFA00
		public Vector4[] tangents { get; set; } // 0x0000000180357120-0x0000000180357130 0x00000001822CFA10-0x00000001822CFA20
	
		// Constructors
		public VertexInstanceStream(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x00000001822CF920-0x00000001822CF9B0
		private void OnDestroy(); // 0x00000001822CF880-0x00000001822CF920
		private void EnforceOriginalMeshHasColors(Mesh stream); // 0x00000001822CF740-0x00000001822CF880
		public Mesh Apply(bool markNoLongerReadable = true /* Metadata: 0x00744EB9 */); // 0x00000001822CF1E0-0x00000001822CF740
	}
}
