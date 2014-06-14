// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EDepotBuildStatus : int
	{
		k_EDepotBuildStatusInvalid = 0,
		k_EDepotBuildStatusProcessingConfig = 1,
		k_EDepotBuildStatusBuildingFileList = 2,
		k_EDepotBuildStatusProcessingData = 3,
		k_EDepotBuildStatusUploadingData = 4,
		k_EDepotBuildStatusCompleted = 5,
		k_EDepotBuildStatusFailed = 6,
	};
	
	public enum EStatusDepotVersion : int
	{
		k_EStatusDepotVersionInvalid = 0,
		k_EStatusDepotVersionDisabled = 1,
		k_EStatusDepotVersionAvailable = 2,
		k_EStatusDepotVersionCurrent = 3,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientDepotBuilderVTable
	{
		public IntPtr RegisterAppBuild0;
		public IntPtr GetRegisteredBuildID1;
		public IntPtr StartDepotBuildFromConfigFile2;
		public IntPtr BGetDepotBuildStatus3;
		public IntPtr CloseDepotBuildHandle4;
		public IntPtr ReconstructDepotFromManifestAndChunks5;
		public IntPtr BGetChunkCounts6;
		public IntPtr GetManifestGIDs7;
		public IntPtr FinishAppBuild8;
		public IntPtr VerifyChunkStore9;
		public IntPtr StartUploadTest10;
		public IntPtr DownloadDepot11;
		private IntPtr DTorIClientDepotBuilder12;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTDEPOTBUILDER_INTERFACE_VERSION001")]
	public class IClientDepotBuilder : InteropHelp.NativeWrapper<IClientDepotBuilderVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeRegisterAppBuildUBS( IntPtr thisptr, UInt32 nAppID, [MarshalAs(UnmanagedType.I1)] bool bLocalCSBuild, string cszDescription );
		public UInt32 RegisterAppBuild( UInt32 nAppID, bool bLocalCSBuild, string cszDescription ) 
		{
			return this.GetFunction<NativeRegisterAppBuildUBS>( this.Functions.RegisterAppBuild0 )( this.ObjectAddress, nAppID, bLocalCSBuild, cszDescription ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetRegisteredBuildIDU( IntPtr thisptr, UInt32 arg0 );
		public UInt32 GetRegisteredBuildID( UInt32 arg0 ) 
		{
			return this.GetFunction<NativeGetRegisteredBuildIDU>( this.Functions.GetRegisteredBuildID1 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeStartDepotBuildFromConfigFileSSSUUS( IntPtr thisptr, string pchConfigFile, string arg1, string arg2, UInt32 arg3, UInt32 arg4, string arg5 );
		public UInt32 StartDepotBuildFromConfigFile( string pchConfigFile, string arg1, string arg2, UInt32 arg3, UInt32 arg4, string arg5 ) 
		{
			return this.GetFunction<NativeStartDepotBuildFromConfigFileSSSUUS>( this.Functions.StartDepotBuildFromConfigFile2 )( this.ObjectAddress, pchConfigFile, arg1, arg2, arg3, arg4, arg5 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBGetDepotBuildStatusUEU( IntPtr thisptr, UInt32 hDepotBuild, ref EDepotBuildStatus pStatusOut, ref UInt32 pPercentDone );
		public bool BGetDepotBuildStatus( UInt32 hDepotBuild, ref EDepotBuildStatus pStatusOut, ref UInt32 pPercentDone ) 
		{
			return this.GetFunction<NativeBGetDepotBuildStatusUEU>( this.Functions.BGetDepotBuildStatus3 )( this.ObjectAddress, hDepotBuild, ref pStatusOut, ref pPercentDone ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCloseDepotBuildHandleU( IntPtr thisptr, UInt32 hDepotBuild );
		public bool CloseDepotBuildHandle( UInt32 hDepotBuild ) 
		{
			return this.GetFunction<NativeCloseDepotBuildHandleU>( this.Functions.CloseDepotBuildHandle4 )( this.ObjectAddress, hDepotBuild ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeReconstructDepotFromManifestAndChunksSSSU( IntPtr thisptr, string pchLocalManifestPath, string pchLocalChunkPath, string pchRestorePath, UInt32 arg3 );
		public UInt32 ReconstructDepotFromManifestAndChunks( string pchLocalManifestPath, string pchLocalChunkPath, string pchRestorePath, UInt32 arg3 ) 
		{
			return this.GetFunction<NativeReconstructDepotFromManifestAndChunksSSSU>( this.Functions.ReconstructDepotFromManifestAndChunks5 )( this.ObjectAddress, pchLocalManifestPath, pchLocalChunkPath, pchRestorePath, arg3 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBGetChunkCountsUUU( IntPtr thisptr, UInt32 hDepotBuild, ref UInt32 unTotalChunksInNewBuild, ref UInt32 unChunksAlsoInOldBuild );
		public bool BGetChunkCounts( UInt32 hDepotBuild, ref UInt32 unTotalChunksInNewBuild, ref UInt32 unChunksAlsoInOldBuild ) 
		{
			return this.GetFunction<NativeBGetChunkCountsUUU>( this.Functions.BGetChunkCounts6 )( this.ObjectAddress, hDepotBuild, ref unTotalChunksInNewBuild, ref unChunksAlsoInOldBuild ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetManifestGIDsUUUB( IntPtr thisptr, UInt32 hDepotBuild, ref UInt64 pBaselineGID, ref UInt64 pNewGID, ref bool arg3 );
		public bool GetManifestGIDs( UInt32 hDepotBuild, ref UInt64 pBaselineGID, ref UInt64 pNewGID, ref bool arg3 ) 
		{
			return this.GetFunction<NativeGetManifestGIDsUUUB>( this.Functions.GetManifestGIDs7 )( this.ObjectAddress, hDepotBuild, ref pBaselineGID, ref pNewGID, ref arg3 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeFinishAppBuildUUSBU( IntPtr thisptr, UInt32 uBuildID, UInt32 nAppID, string cszBetaKey, [MarshalAs(UnmanagedType.I1)] bool bOnlyFinish, UInt32 cNumSkipDepots );
		public UInt32 FinishAppBuild( UInt32 uBuildID, UInt32 nAppID, string cszBetaKey, bool bOnlyFinish, UInt32 cNumSkipDepots ) 
		{
			return this.GetFunction<NativeFinishAppBuildUUSBU>( this.Functions.FinishAppBuild8 )( this.ObjectAddress, uBuildID, nAppID, cszBetaKey, bOnlyFinish, cNumSkipDepots ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeVerifyChunkStoreUUS( IntPtr thisptr, UInt32 arg0, UInt32 arg1, string arg2 );
		public UInt32 VerifyChunkStore( UInt32 arg0, UInt32 arg1, string arg2 ) 
		{
			return this.GetFunction<NativeVerifyChunkStoreUUS>( this.Functions.VerifyChunkStore9 )( this.ObjectAddress, arg0, arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeStartUploadTestUU( IntPtr thisptr, UInt32 arg0, UInt32 arg1 );
		public UInt32 StartUploadTest( UInt32 arg0, UInt32 arg1 ) 
		{
			return this.GetFunction<NativeStartUploadTestUU>( this.Functions.StartUploadTest10 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeDownloadDepotUU( IntPtr thisptr, UInt32 arg0, UInt32 arg1 );
		public UInt32 DownloadDepot( UInt32 arg0, UInt32 arg1 ) 
		{
			return this.GetFunction<NativeDownloadDepotUU>( this.Functions.DownloadDepot11 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
	};
}
