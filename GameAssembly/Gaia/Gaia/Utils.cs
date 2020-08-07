/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class Utils : UnityEngine.MonoBehaviour // TypeDefIndex: 9264
	{
		// Constructors
		public Utils(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		public static string GetGaiaAssetDirectory(); // 0x00000001817007F0-0x00000001817008B0
		public static string GetGaiaAssetDirectory(GaiaConstants.FeatureType featureType); // 0x00000001817008B0-0x00000001817009D0
		public static List<string> GetGaiaStampsList(GaiaConstants.FeatureType featureType); // 0x0000000181700C40-0x0000000181700CC0
		public static string GetGaiaAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x00000001817009D0-0x0000000181700A70
		public static string GetGaiaStampAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x0000000181700AD0-0x0000000181700B80
		public static string GetGaiaStampPath(Texture2D source); // 0x0000000181700B80-0x0000000181700C40
		public static bool CheckValidGaiaStampPath(Texture2D source); // 0x00000001816FE110-0x00000001816FE240
		public static void CreateGaiaAssetDirectories(); // 0x00000001803774A0-0x00000001803774B0
		public static T[] GetAtPath<T>(string path);
		public static void MakeTextureNormal(Texture2D texture); // 0x0000000181701DF0-0x0000000181701E50
		public static void MakeTextureReadable(Texture2D texture); // 0x0000000181701E50-0x0000000181701EB0
		public static void MakeTextureUncompressed(Texture2D texture); // 0x0000000181701EB0-0x0000000181701F10
		public static void CompressToSingleChannelFileImage(float[,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00778F5F */, bool exportPNG = true /* Metadata: 0x00778F63 */, bool exportJPG = true /* Metadata: 0x00778F64 */); // 0x00000001816FEAE0-0x00000001816FED30
		public static void CompressToMultiChannelFileImage(float[,,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00778F65 */, bool exportPNG = true /* Metadata: 0x00778F69 */, bool exportJPG = true /* Metadata: 0x00778F6A */); // 0x00000001816FE750-0x00000001816FEAE0
		public static void CompressToMultiChannelFileImage(string imageName, HeightMap r, HeightMap g, HeightMap b, HeightMap a, TextureFormat imageStorageFormat, GaiaConstants.ImageFileType imageFileType); // 0x00000001816FE240-0x00000001816FE750
		public static float[,] ConvertTextureToArray(Texture2D texture); // 0x00000001816FED30-0x00000001816FEE90
		public static float[,] DecompressFromSingleChannelFileImage(string fileName, int width, int height, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00778F6B */, bool channelR = true /* Metadata: 0x00778F6F */, bool channelG = false /* Metadata: 0x00778F70 */, bool channelB = false /* Metadata: 0x00778F71 */, bool channelA = false /* Metadata: 0x00778F72 */); // 0x00000001816FF600-0x00000001816FF7B0
		public static float[,] DecompressFromSingleChannelTexture(Texture2D importTexture, bool channelR = true /* Metadata: 0x00778F73 */, bool channelG = false /* Metadata: 0x00778F74 */, bool channelB = false /* Metadata: 0x00778F75 */, bool channelA = false /* Metadata: 0x00778F76 */); // 0x00000001816FF7B0-0x00000001816FFB90
		public static void ExportJPG(string fileName, Texture2D texture); // 0x00000001816FFB90-0x00000001816FFC00
		public static void ExportPNG(string fileName, Texture2D texture); // 0x00000001816FFC00-0x00000001816FFC70
		public static float[,] LoadRawFile(string fileName); // 0x0000000181701AC0-0x0000000181701DF0
		public static Mesh CreateMesh(float[,] heightmap, Vector3 targetSize); // 0x00000001816FEE90-0x00000001816FF600
		public static Bounds GetBounds(GameObject go); // 0x00000001817004D0-0x0000000181700710
		private Vector3 Rotate90LeftXAxis(Vector3 input); // 0x0000000181702EB0-0x0000000181702F00
		private Vector3 Rotate90RightXAxis(Vector3 input); // 0x0000000181702FA0-0x0000000181702FF0
		private Vector3 Rotate90LeftYAxis(Vector3 input); // 0x0000000181702F00-0x0000000181702F50
		private Vector3 Rotate90RightYAxis(Vector3 input); // 0x0000000181702FF0-0x0000000181703040
		private Vector3 Rotate90LeftZAxis(Vector3 input); // 0x0000000181702F50-0x0000000181702FA0
		private Vector3 Rotate90RightZAxis(Vector3 input); // 0x0000000181703040-0x0000000181703090
		public static bool Math_ApproximatelyEqual(float a, float b, float threshold); // 0x00000001817020C0-0x0000000181702150
		public static bool Math_ApproximatelyEqual(float a, float b); // 0x0000000181702030-0x00000001817020C0
		public static bool Math_IsPowerOf2(int value); // 0x00000001817023E0-0x00000001817023F0
		public static float Math_Clamp(float min, float max, float value); // 0x0000000181702150-0x0000000181702170
		public static float Math_Modulo(float value, float mod); // 0x00000001817025B0-0x0000000181702630
		public static int Math_Modulo(int value, int mod); // 0x0000000181702470-0x0000000181702510
		public static float Math_InterpolateLinear(float value1, float value2, float fraction); // 0x0000000181702310-0x0000000181702330
		public static float Math_InterpolateSmooth(float value1, float value2, float fraction); // 0x0000000181702370-0x00000001817023E0
		public static float Math_Distance(float x1, float y1, float x2, float y2); // 0x0000000181702170-0x0000000181702210
		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction); // 0x0000000181702330-0x0000000181702370
		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction); // 0x00000001817022B0-0x0000000181702310
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle); // 0x0000000181703200-0x0000000181703370
		public static string FixFileName(string sourceFileName); // 0x00000001816FFD60-0x00000001816FFE50
		public static FileStream OpenRead(string path); // 0x0000000181702630-0x00000001817026A0
		public static string ReadAllText(string path); // 0x0000000181702B70-0x0000000181702D10
		public static void WriteAllText(string path, string contents); // 0x0000000181703670-0x0000000181703850
		public static byte[] ReadAllBytes(string path); // 0x0000000181702710-0x0000000181702940
		public static void WriteAllBytes(string path, byte[] bytes); // 0x0000000181703470-0x0000000181703570
		public static void CreateAsset<T>()
			where T : ScriptableObject;
		public static string GetAssetPath(UnityEngine.Object uo); // 0x00000001817004A0-0x00000001817004D0
		public static string WrapScriptableObject(ScriptableObject so); // 0x0000000181703440-0x0000000181703470
		public static void UnwrapScriptableObject(string path, string newpath); // 0x00000001803774A0-0x00000001803774B0
		public static string WrapGameObjectAsPrefab(GameObject go); // 0x0000000181703410-0x0000000181703440
		public static bool IsInLayerMask(GameObject obj, LayerMask mask); // 0x0000000181701460-0x00000001817014C0
		public static bool IsSameTexture(Texture2D tex1, Texture2D tex2, bool checkID = false /* Metadata: 0x00778F77 */); // 0x0000000181701910-0x0000000181701AC0
		public static bool IsSameGameObject(GameObject go1, GameObject go2, bool checkID = false /* Metadata: 0x00778F78 */); // 0x00000001817014C0-0x0000000181701610
		public static string GetAssetPath(string fileName); // 0x0000000181700470-0x00000001817004A0
		public static string GetAssetPath(string name, string type); // 0x0000000181700440-0x0000000181700470
		public static GaiaSettings GetGaiaSettings(); // 0x0000000181700A70-0x0000000181700AD0
		public static UnityEngine.Object GetAsset(string fileNameOrPath, Type assetType); // 0x000000018037DDC0-0x000000018037DDD0
		public static GameObject GetAssetPrefab(string name); // 0x000000018037DDC0-0x000000018037DDD0
		public static ScriptableObject GetAssetScriptableObject(string name); // 0x000000018037DDC0-0x000000018037DDD0
		public static Texture2D GetAssetTexture2D(string name); // 0x000000018037DDC0-0x000000018037DDD0
		public static Type GetType(string TypeName); // 0x0000000181700CC0-0x0000000181701090
	}
}
