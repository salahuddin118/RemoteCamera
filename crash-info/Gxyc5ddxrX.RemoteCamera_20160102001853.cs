S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2
Build-Number: Tizen_Ref.Device-ODROID-U3_20150504.1306
Build-Date: 2015.05.04 13:06:30

Crash Information
Process Name: RemoteCamera
PID: 4998
Date: 2016-01-02 00:18:53(GMT+0900)
Executable File Path: /opt/apps/Gxyc5ddxrX/bin/RemoteCamera
This process is multi-thread process
pid=4998 tid=4998
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4998, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbed18034
r2   = 0xbed18038, r3   = 0x00000001
r4   = 0xb3db8d48, r5   = 0xb3db8d48
r6   = 0xbed18034, r7   = 0xbed18038
r8   = 0x00000002, r9   = 0x00000001
r10  = 0x00000000, fp   = 0xbed18068
ip   = 0xb3dba194, sp   = 0xbed17e90
lr   = 0xb3a82aa1, pc   = 0xb42a8918
cpsr = 0x68000030

Memory Information
MemTotal:  2059848 KB
MemFree:   1577828 KB
Buffers:     14988 KB
Cached:     173124 KB
VmPeak:      97304 KB
VmSize:      97300 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30772 KB
VmRSS:       30772 KB
VmData:      13608 KB
VmStk:         164 KB
VmExe:          32 KB
VmLib:       45844 KB
VmPTE:          82 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 000dd000 rw-p [heap]
000dd000 003fd000 rw-p [heap]
b1446000 b17ca000 rw-s anon_inode:exynos_gem
b17ca000 b1b4e000 rw-s anon_inode:exynos_gem
b2119000 b211e000 r-xp /usr/lib/libhaptic-module.so
b22aa000 b22ab000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b22ba000 b22bd000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b22c5000 b22cf000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b22d7000 b22eb000 r-xp /usr/lib/libnetwork.so.0.0.0
b22f4000 b2308000 r-xp /usr/lib/libwifi-direct.so.0.0
b2310000 b2318000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2319000 b2322000 r-xp /usr/lib/libcapi-network-connection.so.0.1.3_18
b232a000 b2547000 r-xp /usr/lib/libface-engine-plugin.so
b25a5000 b266a000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2678000 b269b000 r-xp /usr/lib/osp/libosp-face.so.1.2.2.0
b26a5000 b26c2000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b26cb000 b26d4000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b26dd000 b26ec000 r-xp /opt/usr/apps/Gxyc5ddxrX/bin/RemoteCamera.exe
b26f4000 b2766000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b276e000 b27a8000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b27b1000 b27b5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b27bd000 b27ee000 r-xp /usr/lib/libpulse.so.0.12.4
b27f6000 b2859000 r-xp /usr/lib/libasound.so.2.0.0
b2863000 b2866000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b286e000 b2872000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b287b000 b2898000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b28a0000 b28ae000 r-xp /usr/lib/libmmfsound.so.0.1.0
b28b6000 b2952000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b295e000 b299f000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b29a8000 b29b1000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b29b9000 b29c6000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b29cf000 b29d2000 r-xp /usr/lib/libmm_ta.so.0.0.0
b29da000 b29e9000 r-xp /usr/lib/libICE.so.6.3.0
b29f3000 b29f8000 r-xp /usr/lib/libSM.so.6.0.1
b2a00000 b2a01000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2a09000 b2a11000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2a19000 b2a21000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b2a2c000 b2a2f000 r-xp /usr/lib/libmmfsession.so.0.0.0
b2a37000 b2a7b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b2a84000 b2a8a000 r-xp /usr/lib/libUMP.so
b2a92000 b2a98000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2aa0000 b2aa1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2aaa000 b2af5000 r-xp /usr/lib/libtiff.so.5.1.0
b2b00000 b2b29000 r-xp /usr/lib/libturbojpeg.so
b2b42000 b2b48000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2b50000 b2b56000 r-xp /usr/lib/libgif.so.4.1.6
b2b5e000 b2b80000 r-xp /usr/lib/libavutil.so.51.73.101
b2b8f000 b2bbd000 r-xp /usr/lib/libswscale.so.2.1.101
b2bc6000 b2ebd000 r-xp /usr/lib/libavcodec.so.54.59.100
b31e4000 b31fd000 r-xp /usr/lib/libpng12.so.0.50.0
b3206000 b320c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3214000 b3220000 r-xp /usr/lib/libtts.so
b3228000 b3365000 r-xp /usr/lib/libMali.so
b3372000 b3429000 r-xp /usr/lib/libcairo.so.2.11200.12
b3433000 b344d000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3456000 b3d51000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3dc4000 b3dc9000 r-xp /usr/lib/libslp_devman_plugin.so
b3dd1000 b3dd4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3ddc000 b3de0000 r-xp /usr/lib/libsysman.so.0.2.0
b3de8000 b3df9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3e02000 b3e04000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3e0c000 b3e0e000 r-xp /usr/lib/libdeviced.so.0.1.0
b3e16000 b3e2c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3e34000 b3e36000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3e3e000 b3e41000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3e49000 b3e4c000 r-xp /usr/lib/libdevice-node.so.0.1
b3e54000 b3e58000 r-xp /usr/lib/libheynoti.so.0.0.2
b3e60000 b3ea5000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3eae000 b3ec3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3ecc000 b3ed0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3ed8000 b3edd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3ee5000 b3ee6000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3eef000 b3ef2000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3efa000 b3efd000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3f06000 b3f09000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3f11000 b3f12000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3f1a000 b3f28000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3f31000 b3f53000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3f5b000 b3f5e000 r-xp /usr/lib/libuuid.so.1.3.0
b3f67000 b3f85000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3f8d000 b3fa4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3fad000 b3fae000 r-xp /usr/lib/libpmapi.so.1.2
b3fb6000 b3fbe000 r-xp /usr/lib/libminizip.so.1.0.0
b3fc6000 b3fd1000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3fd9000 b40b1000 r-xp /usr/lib/libxml2.so.2.7.8
b40be000 b40dc000 r-xp /usr/lib/libpcre.so.0.0.1
b40e4000 b40e7000 r-xp /usr/lib/libiniparser.so.0
b40f0000 b40f4000 r-xp /usr/lib/libhaptic.so.0.1
b40fc000 b4107000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b4114000 b4119000 r-xp /usr/lib/libdevman.so.0.1
b4122000 b4126000 r-xp /usr/lib/libchromium.so.1.0
b412e000 b4134000 r-xp /usr/lib/libappsvc.so.0.1.0
b413c000 b413d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b4145000 b414b000 r-xp /usr/lib/libalarm.so.0.0.0
b4154000 b415d000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4166000 b4178000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b4180000 b447f000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b44a6000 b44b0000 r-xp /lib/libnss_files-2.13.so
b44b9000 b44c2000 r-xp /lib/libnss_nis-2.13.so
b44cb000 b44dc000 r-xp /lib/libnsl-2.13.so
b44e7000 b44ed000 r-xp /lib/libnss_compat-2.13.so
b4855000 b4866000 r-xp /usr/lib/libcom-core.so.0.0.1
b486e000 b4870000 r-xp /usr/lib/libdri2.so.0.0.0
b4878000 b4880000 r-xp /usr/lib/libdrm.so.2.4.0
b4888000 b488c000 r-xp /usr/lib/libtbm.so.1.0.0
b4894000 b4897000 r-xp /usr/lib/libXv.so.1.0.0
b489f000 b496a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4980000 b4990000 r-xp /usr/lib/libnotification.so.0.1.0
b4998000 b499f000 r-xp /usr/lib/libutilX.so.1.1.0
b49a7000 b49cb000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b49d4000 b49e4000 r-xp /lib/libresolv-2.13.so
b49e8000 b49ea000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49f2000 b4b45000 r-xp /usr/lib/libcrypto.so.1.0.0
b4b63000 b4baf000 r-xp /usr/lib/libssl.so.1.0.0
b4bbb000 b4be7000 r-xp /usr/lib/libidn.so.11.5.44
b4bf0000 b4bfa000 r-xp /usr/lib/libcares.so.2.0.0
b4c02000 b4c19000 r-xp /lib/libexpat.so.1.5.2
b4c23000 b4c47000 r-xp /usr/lib/libicule.so.48.1
b4c50000 b4c58000 r-xp /usr/lib/libsf_common.so
b4c60000 b4cfb000 r-xp /usr/lib/libstdc++.so.6.0.14
b4d0e000 b4deb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4df6000 b4e1b000 r-xp /usr/lib/libexif.so.12.3.3
b4e2f000 b4e39000 r-xp /usr/lib/libethumb.so.1.7.99
b4e41000 b4e85000 r-xp /usr/lib/libsndfile.so.1.0.25
b4e93000 b4e95000 r-xp /usr/lib/libctxdata.so.0.0.0
b4e9d000 b4eab000 r-xp /usr/lib/libremix.so.0.0.0
b4eb3000 b4eb4000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4ebc000 b4ed5000 r-xp /usr/lib/liblua-5.1.so
b4ede000 b4ee5000 r-xp /usr/lib/libembryo.so.1.7.99
b4eee000 b4ef1000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ef9000 b4f36000 r-xp /usr/lib/libcurl.so.4.3.0
b4f40000 b4f44000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4f4d000 b4fb7000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4fc4000 b4fe8000 r-xp /usr/lib/libfontconfig.so.1.5.0
b4ff1000 b504d000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b505f000 b5073000 r-xp /usr/lib/libfribidi.so.0.3.1
b507b000 b50d0000 r-xp /usr/lib/libfreetype.so.6.8.1
b50db000 b50ff000 r-xp /usr/lib/libjpeg.so.8.0.2
b5117000 b512e000 r-xp /lib/libz.so.1.2.5
b5136000 b5143000 r-xp /usr/lib/libsensor.so.1.1.0
b514e000 b5150000 r-xp /usr/lib/libapp-checker.so.0.1.0
b5158000 b515e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6275000 b635d000 r-xp /usr/lib/libicuuc.so.48.1
b636a000 b648a000 r-xp /usr/lib/libicui18n.so.48.1
b6498000 b649b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b64a3000 b64ac000 r-xp /usr/lib/libvconf.so.0.2.45
b64b4000 b64c2000 r-xp /usr/lib/libail.so.0.1.0
b64ca000 b64e2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b64e3000 b64e8000 r-xp /usr/lib/libffi.so.5.0.10
b64f0000 b64f1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b64f9000 b6503000 r-xp /usr/lib/libXext.so.6.4.0
b650c000 b650f000 r-xp /usr/lib/libXtst.so.6.1.0
b6517000 b651d000 r-xp /usr/lib/libXrender.so.1.3.0
b6525000 b652b000 r-xp /usr/lib/libXrandr.so.2.2.0
b6533000 b6534000 r-xp /usr/lib/libXinerama.so.1.0.0
b653d000 b6546000 r-xp /usr/lib/libXi.so.6.1.0
b654e000 b6551000 r-xp /usr/lib/libXfixes.so.3.1.0
b6559000 b655b000 r-xp /usr/lib/libXgesture.so.7.0.0
b6563000 b6565000 r-xp /usr/lib/libXcomposite.so.1.0.0
b656d000 b656e000 r-xp /usr/lib/libXdamage.so.1.1.0
b6577000 b657e000 r-xp /usr/lib/libXcursor.so.1.0.2
b6586000 b658e000 r-xp /usr/lib/libemotion.so.1.7.99
b6596000 b65b1000 r-xp /usr/lib/libecore_con.so.1.7.99
b65ba000 b65bf000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65c8000 b65d0000 r-xp /usr/lib/libethumb_client.so.1.7.99
b65d8000 b65da000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b65e2000 b65e6000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b65ef000 b6605000 r-xp /usr/lib/libefreet.so.1.7.99
b660f000 b6618000 r-xp /usr/lib/libedbus.so.1.7.99
b6620000 b6625000 r-xp /usr/lib/libecore_fb.so.1.7.99
b662e000 b668a000 r-xp /usr/lib/libedje.so.1.7.99
b6694000 b66ab000 r-xp /usr/lib/libecore_input.so.1.7.99
b66c6000 b66cb000 r-xp /usr/lib/libecore_file.so.1.7.99
b66d3000 b66f0000 r-xp /usr/lib/libecore_evas.so.1.7.99
b66f9000 b6738000 r-xp /usr/lib/libeina.so.1.7.99
b6741000 b67f0000 r-xp /usr/lib/libevas.so.1.7.99
b6812000 b6825000 r-xp /usr/lib/libeet.so.1.7.99
b682e000 b6898000 r-xp /lib/libm-2.13.so
b68a1000 b68a6000 r-xp /usr/lib/libappcore-common.so.1.1
b68ae000 b68b9000 r-xp /usr/lib/libaul.so.0.1.0
b68c2000 b68f6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68ff000 b692f000 r-xp /usr/lib/libecore_x.so.1.7.99
b6938000 b694d000 r-xp /usr/lib/libecore.so.1.7.99
b6964000 b6a84000 r-xp /usr/lib/libelementary.so.1.7.99
b6a9e000 b6aa0000 r-xp /opt/usr/apps/Gxyc5ddxrX/bin/RemoteCamera
b6aaa000 b6aad000 r-xp /lib/libattr.so.1.1.0
b6ab5000 b6ab7000 r-xp /usr/lib/libXau.so.6.0.0
b6abf000 b6ac5000 r-xp /lib/librt-2.13.so
b6ace000 b6ad6000 r-xp /lib/libcrypt-2.13.so
b6b06000 b6b09000 r-xp /lib/libcap.so.2.21
b6b11000 b6b13000 r-xp /usr/lib/libiri.so
b6b1b000 b6b30000 r-xp /usr/lib/libxcb.so.1.1.0
b6b38000 b6b43000 r-xp /lib/libunwind.so.8.0.1
b6b71000 b6c8e000 r-xp /lib/libc-2.13.so
b6c9c000 b6ca5000 r-xp /lib/libgcc_s-4.5.3.so.1
b6cad000 b6cb0000 r-xp /usr/lib/libsmack.so.1.0.0
b6cb8000 b6ce4000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6ced000 b6cf1000 r-xp /usr/lib/libbundle.so.0.1.22
b6cf9000 b6cfb000 r-xp /lib/libdl-2.13.so
b6d04000 b6dde000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6de7000 b6e51000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e5b000 b6e68000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e71000 b6f57000 r-xp /usr/lib/libX11.so.6.3.0
b6f62000 b6f76000 r-xp /lib/libpthread-2.13.so
b6f81000 b6f82000 r-xp /usr/lib/libdlog.so.0.0.0
b6f8f000 b6f93000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f9c000 b6fa0000 r-xp /usr/lib/libsys-assert.so
b6fa8000 b6fc5000 r-xp /lib/ld-2.13.so
bed12000 bed33000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4998)
Call Stack Count: 26
 0: Tizen::Base::BufferBase::GetCapacity() const + 0x3 (0xb42a8918) [/usr/lib/osp/libosp-appfw.so] + 0x128918
 1: (0xb3a82aa1) [/usr/lib/osp/libosp-uifw.so] + 0x62caa1
 2: Tizen::Graphics::_BitmapImpl::Construct(Tizen::Base::ByteBuffer const&, Tizen::Graphics::Dimension const&, Tizen::Graphics::BitmapPixelFormat, Tizen::Graphics::BufferScaling) + 0x5a (0xb3a84147) [/usr/lib/osp/libosp-uifw.so] + 0x62e147
 3: Tizen::Graphics::Bitmap::Construct(Tizen::Base::ByteBuffer const&, Tizen::Graphics::Dimension const&, Tizen::Graphics::BitmapPixelFormat, Tizen::Graphics::BufferScaling) + 0x32 (0xb3a78263) [/usr/lib/osp/libosp-uifw.so] + 0x622263
 4: Info::SetByteBuffer(Tizen::Base::ByteBuffer*, int, int, Tizen::Graphics::BitmapPixelFormat) + 0x1b4 (0xb26e23c0) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0x53c0
 5: TizenRemoteCamera::GetRemoteImageN() + 0x5e0 (0xb26e8f28) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0xbf28
 6: TizenRemoteCamera::OnTimerExpired(Tizen::Base::Runtime::Timer&) + 0x2c (0xb26e9008) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0xc008
 7: non-virtual thunk to TizenRemoteCamera::OnTimerExpired(Tizen::Base::Runtime::Timer&) + 0x2c (0xb26e90bc) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0xc0bc
End of Call Stack

Package Information
Package Name: Gxyc5ddxrX.RemoteCamera
Package ID : Gxyc5ddxrX
Version: 2.0.0
Package Type: tpk
App Name: RemoteCamera
App ID: Gxyc5ddxrX.RemoteCamera
Type: Application
Categories: (NULL)
