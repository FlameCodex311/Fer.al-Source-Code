/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct Geometry // TypeDefIndex: 10123
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x000000018011AC90-0x000000018011AD10
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex); // 0x000000018011A4E0-0x000000018011A5D0
		public RESULT getNumPolygons(out int numpolygons); // 0x000000018011A750-0x000000018011A7E0
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices); // 0x000000018011A6B0-0x000000018011A750
		public RESULT getPolygonNumVertices(int index, out int numvertices); // 0x000000018011A8B0-0x000000018011A950
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex); // 0x000000018011AF00-0x000000018011AFB0
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex); // 0x000000018011A950-0x000000018011AA00
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided); // 0x000000018011AE40-0x000000018011AF00
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided); // 0x000000018011A7E0-0x000000018011A8B0
		public RESULT setActive(bool active); // 0x000000018011ADB0-0x000000018011AE40
		public RESULT getActive(out bool active); // 0x000000018011A610-0x000000018011A6B0
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up); // 0x000000018011B040-0x000000018011B0E0
		public RESULT getRotation(out VECTOR forward, out VECTOR up); // 0x000000018011AA90-0x000000018011AB30
		public RESULT setPosition(ref VECTOR position); // 0x000000018011AFB0-0x000000018011B040
		public RESULT getPosition(out VECTOR position); // 0x000000018011AA00-0x000000018011AA90
		public RESULT setScale(ref VECTOR scale); // 0x000000018011B0E0-0x000000018011B170
		public RESULT getScale(out VECTOR scale); // 0x000000018011AB30-0x000000018011ABC0
		public RESULT save(IntPtr data, out int datasize); // 0x000000018011AD10-0x000000018011ADB0
		public RESULT setUserData(IntPtr userdata); // 0x000000018011B170-0x000000018011B200
		public RESULT getUserData(out IntPtr userdata); // 0x000000018011ABC0-0x000000018011AC50
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry); // 0x0000000181B9F9B0-0x0000000181B9FA30
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex); // 0x0000000181B9F290-0x0000000181B9F380
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons); // 0x0000000181B9F4C0-0x0000000181B9F550
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices); // 0x0000000181B9F420-0x0000000181B9F4C0
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices); // 0x0000000181B9F620-0x0000000181B9F6C0
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex); // 0x0000000181B9FC20-0x0000000181B9FCC0
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex); // 0x0000000181B9F6C0-0x0000000181B9F760
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided); // 0x0000000181B9FB60-0x0000000181B9FC20
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided); // 0x0000000181B9F550-0x0000000181B9F620
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active); // 0x0000000181B9FAD0-0x0000000181B9FB60
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active); // 0x0000000181B9F380-0x0000000181B9F420
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up); // 0x0000000181B9FD50-0x0000000181B9FDF0
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up); // 0x0000000181B9F7F0-0x0000000181B9F890
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position); // 0x0000000181B9FCC0-0x0000000181B9FD50
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position); // 0x0000000181B9F760-0x0000000181B9F7F0
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale); // 0x0000000181B9FDF0-0x0000000181B9FE80
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale); // 0x0000000181B9F890-0x0000000181B9F920
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize); // 0x0000000181B9FA30-0x0000000181B9FAD0
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata); // 0x0000000181B9FE80-0x0000000181B9FF10
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata); // 0x0000000181B9F920-0x0000000181B9F9B0
		public bool hasHandle(); // 0x000000018011AC50-0x000000018011AC90
		public void clearHandle(); // 0x000000018011A5D0-0x000000018011A610
	}
}
