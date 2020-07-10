/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 73: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8910-8940

namespace AmplifyImpostors
{
	public class AmplifyImpostor : UnityEngine.MonoBehaviour // TypeDefIndex: 8915
	{
		// Fields
		private const string ShaderGUID = "e82933f4c0eb9ba42aab0739f48efe21"; // Metadata: 0x00743B83
		private const string DilateGUID = "57c23892d43bc9f458360024c5985405"; // Metadata: 0x00743BA7
		private const string PackerGUID = "31bd3cd74692f384a916d9d7ea87710d"; // Metadata: 0x00743BCB
		private const string ShaderOctaGUID = "572f9be5706148142b8da6e9de53acdb"; // Metadata: 0x00743BEF
		private const string StandardPreset = "e4786beb7716da54dbb02a632681cc37"; // Metadata: 0x00743C13
		private const string LWPreset = "089f3a2f6b5f48348a48c755f8d9a7a2"; // Metadata: 0x00743C37
		private const string LWShaderOctaGUID = "94e2ddcdfb3257a43872042f97e2fb01"; // Metadata: 0x00743C5B
		private const string LWShaderGUID = "990451a2073f6994ebf9fd6f90a842b3"; // Metadata: 0x00743C7F
		private const string HDPreset = "47b6b3dcefe0eaf4997acf89caf8c75e"; // Metadata: 0x00743CA3
		private const string HDShaderOctaGUID = "56236dc63ad9b7949b63a27f0ad180b3"; // Metadata: 0x00743CC7
		private const string HDShaderGUID = "175c951fec709c44fa2f26b8ab78b8dd"; // Metadata: 0x00743CEB
		private const string UPreset = "0403878495ffa3c4e9d4bcb3eac9b559"; // Metadata: 0x00743D0F
		private const string UShaderOctaGUID = "83dd8de9a5c14874884f9012def4fdcc"; // Metadata: 0x00743D33
		private const string UShaderGUID = "da79d698f4bf0164e910ad798d07efdf"; // Metadata: 0x00743D57
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AmplifyImpostorAsset m_data; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform m_rootTransform; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LODGroup m_lodGroup; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Renderer[] m_renderers; // 0x30
		public LODReplacement m_lodReplacement; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public RenderPipelineInUse m_renderPipelineInUse; // 0x3C
		public int m_insertIndex; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public GameObject m_lastImpostor; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public string m_folderPath; // 0x50
		[NonSerialized]
		public string m_impostorName; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public CutMode m_cutMode; // 0x60
		[NonSerialized]
		private const float StartXRotation = -90f; // Metadata: 0x00743D7B
		[NonSerialized]
		private const float StartYRotation = 90f; // Metadata: 0x00743D7F
		[NonSerialized]
		private const int MinAlphaResolution = 256; // Metadata: 0x00743D83
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
		private const int BlockSize = 65536; // Metadata: 0x00743D87
	
		// Properties
		public AmplifyImpostorAsset Data { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public Transform RootTransform { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public LODGroup LodGroup { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public Renderer[] Renderers { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	
		// Constructors
		public AmplifyImpostor(); // 0x00000001822B1890-0x00000001822B19C0
	
		// Methods
		private void GenerateTextures(List<TextureOutput> outputList, bool standardRendering); // 0x00000001822AE370-0x00000001822AEB60
		private void GenerateAlphaTextures(List<TextureOutput> outputList); // 0x00000001822AD480-0x00000001822AD6C0
		private void ClearBuffers(); // 0x00000001822AD3F0-0x00000001822AD480
		private void ClearAlphaBuffers(); // 0x00000001822AD360-0x00000001822AD3F0
		public void RenderImpostor(ImpostorType impostorType, int targetAmount, bool impostorMaps = true /* Metadata: 0x00743B77 */, bool combinedAlphas = false /* Metadata: 0x00743B78 */, bool useMinResolution = false /* Metadata: 0x00743B79 */, Shader customShader = null); // 0x00000001822AF610-0x00000001822B1890
		private Matrix4x4 GetCameraRotationMatrix(ImpostorType impostorType, int hframes, int vframes, int x, int y); // 0x00000001822AEB60-0x00000001822AF1A0
		private Vector3 OctahedronToVector(Vector2 oct); // 0x00000001822AF2E0-0x00000001822AF470
		private Vector3 OctahedronToVector(float x, float y); // 0x00000001822AF470-0x00000001822AF610
		private Vector3 HemiOctahedronToVector(float x, float y); // 0x00000001822AF1A0-0x00000001822AF2E0
		public void GenerateAutomaticMesh(AmplifyImpostorAsset data); // 0x00000001822AD6C0-0x00000001822ADE30
		public Mesh GenerateMesh(Vector2[] points, Vector3 offset, float width = 1f /* Metadata: 0x00743B7A */, float height = 1f /* Metadata: 0x00743B7E */, bool invertY = true /* Metadata: 0x00743B82 */); // 0x00000001822ADE30-0x00000001822AE370
	}
}
