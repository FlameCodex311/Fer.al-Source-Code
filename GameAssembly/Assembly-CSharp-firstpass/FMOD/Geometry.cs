/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct Geometry // TypeDefIndex: 9669
	{
		// Fields
		public IntPtr handle; // 0x00
	
		// Methods
		public RESULT release(); // 0x0000000180315EF0-0x0000000180315F90
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex); // 0x00000001803155F0-0x0000000180315700
		public RESULT getNumPolygons(out int numpolygons); // 0x00000001803158C0-0x0000000180315970
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices); // 0x0000000180315800-0x00000001803158C0
		public RESULT getPolygonNumVertices(int index, out int numvertices); // 0x0000000180315A60-0x0000000180315B20
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex); // 0x00000001803161E0-0x00000001803162A0
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex); // 0x0000000180315B20-0x0000000180315BE0
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided); // 0x0000000180316100-0x00000001803161E0
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided); // 0x0000000180315970-0x0000000180315A60
		public RESULT setActive(bool active); // 0x0000000180316050-0x0000000180316100
		public RESULT getActive(out bool active); // 0x0000000180315740-0x0000000180315800
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up); // 0x0000000180316350-0x0000000180316410
		public RESULT getRotation(out VECTOR forward, out VECTOR up); // 0x0000000180315C90-0x0000000180315D50
		public RESULT setPosition(ref VECTOR position); // 0x00000001803162A0-0x0000000180316350
		public RESULT getPosition(out VECTOR position); // 0x0000000180315BE0-0x0000000180315C90
		public RESULT setScale(ref VECTOR scale); // 0x0000000180316410-0x00000001803164C0
		public RESULT getScale(out VECTOR scale); // 0x0000000180315D50-0x0000000180315E00
		public RESULT save(IntPtr data, out int datasize); // 0x0000000180315F90-0x0000000180316050
		public RESULT setUserData(IntPtr userdata); // 0x00000001803164C0-0x0000000180316570
		public RESULT getUserData(out IntPtr userdata); // 0x0000000180315E00-0x0000000180315EB0
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry); // 0x0000000181EF2750-0x0000000181EF27F0
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex); // 0x0000000181EF1EE0-0x0000000181EF1FF0
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons); // 0x0000000181EF2170-0x0000000181EF2220
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices); // 0x0000000181EF20B0-0x0000000181EF2170
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices); // 0x0000000181EF2310-0x0000000181EF23C0
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex); // 0x0000000181EF2A40-0x0000000181EF2B00
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex); // 0x0000000181EF23C0-0x0000000181EF2480
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided); // 0x0000000181EF2960-0x0000000181EF2A40
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided); // 0x0000000181EF2220-0x0000000181EF2310
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active); // 0x0000000181EF28B0-0x0000000181EF2960
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active); // 0x0000000181EF1FF0-0x0000000181EF20B0
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up); // 0x0000000181EF2BB0-0x0000000181EF2C70
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up); // 0x0000000181EF2530-0x0000000181EF25F0
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position); // 0x0000000181EF2B00-0x0000000181EF2BB0
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position); // 0x0000000181EF2480-0x0000000181EF2530
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale); // 0x0000000181EF2C70-0x0000000181EF2D20
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale); // 0x0000000181EF25F0-0x0000000181EF26A0
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize); // 0x0000000181EF27F0-0x0000000181EF28B0
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata); // 0x0000000181EF2D20-0x0000000181EF2DD0
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata); // 0x0000000181EF26A0-0x0000000181EF2750
		public bool hasHandle(); // 0x0000000180315EB0-0x0000000180315EF0
		public void clearHandle(); // 0x0000000180315700-0x0000000180315740
	}
}
