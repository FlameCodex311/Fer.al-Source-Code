/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class Utils : UnityEngine.MonoBehaviour // TypeDefIndex: 9098
	{
		// Constructors
		public Utils(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		public static string GetGaiaAssetDirectory(); // 0x0000000181C0B700-0x0000000181C0B7C0
		public static string GetGaiaAssetDirectory(GaiaConstants.FeatureType featureType); // 0x0000000181C0B7C0-0x0000000181C0B8E0
		public static List<string> GetGaiaStampsList(GaiaConstants.FeatureType featureType); // 0x0000000181C0BB50-0x0000000181C0BBD0
		public static string GetGaiaAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x0000000181C0B8E0-0x0000000181C0B980
		public static string GetGaiaStampAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x0000000181C0B9E0-0x0000000181C0BA90
		public static string GetGaiaStampPath(Texture2D source); // 0x0000000181C0BA90-0x0000000181C0BB50
		public static bool CheckValidGaiaStampPath(Texture2D source); // 0x0000000181C08F50-0x0000000181C09090
		public static void CreateGaiaAssetDirectories(); // 0x00000001803581E0-0x00000001803581F0
		public static T[] GetAtPath<T>(string path);
		public static void MakeTextureNormal(Texture2D texture); // 0x0000000181C0CD50-0x0000000181C0CDB0
		public static void MakeTextureReadable(Texture2D texture); // 0x0000000181C0CDB0-0x0000000181C0CE10
		public static void MakeTextureUncompressed(Texture2D texture); // 0x0000000181C0CE10-0x0000000181C0CE70
		public static void CompressToSingleChannelFileImage(float[,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00744271 */, bool exportPNG = true /* Metadata: 0x00744275 */, bool exportJPG = true /* Metadata: 0x00744276 */); // 0x0000000181C09960-0x0000000181C09BB0
		public static void CompressToMultiChannelFileImage(float[,,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00744277 */, bool exportPNG = true /* Metadata: 0x0074427B */, bool exportJPG = true /* Metadata: 0x0074427C */); // 0x0000000181C095C0-0x0000000181C09960
		public static void CompressToMultiChannelFileImage(string imageName, HeightMap r, HeightMap g, HeightMap b, HeightMap a, TextureFormat imageStorageFormat, GaiaConstants.ImageFileType imageFileType); // 0x0000000181C09090-0x0000000181C095C0
		public static float[,] ConvertTextureToArray(Texture2D texture); // 0x0000000181C09BB0-0x0000000181C09D10
		public static float[,] DecompressFromSingleChannelFileImage(string fileName, int width, int height, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x0074427D */, bool channelR = true /* Metadata: 0x00744281 */, bool channelG = false /* Metadata: 0x00744282 */, bool channelB = false /* Metadata: 0x00744283 */, bool channelA = false /* Metadata: 0x00744284 */); // 0x0000000181C0A4B0-0x0000000181C0A670
		public static float[,] DecompressFromSingleChannelTexture(Texture2D importTexture, bool channelR = true /* Metadata: 0x00744285 */, bool channelG = false /* Metadata: 0x00744286 */, bool channelB = false /* Metadata: 0x00744287 */, bool channelA = false /* Metadata: 0x00744288 */); // 0x0000000181C0A670-0x0000000181C0AA60
		public static void ExportJPG(string fileName, Texture2D texture); // 0x0000000181C0AA60-0x0000000181C0AAD0
		public static void ExportPNG(string fileName, Texture2D texture); // 0x0000000181C0AAD0-0x0000000181C0AB40
		public static float[,] LoadRawFile(string fileName); // 0x0000000181C0CA10-0x0000000181C0CD50
		public static Mesh CreateMesh(float[,] heightmap, Vector3 targetSize); // 0x0000000181C09D10-0x0000000181C0A4B0
		public static Bounds GetBounds(GameObject go); // 0x0000000181C0B3D0-0x0000000181C0B620
		private Vector3 Rotate90LeftXAxis(Vector3 input); // 0x000000018159C130-0x000000018159C180
		private Vector3 Rotate90RightXAxis(Vector3 input); // 0x000000018159C220-0x000000018159C270
		private Vector3 Rotate90LeftYAxis(Vector3 input); // 0x000000018159C180-0x000000018159C1D0
		private Vector3 Rotate90RightYAxis(Vector3 input); // 0x000000018159C270-0x000000018159C2C0
		private Vector3 Rotate90LeftZAxis(Vector3 input); // 0x000000018159C1D0-0x000000018159C220
		private Vector3 Rotate90RightZAxis(Vector3 input); // 0x000000018159C2C0-0x000000018159C310
		public static bool Math_ApproximatelyEqual(float a, float b, float threshold); // 0x0000000181C0D020-0x0000000181C0D0B0
		public static bool Math_ApproximatelyEqual(float a, float b); // 0x0000000181C0CF90-0x0000000181C0D020
		public static bool Math_IsPowerOf2(int value); // 0x000000018159C000-0x000000018159C010
		public static float Math_Clamp(float min, float max, float value); // 0x000000018159BE10-0x000000018159BE30
		public static float Math_Modulo(float value, float mod); // 0x0000000181C0D3B0-0x0000000181C0D430
		public static int Math_Modulo(int value, int mod); // 0x0000000181C0D270-0x0000000181C0D310
		public static float Math_InterpolateLinear(float value1, float value2, float fraction); // 0x000000018159BF30-0x000000018159BF50
		public static float Math_InterpolateSmooth(float value1, float value2, float fraction); // 0x000000018159BF90-0x000000018159C000
		public static float Math_Distance(float x1, float y1, float x2, float y2); // 0x0000000181C0D0B0-0x0000000181C0D150
		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction); // 0x000000018159BF50-0x000000018159BF90
		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction); // 0x000000018159BED0-0x000000018159BF30
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle); // 0x0000000181C0DE40-0x0000000181C0DFB0
		public static string FixFileName(string sourceFileName); // 0x0000000181C0AC30-0x0000000181C0AD20
		public static FileStream OpenRead(string path); // 0x0000000181C0D430-0x0000000181C0D4A0
		public static string ReadAllText(string path); // 0x0000000181C0D990-0x0000000181C0DB30
		public static void WriteAllText(string path, string contents); // 0x0000000181C0E2B0-0x0000000181C0E4A0
		public static byte[] ReadAllBytes(string path); // 0x0000000181C0D510-0x0000000181C0D750
		public static void WriteAllBytes(string path, byte[] bytes); // 0x0000000181C0E0B0-0x0000000181C0E1B0
		public static void CreateAsset<T>()
			where T : ScriptableObject;
		public static string GetAssetPath(UnityEngine.Object uo); // 0x0000000181C0B3A0-0x0000000181C0B3D0
		public static string WrapScriptableObject(ScriptableObject so); // 0x0000000181C0E080-0x0000000181C0E0B0
		public static void UnwrapScriptableObject(string path, string newpath); // 0x00000001803581E0-0x00000001803581F0
		public static string WrapGameObjectAsPrefab(GameObject go); // 0x0000000181C0E050-0x0000000181C0E080
		public static bool IsInLayerMask(GameObject obj, LayerMask mask); // 0x0000000181C0C390-0x0000000181C0C3F0
		public static bool IsSameTexture(Texture2D tex1, Texture2D tex2, bool checkID = false /* Metadata: 0x00744289 */); // 0x0000000181C0C850-0x0000000181C0CA10
		public static bool IsSameGameObject(GameObject go1, GameObject go2, bool checkID = false /* Metadata: 0x0074428A */); // 0x0000000181C0C3F0-0x0000000181C0C540
		public static string GetAssetPath(string fileName); // 0x0000000181C0B370-0x0000000181C0B3A0
		public static string GetAssetPath(string name, string type); // 0x0000000181C0B340-0x0000000181C0B370
		public static GaiaSettings GetGaiaSettings(); // 0x0000000181C0B980-0x0000000181C0B9E0
		public static UnityEngine.Object GetAsset(string fileNameOrPath, Type assetType); // 0x000000018035FCC0-0x000000018035FCD0
		public static GameObject GetAssetPrefab(string name); // 0x000000018035FCC0-0x000000018035FCD0
		public static ScriptableObject GetAssetScriptableObject(string name); // 0x000000018035FCC0-0x000000018035FCD0
		public static Texture2D GetAssetTexture2D(string name); // 0x000000018035FCC0-0x000000018035FCD0
		public static Type GetType(string TypeName); // 0x0000000181C0BBD0-0x0000000181C0BFB0
	}
}
