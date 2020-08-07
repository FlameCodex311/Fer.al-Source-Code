/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 74: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9076-9106

namespace AmplifyImpostors
{
	public class AmplifyImpostor : UnityEngine.MonoBehaviour // TypeDefIndex: 9081
	{
		// Fields
		private const string ShaderGUID = "e82933f4c0eb9ba42aab0739f48efe21"; // Metadata: 0x00778871
		private const string DilateGUID = "57c23892d43bc9f458360024c5985405"; // Metadata: 0x00778895
		private const string PackerGUID = "31bd3cd74692f384a916d9d7ea87710d"; // Metadata: 0x007788B9
		private const string ShaderOctaGUID = "572f9be5706148142b8da6e9de53acdb"; // Metadata: 0x007788DD
		private const string StandardPreset = "e4786beb7716da54dbb02a632681cc37"; // Metadata: 0x00778901
		private const string LWPreset = "089f3a2f6b5f48348a48c755f8d9a7a2"; // Metadata: 0x00778925
		private const string LWShaderOctaGUID = "94e2ddcdfb3257a43872042f97e2fb01"; // Metadata: 0x00778949
		private const string LWShaderGUID = "990451a2073f6994ebf9fd6f90a842b3"; // Metadata: 0x0077896D
		private const string HDPreset = "47b6b3dcefe0eaf4997acf89caf8c75e"; // Metadata: 0x00778991
		private const string HDShaderOctaGUID = "56236dc63ad9b7949b63a27f0ad180b3"; // Metadata: 0x007789B5
		private const string HDShaderGUID = "175c951fec709c44fa2f26b8ab78b8dd"; // Metadata: 0x007789D9
		private const string UPreset = "0403878495ffa3c4e9d4bcb3eac9b559"; // Metadata: 0x007789FD
		private const string UShaderOctaGUID = "83dd8de9a5c14874884f9012def4fdcc"; // Metadata: 0x00778A21
		private const string UShaderGUID = "da79d698f4bf0164e910ad798d07efdf"; // Metadata: 0x00778A45
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AmplifyImpostorAsset m_data; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform m_rootTransform; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LODGroup m_lodGroup; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Renderer[] m_renderers; // 0x30
		public LODReplacement m_lodReplacement; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public RenderPipelineInUse m_renderPipelineInUse; // 0x3C
		public int m_insertIndex; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GameObject m_lastImpostor; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string m_folderPath; // 0x50
		[NonSerialized]
		public string m_impostorName; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public CutMode m_cutMode; // 0x60
		[NonSerialized]
		private const float StartXRotation = -90f; // Metadata: 0x00778A69
		[NonSerialized]
		private const float StartYRotation = 90f; // Metadata: 0x00778A6D
		[NonSerialized]
		private const int MinAlphaResolution = 256; // Metadata: 0x00778A71
		[NonSerialized]
		private RenderTexture[] m_rtGBuffers; // 0x68
		[NonSerialized]
		private RenderTexture[] m_alphaGBuffers; // 0x70
		[NonSerialized]
		private RenderTexture m_trueDepth; // 0x78
		[NonSerialized]
		public Texture2D m_alphaTex; // 0x80
		[NonSerialized]
		private float m_xyFitSize; // 0x88
		[NonSerialized]
		private float m_depthFitSize; // 0x8C
		[NonSerialized]
		private Vector2 m_pixelOffset; // 0x90
		[NonSerialized]
		private Bounds m_originalBound; // 0x98
		[NonSerialized]
		private Vector3 m_oriPos; // 0xB0
		[NonSerialized]
		private Quaternion m_oriRot; // 0xBC
		[NonSerialized]
		private Vector3 m_oriSca; // 0xCC
		[NonSerialized]
		private const int BlockSize = 65536; // Metadata: 0x00778A75
	
		// Properties
		public AmplifyImpostorAsset Data { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public Transform RootTransform { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public LODGroup LodGroup { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public Renderer[] Renderers { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	
		// Constructors
		public AmplifyImpostor(); // 0x0000000182089110-0x0000000182089240
	
		// Methods
		private void GenerateTextures(List<TextureOutput> outputList, bool standardRendering); // 0x0000000182085D00-0x0000000182086490
		private void GenerateAlphaTextures(List<TextureOutput> outputList); // 0x0000000182084E90-0x00000001820850C0
		private void ClearBuffers(); // 0x0000000182084E00-0x0000000182084E90
		private void ClearAlphaBuffers(); // 0x0000000182084D70-0x0000000182084E00
		public void RenderImpostor(ImpostorType impostorType, int targetAmount, bool impostorMaps = true /* Metadata: 0x00778865 */, bool combinedAlphas = false /* Metadata: 0x00778866 */, bool useMinResolution = false /* Metadata: 0x00778867 */, Shader customShader = null); // 0x0000000182086F40-0x0000000182089110
		private Matrix4x4 GetCameraRotationMatrix(ImpostorType impostorType, int hframes, int vframes, int x, int y); // 0x0000000182086490-0x0000000182086AD0
		private Vector3 OctahedronToVector(Vector2 oct); // 0x0000000182086C10-0x0000000182086DA0
		private Vector3 OctahedronToVector(float x, float y); // 0x0000000182086DA0-0x0000000182086F40
		private Vector3 HemiOctahedronToVector(float x, float y); // 0x0000000182086AD0-0x0000000182086C10
		public void GenerateAutomaticMesh(AmplifyImpostorAsset data); // 0x00000001820850C0-0x00000001820857E0
		public Mesh GenerateMesh(Vector2[] points, Vector3 offset, float width = 1f /* Metadata: 0x00778868 */, float height = 1f /* Metadata: 0x0077886C */, bool invertY = true /* Metadata: 0x00778870 */); // 0x00000001820857E0-0x0000000182085D00
	}
}
