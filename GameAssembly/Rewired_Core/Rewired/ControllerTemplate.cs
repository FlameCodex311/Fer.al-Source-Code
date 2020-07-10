/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public abstract class ControllerTemplate : IControllerTemplate // TypeDefIndex: 5932
	{
		// Fields
		private readonly string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x10
		private readonly Guid fBpYGJSbJtEYFnuyeCxcBFLcFejM; // 0x18
		private readonly Controller VFyAcBdeMMCAMfDOgPwemixrJuYM; // 0x28
		private readonly ADictionary<int, IControllerTemplateElement> qKaEkYzcrEvcwLNOaSobtDoPDvt; // 0x30
		private readonly ADictionary<string, IControllerTemplateElement> QNFfBjCDNzgKSHOdXuarceOAPPW; // 0x38
		private IControllerTemplateElement[] OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0x40
		private ReadOnlyCollection<IControllerTemplateElement> kaRwVFuEhQdielEoQKhHRABCAZN; // 0x48
		private readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x50
	
		// Properties
		Controller IControllerTemplate.controller { get; } // 0x0000000180A8D770-0x0000000180A8D840 
		string IControllerTemplate.name { get; } // 0x0000000180A8D990-0x0000000180A8DA30 
		Guid IControllerTemplate.typeGuid { get; } // 0x0000000180A8DA30-0x0000000180A8DB10 
		IList<IControllerTemplateElement> IControllerTemplate.elements { get; } // 0x0000000180A8D8F0-0x0000000180A8D990 
		int IControllerTemplate.elementCount { get; } // 0x0000000180A8D840-0x0000000180A8D8F0 
	
		// Nested types
		internal abstract class GhREpLFgCYFrjIBVIYiOgCvfqHg : IControllerTemplateElement, IControllerTemplateElement_Internal // TypeDefIndex: 5933
		{
			// Fields
			private readonly IControllerTemplate PdhGYsFKOBEfRexHgTcxFTVoRup; // 0x10
			private readonly int jotfbgeLQZTIFstijorJbghJlvHQ; // 0x18
			private readonly string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x20
			private readonly ControllerTemplateElementType qYQtZXCUUQiyGpzdDXLOHBOwcPe; // 0x28
			protected readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x2C
	
			// Properties
			public int nowyFwjWnwrGQsPrcpSlPNkfVZu { get; } // 0x0000000180A993B0-0x0000000180A99450 
			public string sOeddyDbBHwonMuiGWkqixyPkvu { get; } // 0x0000000180A99310-0x0000000180A993B0 
			public ControllerTemplateElementType JmvHHQieRmxAYahCfvzgQBWHgSne { get; } // 0x0000000180A99450-0x0000000180A994F0 
			public IControllerTemplate GsoDNwSmTlqXUxYxRnLUXMOoArhh { get; } // 0x000000018036AC80-0x000000018036AC90 
			public abstract int mqnUPxNtcFFogFDLlSnptdcvqQI { get; }
			public abstract IControllerTemplateElementSource EWvxEcokoAEStdCudJqOMgkHwwyD { get; }
			public abstract bool ewKnBoQtyaAQMQWdtvMPKLvKkoW { get; }
	
			// Constructors
			protected GhREpLFgCYFrjIBVIYiOgCvfqHg(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType); // 0x0000000180A991E0-0x0000000180A99310
	
			// Methods
			public abstract IControllerTemplateElement GetElement(int param_0000caf4);
			public abstract int GetElementTargets(ControllerElementTarget param_0000caf5, ref IList<ControllerTemplateElementTarget> param_0000caf6);
		}
	
		internal abstract class KBYdzGRBzlXhtbUXRkUUOyEYMKl : GhREpLFgCYFrjIBVIYiOgCvfqHg // TypeDefIndex: 5934
		{
			// Fields
			protected readonly int ZXIUOoKfSNEvXAgqaKQAqjTqFkd; // 0x30
			protected readonly bZJyKtoDpKBrniWesjOeCJlrijn[] XVNhDzzLptFZxGvnmMhUfZhmxtsX; // 0x38
	
			// Properties
			public override bool ewKnBoQtyaAQMQWdtvMPKLvKkoW { get; } // 0x0000000180A9AFA0-0x0000000180A9B0E0 
	
			// Constructors
			protected KBYdzGRBzlXhtbUXRkUUOyEYMKl(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x0000000180A9AEE0-0x0000000180A9AFA0
		}
	
		internal abstract class KMCVBWMPRfCCvsWXeOWVAVbJlSL : KBYdzGRBzlXhtbUXRkUUOyEYMKl, IControllerTemplateAxis, IControllerTemplateButton // TypeDefIndex: 5935
		{
			// Fields
			private oDhSVhqolYnpfNXmoDZvnEklacS dNWBSoAyVwPHsvQTGMAsQMzzdxU; // 0x40
			private string BFiybaexsfDqYszLAhDqXHlJPRJ; // 0x48
			private string RfeHNKNVEmyfJOcCPQKJQeeVWcE; // 0x50
	
			// Properties
			public float SmusaJYEiWkzlQwwWeWgpvQUdTv { get; } // 0x0000000180A9CE00-0x0000000180A9D000 
			public float KWEArpYLlLDDbadXGBrjBxHaMRC { get; } // 0x0000000180A9CBF0-0x0000000180A9CE00 
			public bool GHUeJCzFrDgzBXDTzvzXRREPKiu { get; } // 0x0000000180A9CA40-0x0000000180A9CBF0 
			public bool CYoiuSaiDOhzEDDwIKdSkbMwjSa { get; } // 0x0000000180A9C8A0-0x0000000180A9CA40 
			string EreKZFjHcgkRyTstdLHiLeioxNL { get; } // 0x0000000180A9B820-0x0000000180A9B8C0 
			string YTvZzbNUUzHSEQKezlGntgMdjxI { get; } // 0x0000000180A9B780-0x0000000180A9B820 
			float pyAHKferViMNbconiASqZIHgkDP { get; } // 0x0000000180A9BA40-0x0000000180A9BAF0 
			float vzknhlTmXKDPehKVvHJlFscBGpj { get; } // 0x0000000180A9B990-0x0000000180A9BA40 
			IControllerTemplateAxisSource MvaWGMDxzWCuFdNDIhjOHDATUQr { get; } // 0x0000000180A9B8C0-0x0000000180A9B990 
			bool yhYHNxwamVZMPxRgAQqCaDCsItg { get; } // 0x0000000180A9C3F0-0x0000000180A9C4C0 
			bool sGZWnrbtnKXyKhbLZDDToXdcBgr { get; } // 0x0000000180A9C350-0x0000000180A9C3F0 
			bool zzAzTAETPPVvtCOxkDipKjnvhBI { get; } // 0x0000000180A9BBB0-0x0000000180A9BE70 
			bool VYoYmPgzeoKWGyXVclmnmJsEmVZ { get; } // 0x0000000180A9BE70-0x0000000180A9C150 
			bool XZUpRFXoiMCEykRvUOnYOWRbfcv { get; } // 0x0000000180A9BAF0-0x0000000180A9BBB0 
			float ZnWqLUxYZNoKrbOakICMDgiRDQm { get; } // 0x0000000180A9C200-0x0000000180A9C2B0 
			float LGxyjtXFbvAmYIqrroeMLNEMvPq { get; } // 0x0000000180A9C150-0x0000000180A9C200 
			IControllerTemplateButtonSource RtVnWuNxPsSKjbmwlYoCwAVvZsd { get; } // 0x0000000180A9C2B0-0x0000000180A9C350 
			public override IControllerTemplateElementSource EWvxEcokoAEStdCudJqOMgkHwwyD { get; } // 0x0000000180A9D000-0x0000000180A9D0A0 
			public override int mqnUPxNtcFFogFDLlSnptdcvqQI { get; } // 0x000000018035FCC0-0x000000018035FCD0 
			public IControllerTemplateAxis AFkHcsMZfyqAhwdMMqDsbUdNedP { get; } // 0x0000000180A9C760-0x0000000180A9C800 
			public IControllerTemplateButton cyiCdIGXOEOueUEQbonWfmhOpBmZ { get; } // 0x0000000180A9C800-0x0000000180A9C8A0 
	
			// Constructors
			protected KMCVBWMPRfCCvsWXeOWVAVbJlSL(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, oDhSVhqolYnpfNXmoDZvnEklacS target, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x0000000180A9C4C0-0x0000000180A9C640
	
			// Methods
			string IControllerTemplateAxis.GetDescriptiveName(AxisRange param_0000cb04); // 0x0000000180A9B5F0-0x0000000180A9B780
			public override IControllerTemplateElement GetElement(int param_0000cb05); // 0x000000018035FCC0-0x000000018035FCD0
			public override int GetElementTargets(ControllerElementTarget param_0000cb06, ref IList<ControllerTemplateElementTarget> param_0000cb07); // 0x0000000180A9B0E0-0x0000000180A9B5F0
			private static bool cDpEVdjnzvpcJhElJvglrKqBtWC(ControllerElementTarget param_0000cb08, IControllerElementTarget param_0000cb09); // 0x0000000180A9C640-0x0000000180A9C760
		}
	
		internal sealed class nNYFTddguJmElItENvBEjAjSLTE : KMCVBWMPRfCCvsWXeOWVAVbJlSL // TypeDefIndex: 5936
		{
			// Constructors
			public nNYFTddguJmElItENvBEjAjSLTE(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, oDhSVhqolYnpfNXmoDZvnEklacS target, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x0000000180AA1CB0-0x0000000180AA1E90
	
			// Methods
			internal static nNYFTddguJmElItENvBEjAjSLTE EMrPyzqGuVTmURWytVHqWrdHoDK(IControllerTemplate param_0000cb11); // 0x0000000180AA1B60-0x0000000180AA1CB0
		}
	
		internal sealed class ElgBEiBoHPzlobPMCMNsKMpHpuXh : KMCVBWMPRfCCvsWXeOWVAVbJlSL // TypeDefIndex: 5937
		{
			// Constructors
			public ElgBEiBoHPzlobPMCMNsKMpHpuXh(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, oDhSVhqolYnpfNXmoDZvnEklacS target, IList<bZJyKtoDpKBrniWesjOeCJlrijn> sourceElements); // 0x0000000180A98FF0-0x0000000180A991E0
	
			// Methods
			internal static ElgBEiBoHPzlobPMCMNsKMpHpuXh EMrPyzqGuVTmURWytVHqWrdHoDK(IControllerTemplate param_0000cb19); // 0x0000000180A98EA0-0x0000000180A98FF0
		}
	
		internal abstract class guxazzOWayClFBASgkpzgjDfiZp : GhREpLFgCYFrjIBVIYiOgCvfqHg // TypeDefIndex: 5938
		{
			// Fields
			protected readonly int YTYDwGdmGpEbFaMPNISAGnnqKPXP; // 0x30
			protected readonly GhREpLFgCYFrjIBVIYiOgCvfqHg[] OuMXbYHQWjhHUDiQLPmgBAWEshm; // 0x38
	
			// Properties
			public override bool ewKnBoQtyaAQMQWdtvMPKLvKkoW { get; } // 0x0000000180A9F660-0x0000000180A9F790 
			public override IControllerTemplateElementSource EWvxEcokoAEStdCudJqOMgkHwwyD { get; } // 0x0000000180A9F790-0x0000000180A9F820 
			public override int mqnUPxNtcFFogFDLlSnptdcvqQI { get; } // 0x000000018043DDC0-0x000000018043DDD0 
	
			// Constructors
			protected guxazzOWayClFBASgkpzgjDfiZp(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A9F4F0-0x0000000180A9F660
	
			// Methods
			public override IControllerTemplateElement GetElement(int param_0000cb1f); // 0x0000000180A9F4B0-0x0000000180A9F4F0
			public override int GetElementTargets(ControllerElementTarget param_0000cb20, ref IList<ControllerTemplateElementTarget> param_0000cb21); // 0x0000000180A9F3B0-0x0000000180A9F4B0
		}
	
		internal abstract class IcRKTtNeZRRArveGoktgEdYanpJ : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateAxis2D // TypeDefIndex: 5939
		{
			// Fields
			protected const int wjpgCBMxcJpstDTqIbiSGKQLnjg = 0; // Metadata: 0x0072F6B0
			protected const int LEaUruLkKoduqbnMNbAekYUtYAI = 1; // Metadata: 0x0072F6B4
			protected const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 2; // Metadata: 0x0072F6B8
	
			// Properties
			public Vector2 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000180A998E0-0x0000000180A99BB0 
			public Vector2 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x0000000180A995F0-0x0000000180A998E0 
			public IControllerTemplateAxis nNNSsjDADTeOSDOfDqdrXrZdKQd { get; } // 0x0000000180A99500-0x0000000180A995F0 
			public IControllerTemplateAxis AqQpbMYqbiUnnuilmhdyOXFOFoI { get; } // 0x0000000180A99BB0-0x0000000180A99CA0 
	
			// Constructors
			protected IcRKTtNeZRRArveGoktgEdYanpJ(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A994F0-0x0000000180A99500
		}
	
		internal abstract class UZRIRmnTHtHUrIhzebhIbGDzHICR : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateAxis3D // TypeDefIndex: 5940
		{
			// Fields
			protected const int wjpgCBMxcJpstDTqIbiSGKQLnjg = 0; // Metadata: 0x0072F6BC
			protected const int LEaUruLkKoduqbnMNbAekYUtYAI = 1; // Metadata: 0x0072F6C0
			protected const int HzPzlSnkOTErRgiqIdefuovowIKo = 2; // Metadata: 0x0072F6C4
			protected const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 3; // Metadata: 0x0072F6C8
	
			// Properties
			public Vector3 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000180A9E150-0x0000000180A9E570 
			public Vector3 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x0000000180A9DD30-0x0000000180A9E150 
			public IControllerTemplateAxis nNNSsjDADTeOSDOfDqdrXrZdKQd { get; } // 0x0000000180A9DC40-0x0000000180A9DD30 
			public IControllerTemplateAxis AqQpbMYqbiUnnuilmhdyOXFOFoI { get; } // 0x0000000180A9E570-0x0000000180A9E660 
			public IControllerTemplateAxis dUFMdsYfQzbWedBwqfhpwhYgpAzi { get; } // 0x0000000180A9DB50-0x0000000180A9DC40 
	
			// Constructors
			protected UZRIRmnTHtHUrIhzebhIbGDzHICR(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A994F0-0x0000000180A99500
		}
	
		internal abstract class uTxUfgOiQNURvPChXIypCPYRBYQ : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateAxis6D // TypeDefIndex: 5941
		{
			// Fields
			protected const int SFZCtsAMycUHzjXFnViABeQcdtO = 0; // Metadata: 0x0072F6CC
			protected const int BzGxkcndVIvGGGTJLfuhCOnJrkI = 1; // Metadata: 0x0072F6D0
			protected const int gbqrQktAQHcbYftAHpbLUsSCpUe = 2; // Metadata: 0x0072F6D4
			protected const int BMeeqBBXKmlJmHtrWkGOlIzOQyMC = 3; // Metadata: 0x0072F6D8
			protected const int kHPXXfKCcBMeFBnmWVpmyOpXaCT = 4; // Metadata: 0x0072F6DC
			protected const int mmwGMcpOPhvATumMEVJDoSyEDcU = 5; // Metadata: 0x0072F6E0
			protected const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 6; // Metadata: 0x0072F6E4
	
			// Properties
			public Vector3 zNPvFpvqeBhBWvhYDxPITBksqbH { get; } // 0x0000000180AA2980-0x0000000180AA2D80 
			public Vector3 qddefUiuEoaNXXKsMDqwbYwrzRfG { get; } // 0x0000000180AA22B0-0x0000000180AA26B0 
			public Vector3 XyRcbqECbieglNQLRYEsCcrvxJbo { get; } // 0x0000000180AA3480-0x0000000180AA3880 
			public Vector3 hYZaPcgZBKwaeSjRBRwbGtlxJNOe { get; } // 0x0000000180AA2D80-0x0000000180AA3180 
			public IControllerTemplateAxis HduhRkWIJFXWvufnWQeHYKxuCkMg { get; } // 0x0000000180AA26B0-0x0000000180AA27A0 
			public IControllerTemplateAxis LmvrlYbVIxpSdCUheWpnYMVnEzk { get; } // 0x0000000180AA27A0-0x0000000180AA2890 
			public IControllerTemplateAxis lTECiqLpbMVWKuVfQrvMvPJjswo { get; } // 0x0000000180AA2890-0x0000000180AA2980 
			public IControllerTemplateAxis ajojxpUnLKsoGgMfHlsCIqtSodi { get; } // 0x0000000180AA3180-0x0000000180AA3270 
			public IControllerTemplateAxis UXzFvxRVWbfflnyXIDxucTsOdtB { get; } // 0x0000000180AA3270-0x0000000180AA3360 
			public IControllerTemplateAxis DtOFdpLYpHdCCfRBXLrrFpgJzZF { get; } // 0x0000000180AA3360-0x0000000180AA3480 
	
			// Constructors
			protected uTxUfgOiQNURvPChXIypCPYRBYQ(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A994F0-0x0000000180A99500
		}
	
		internal sealed class kIbPlwMGfbOBbkmYvurjruhOmgR : UZRIRmnTHtHUrIhzebhIbGDzHICR, IControllerTemplateStick // TypeDefIndex: 5942
		{
			// Fields
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 3; // Metadata: 0x0072F6E8
	
			// Properties
			public IControllerTemplateAxis XyRcbqECbieglNQLRYEsCcrvxJbo { get; } // 0x0000000180A9FB50-0x0000000180A9FC40 
	
			// Constructors
			private kIbPlwMGfbOBbkmYvurjruhOmgR(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A9F820-0x0000000180A9F910
			public kIbPlwMGfbOBbkmYvurjruhOmgR(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL xAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL yAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL zAxis); // 0x0000000180A9F910-0x0000000180A9FB50
		}
	
		internal sealed class tuEOTEuKqAbwXRrEKMPsqEWNnby : IcRKTtNeZRRArveGoktgEdYanpJ, IControllerTemplateThumbStick // TypeDefIndex: 5943
		{
			// Fields
			private const int mgGqDxRyHlKHppIisbewmsWFzsP = 2; // Metadata: 0x0072F6EC
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 3; // Metadata: 0x0072F6F0
	
			// Properties
			public IControllerTemplateButton EaqkEcDlmDHXCMtKLBziapwyeHfT { get; } // 0x0000000180AA21C0-0x0000000180AA22B0 
	
			// Constructors
			private tuEOTEuKqAbwXRrEKMPsqEWNnby(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180AA1E90-0x0000000180AA1F80
			internal tuEOTEuKqAbwXRrEKMPsqEWNnby(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL xAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL yAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL button); // 0x0000000180AA1F80-0x0000000180AA21C0
		}
	
		internal sealed class JbjMDsVrQPuqNDEfubxyjWhcTmK : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateDPad // TypeDefIndex: 5944
		{
			// Fields
			private const int oQAkzCgPCxSxFqAUikDOBsZXDDC = 0; // Metadata: 0x0072F6F4
			private const int ngODNUGGiQbrNRepKZmYoGFvrOfe = 1; // Metadata: 0x0072F6F8
			private const int NCCxowypuDdKUoISYuIYFySIIrM = 2; // Metadata: 0x0072F6FC
			private const int bKqrIDxzqDabOatIKEGgvpxQhvq = 3; // Metadata: 0x0072F700
			private const int XVFVTYpXETLPCwPhRlaRQXjEbog = 4; // Metadata: 0x0072F704
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 5; // Metadata: 0x0072F708
	
			// Properties
			public Vector2 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000180A9AA20-0x0000000180A9AEE0 
			public Vector2 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x0000000180A9A560-0x0000000180A9AA20 
			public IControllerTemplateButton xHwVJEHIDBSbHTHmPinLpFIiclL { get; } // 0x0000000180A9A470-0x0000000180A9A560 
			public IControllerTemplateButton fifGhyxBhATzweykVeGAHsleBaB { get; } // 0x0000000180A9A380-0x0000000180A9A470 
			public IControllerTemplateButton yYgJokxONevQcKPvgIDhkGmQmLq { get; } // 0x0000000180A9A080-0x0000000180A9A1A0 
			public IControllerTemplateButton ufmkrvcpjxzyDasVMJazgfPUhDQ { get; } // 0x0000000180A9A1A0-0x0000000180A9A290 
			public IControllerTemplateButton EaqkEcDlmDHXCMtKLBziapwyeHfT { get; } // 0x0000000180A9A290-0x0000000180A9A380 
	
			// Constructors
			private JbjMDsVrQPuqNDEfubxyjWhcTmK(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A99CA0-0x0000000180A99D90
			internal JbjMDsVrQPuqNDEfubxyjWhcTmK(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL up, KMCVBWMPRfCCvsWXeOWVAVbJlSL right, KMCVBWMPRfCCvsWXeOWVAVbJlSL down, KMCVBWMPRfCCvsWXeOWVAVbJlSL left, KMCVBWMPRfCCvsWXeOWVAVbJlSL press); // 0x0000000180A99D90-0x0000000180A9A080
		}
	
		internal sealed class KbXlRnQSZDpXZpZgQwLeyXBeGmE : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateThrottle // TypeDefIndex: 5945
		{
			// Fields
			private const int TQcBXDWWsFbZEbRXiMvycPggfYkE = 0; // Metadata: 0x0072F70C
			private const int IjRoGrMZkVmeopVUuulBDlIcbma = 1; // Metadata: 0x0072F710
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 2; // Metadata: 0x0072F714
	
			// Properties
			public float PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000180A9D6D0-0x0000000180A9D850 
			public float HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x0000000180A9D550-0x0000000180A9D6D0 
			public IControllerTemplateAxis bsyLbuoRqktxCMFfmDZFuEoECMu { get; } // 0x0000000180A9D460-0x0000000180A9D550 
			public IControllerTemplateButton SeZvGVwmgsgxNNMiPJzdWYzPCOy { get; } // 0x0000000180A9D370-0x0000000180A9D460 
	
			// Constructors
			private KbXlRnQSZDpXZpZgQwLeyXBeGmE(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A9D280-0x0000000180A9D370
			internal KbXlRnQSZDpXZpZgQwLeyXBeGmE(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL axis, KMCVBWMPRfCCvsWXeOWVAVbJlSL zeroDetentButton); // 0x0000000180A9D0A0-0x0000000180A9D280
		}
	
		internal sealed class lIlDBtDlZdpUYCYSRagDwCVnKCqg : guxazzOWayClFBASgkpzgjDfiZp, IControllerTemplateHat // TypeDefIndex: 5946
		{
			// Fields
			private const int oQAkzCgPCxSxFqAUikDOBsZXDDC = 0; // Metadata: 0x0072F718
			private const int GgeLGtcpDJxgymIKeJNChTzRLTF = 1; // Metadata: 0x0072F71C
			private const int ngODNUGGiQbrNRepKZmYoGFvrOfe = 2; // Metadata: 0x0072F720
			private const int njcuvGlicVIivJOQJEonHNUjQtA = 3; // Metadata: 0x0072F724
			private const int NCCxowypuDdKUoISYuIYFySIIrM = 4; // Metadata: 0x0072F728
			private const int dLyqxUvhDfbbpjLJAujnVnbuFJU = 5; // Metadata: 0x0072F72C
			private const int bKqrIDxzqDabOatIKEGgvpxQhvq = 6; // Metadata: 0x0072F730
			private const int MCFRDurIvwNucOSkAiZBWByEeLS = 7; // Metadata: 0x0072F734
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 8; // Metadata: 0x0072F738
	
			// Properties
			public Vector2 PLdosENimxvPBjeGrIWuaBaRuLxb { get; } // 0x0000000180AA11B0-0x0000000180AA1B60 
			public Vector2 HktmpbSPOVYjrGTtMaPwVasCJTI { get; } // 0x0000000180AA08A0-0x0000000180AA11B0 
			public IControllerTemplateButton xHwVJEHIDBSbHTHmPinLpFIiclL { get; } // 0x0000000180AA07B0-0x0000000180AA08A0 
			public IControllerTemplateButton QjnVkYbIXqqYWfVOkQntsRhOMuK { get; } // 0x0000000180AA06C0-0x0000000180AA07B0 
			public IControllerTemplateButton fifGhyxBhATzweykVeGAHsleBaB { get; } // 0x0000000180AA04E0-0x0000000180AA05D0 
			public IControllerTemplateButton tgKdExIJOdHAIbvUktuLBnEbKKnx { get; } // 0x0000000180AA0210-0x0000000180AA0300 
			public IControllerTemplateButton yYgJokxONevQcKPvgIDhkGmQmLq { get; } // 0x0000000180AA0300-0x0000000180AA03F0 
			public IControllerTemplateButton lzCsXgdurJQpwFcuhrVBSCGYlKR { get; } // 0x0000000180AA0120-0x0000000180AA0210 
			public IControllerTemplateButton ufmkrvcpjxzyDasVMJazgfPUhDQ { get; } // 0x0000000180AA03F0-0x0000000180AA04E0 
			public IControllerTemplateButton KJyLenHXIufKybmHkFtqZmaPUhM { get; } // 0x0000000180AA05D0-0x0000000180AA06C0 
	
			// Constructors
			private lIlDBtDlZdpUYCYSRagDwCVnKCqg(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180AA0030-0x0000000180AA0120
			internal lIlDBtDlZdpUYCYSRagDwCVnKCqg(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL up, KMCVBWMPRfCCvsWXeOWVAVbJlSL upRight, KMCVBWMPRfCCvsWXeOWVAVbJlSL right, KMCVBWMPRfCCvsWXeOWVAVbJlSL downRight, KMCVBWMPRfCCvsWXeOWVAVbJlSL down, KMCVBWMPRfCCvsWXeOWVAVbJlSL downLeft, KMCVBWMPRfCCvsWXeOWVAVbJlSL left, KMCVBWMPRfCCvsWXeOWVAVbJlSL upLeft); // 0x0000000180A9FC40-0x0000000180AA0030
		}
	
		internal sealed class fQsKtIrYykFeZweCocXLkUMvVIH : IcRKTtNeZRRArveGoktgEdYanpJ, IControllerTemplateYoke // TypeDefIndex: 5947
		{
			// Fields
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 2; // Metadata: 0x0072F73C
	
			// Properties
			public IControllerTemplateAxis XyRcbqECbieglNQLRYEsCcrvxJbo { get; } // 0x0000000180A9F2C0-0x0000000180A9F3B0 
			public IControllerTemplateAxis dyfjcATmSTnkAhTwisTPIgdzYqh { get; } // 0x0000000180A9F1D0-0x0000000180A9F2C0 
	
			// Constructors
			private fQsKtIrYykFeZweCocXLkUMvVIH(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A9F040-0x0000000180A9F070
			internal fQsKtIrYykFeZweCocXLkUMvVIH(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL rollAxis, KMCVBWMPRfCCvsWXeOWVAVbJlSL pitchAxis); // 0x0000000180A9F070-0x0000000180A9F1D0
		}
	
		internal sealed class LdlVuTDcjTesFajrqPIKPmgNMlCL : uTxUfgOiQNURvPChXIypCPYRBYQ, IControllerTemplateStick6D // TypeDefIndex: 5948
		{
			// Fields
			private const int mKFwLinqEOgcyYuYTFOPgjxyNeld = 6; // Metadata: 0x0072F740
	
			// Constructors
			private LdlVuTDcjTesFajrqPIKPmgNMlCL(IControllerTemplate parent, int id, string name, GhREpLFgCYFrjIBVIYiOgCvfqHg[] elements); // 0x0000000180A9DB20-0x0000000180A9DB50
			internal LdlVuTDcjTesFajrqPIKPmgNMlCL(IControllerTemplate parent, int id, string name, KMCVBWMPRfCCvsWXeOWVAVbJlSL positionX, KMCVBWMPRfCCvsWXeOWVAVbJlSL positionY, KMCVBWMPRfCCvsWXeOWVAVbJlSL positionZ, KMCVBWMPRfCCvsWXeOWVAVbJlSL rotationX, KMCVBWMPRfCCvsWXeOWVAVbJlSL rotationY, KMCVBWMPRfCCvsWXeOWVAVbJlSL rotationZ); // 0x0000000180A9D850-0x0000000180A9DB20
		}
	
		internal class bZJyKtoDpKBrniWesjOeCJlrijn // TypeDefIndex: 5949
		{
			// Fields
			public readonly Controller.Element bDuDNJMpWydtSCGFbesOhkyhlgiA; // 0x10
			public readonly IControllerElementTarget xPZdhDiOAODYIzoOlCwTEHEonFp; // 0x18
	
			// Properties
			public bool GHUeJCzFrDgzBXDTzvzXRREPKiu { get; } // 0x0000000180A9E9F0-0x0000000180A9EB70 
			public bool CYoiuSaiDOhzEDDwIKdSkbMwjSa { get; } // 0x0000000180A9E7C0-0x0000000180A9E9F0 
			public bool WYJZMikCCobqJEBifGUemzdCEbUz { get; } // 0x0000000180A9EE80-0x0000000180A9EF40 
			public bool NNbGOZMcXVJtDpyGwfVLmfRMBaE { get; } // 0x0000000180A9EF40-0x0000000180A9F040 
			public float SmusaJYEiWkzlQwwWeWgpvQUdTv { get; } // 0x0000000180A9ECE0-0x0000000180A9EE80 
			public float KWEArpYLlLDDbadXGBrjBxHaMRC { get; } // 0x0000000180A9EB70-0x0000000180A9ECE0 
	
			// Constructors
			public bZJyKtoDpKBrniWesjOeCJlrijn(IControllerElementTarget target, Controller.Element element); // 0x00000001806ED730-0x00000001806ED770
	
			// Methods
			public static bZJyKtoDpKBrniWesjOeCJlrijn EMrPyzqGuVTmURWytVHqWrdHoDK(); // 0x0000000180A9E750-0x0000000180A9E7C0
		}
	
		internal class VFxPhDPrNTgTyVHycNmEMHDCedd // TypeDefIndex: 5950
		{
			// Fields
			public readonly Controller jbVnEoSGijlOtsPVojcUnqQxqRw; // 0x10
			public readonly IHardwareControllerTemplateMap_Internal sSbEZCaDREYtKmkAmjHJRMyprbG; // 0x18
	
			// Constructors
			public VFxPhDPrNTgTyVHycNmEMHDCedd(Controller controller, IHardwareControllerTemplateMap_Internal templateMap); // 0x0000000180A9E660-0x0000000180A9E750
		}
	
		// Constructors
		protected ControllerTemplate(object payload); // 0x0000000180A8DB10-0x0000000180A8DBA0
		private ControllerTemplate(VFxPhDPrNTgTyVHycNmEMHDCedd initializer); // 0x0000000180A8DBA0-0x0000000180A90D40
	
		// Methods
		protected IControllerTemplateElement GetElement(int id); // 0x0000000180A8D070-0x0000000180A8D390
		protected T GetElement<T>(int id)
			where T : class, IControllerTemplateElement;
		IControllerTemplateElement IControllerTemplate.GetElement(int param_0000cadb); // 0x0000000180A8D6B0-0x0000000180A8D770
		T IControllerTemplate.GetElement<T>(int param_0000cadc)
			where T : class, IControllerTemplateElement;
		int IControllerTemplate.GetElementTargets(ControllerElementTarget param_0000cadd, IList<ControllerTemplateElementTarget> param_0000cade); // 0x0000000180A8D5A0-0x0000000180A8D6B0
		private int EipMJtPImKVJQBqufeiVaoyqHqL(ControllerElementTarget param_0000cadf, ref IList<ControllerTemplateElementTarget> param_0000cae0); // 0x0000000180A8CCD0-0x0000000180A8CFB0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static Type GetInterfaceType(ControllerTemplateElementType elementType); // 0x0000000180A8D390-0x0000000180A8D4A0
		private static IList<bZJyKtoDpKBrniWesjOeCJlrijn> rACWlXdmVRNjpPnzabTwfjNfTtn(Controller param_0000cae2, IControllerTemplateAxisSource param_0000cae3); // 0x0000000180A90FE0-0x0000000180A91730
		private static IList<bZJyKtoDpKBrniWesjOeCJlrijn> rACWlXdmVRNjpPnzabTwfjNfTtn(Controller param_0000cae4, IControllerTemplateButtonSource param_0000cae5); // 0x0000000180A90E30-0x0000000180A90EA0
		private static IList<bZJyKtoDpKBrniWesjOeCJlrijn> rACWlXdmVRNjpPnzabTwfjNfTtn(Controller param_0000cae6, IControllerElementTarget param_0000cae7); // 0x0000000180A90EA0-0x0000000180A90FE0
		private static IControllerTemplateElement JBZNIUqbswEjAdvJHzevReoISFt(List<IControllerTemplateElement> param_0000cae8, int param_0000cae9); // 0x0000000180A8D4A0-0x0000000180A8D5A0
		private static KMCVBWMPRfCCvsWXeOWVAVbJlSL mfezPfINNspUYIPtDUojBZinDwU(IControllerTemplate param_0000caea, ADictionary<int, IControllerTemplateElement> param_0000caeb, int param_0000caec); // 0x0000000180A90D40-0x0000000180A90E30
		private static KMCVBWMPRfCCvsWXeOWVAVbJlSL FqdaJmHwGdXJxRcJfcNriYraEQxA(IControllerTemplate param_0000caed, ADictionary<int, IControllerTemplateElement> param_0000caee, int param_0000caef); // 0x0000000180A8CFB0-0x0000000180A8D070
	}
}
