S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2
Build-Number: Tizen_Ref.Device-ODROID-U3_20150504.1306
Build-Date: 2015.05.04 13:06:30

Crash Information
Process Name: RemoteCamera
PID: 4864
Date: 2016-01-02 00:02:53(GMT+0900)
Executable File Path: /opt/apps/Gxyc5ddxrX/bin/RemoteCamera
This process is multi-thread process
pid=4864 tid=4864
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4864, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbe7fb034
r2   = 0xbe7fb038, r3   = 0x00000001
r4   = 0xb3dc9d48, r5   = 0xb3dc9d48
r6   = 0xbe7fb034, r7   = 0xbe7fb038
r8   = 0x00000002, r9   = 0x00000001
r10  = 0x00000000, fp   = 0xbe7fb068
ip   = 0xb3dcb194, sp   = 0xbe7fae90
lr   = 0xb3a93aa1, pc   = 0xb42b9918
cpsr = 0x68000030

Memory Information
MemTotal:  2059848 KB
MemFree:   1582240 KB
Buffers:     19060 KB
Cached:     192176 KB
VmPeak:      98284 KB
VmSize:      98280 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31724 KB
VmRSS:       31724 KB
VmData:      14592 KB
VmStk:         164 KB
VmExe:          32 KB
VmLib:       45844 KB
VmPTE:          86 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 000dd000 rw-p [heap]
000dd000 00468000 rw-p [heap]
b1457000 b17db000 rw-s anon_inode:exynos_gem
b17db000 b1b5f000 rw-s anon_inode:exynos_gem
b212a000 b212f000 r-xp /usr/lib/libhaptic-module.so
b22bb000 b22bc000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b22cb000 b22ce000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b22d6000 b22e0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b22e8000 b22fc000 r-xp /usr/lib/libnetwork.so.0.0.0
b2305000 b2319000 r-xp /usr/lib/libwifi-direct.so.0.0
b2321000 b2329000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b232a000 b2333000 r-xp /usr/lib/libcapi-network-connection.so.0.1.3_18
b233b000 b2558000 r-xp /usr/lib/libface-engine-plugin.so
b25b6000 b267b000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2689000 b26ac000 r-xp /usr/lib/osp/libosp-face.so.1.2.2.0
b26b6000 b26d3000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b26dc000 b26e5000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b26ee000 b26fd000 r-xp /opt/usr/apps/Gxyc5ddxrX/bin/RemoteCamera.exe
b2705000 b2777000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b277f000 b27b9000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b27c2000 b27c6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b27ce000 b27ff000 r-xp /usr/lib/libpulse.so.0.12.4
b2807000 b286a000 r-xp /usr/lib/libasound.so.2.0.0
b2874000 b2877000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b287f000 b2883000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b288c000 b28a9000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b28b1000 b28bf000 r-xp /usr/lib/libmmfsound.so.0.1.0
b28c7000 b2963000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b296f000 b29b0000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b29b9000 b29c2000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b29ca000 b29d7000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b29e0000 b29e3000 r-xp /usr/lib/libmm_ta.so.0.0.0
b29eb000 b29fa000 r-xp /usr/lib/libICE.so.6.3.0
b2a04000 b2a09000 r-xp /usr/lib/libSM.so.6.0.1
b2a11000 b2a12000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2a1a000 b2a22000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2a2a000 b2a32000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b2a3d000 b2a40000 r-xp /usr/lib/libmmfsession.so.0.0.0
b2a48000 b2a8c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b2a95000 b2a9b000 r-xp /usr/lib/libUMP.so
b2aa3000 b2aa9000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2ab1000 b2ab2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2abb000 b2b06000 r-xp /usr/lib/libtiff.so.5.1.0
b2b11000 b2b3a000 r-xp /usr/lib/libturbojpeg.so
b2b53000 b2b59000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2b61000 b2b67000 r-xp /usr/lib/libgif.so.4.1.6
b2b6f000 b2b91000 r-xp /usr/lib/libavutil.so.51.73.101
b2ba0000 b2bce000 r-xp /usr/lib/libswscale.so.2.1.101
b2bd7000 b2ece000 r-xp /usr/lib/libavcodec.so.54.59.100
b31f5000 b320e000 r-xp /usr/lib/libpng12.so.0.50.0
b3217000 b321d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3225000 b3231000 r-xp /usr/lib/libtts.so
b3239000 b3376000 r-xp /usr/lib/libMali.so
b3383000 b343a000 r-xp /usr/lib/libcairo.so.2.11200.12
b3444000 b345e000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3467000 b3d62000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3dd5000 b3dda000 r-xp /usr/lib/libslp_devman_plugin.so
b3de2000 b3de5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3ded000 b3df1000 r-xp /usr/lib/libsysman.so.0.2.0
b3df9000 b3e0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3e13000 b3e15000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3e1d000 b3e1f000 r-xp /usr/lib/libdeviced.so.0.1.0
b3e27000 b3e3d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3e45000 b3e47000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3e4f000 b3e52000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3e5a000 b3e5d000 r-xp /usr/lib/libdevice-node.so.0.1
b3e65000 b3e69000 r-xp /usr/lib/libheynoti.so.0.0.2
b3e71000 b3eb6000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3ebf000 b3ed4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3edd000 b3ee1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3ee9000 b3eee000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3ef6000 b3ef7000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3f00000 b3f03000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3f0b000 b3f0e000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3f17000 b3f1a000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3f22000 b3f23000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3f2b000 b3f39000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3f42000 b3f64000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3f6c000 b3f6f000 r-xp /usr/lib/libuuid.so.1.3.0
b3f78000 b3f96000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3f9e000 b3fb5000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3fbe000 b3fbf000 r-xp /usr/lib/libpmapi.so.1.2
b3fc7000 b3fcf000 r-xp /usr/lib/libminizip.so.1.0.0
b3fd7000 b3fe2000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3fea000 b40c2000 r-xp /usr/lib/libxml2.so.2.7.8
b40cf000 b40ed000 r-xp /usr/lib/libpcre.so.0.0.1
b40f5000 b40f8000 r-xp /usr/lib/libiniparser.so.0
b4101000 b4105000 r-xp /usr/lib/libhaptic.so.0.1
b410d000 b4118000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b4125000 b412a000 r-xp /usr/lib/libdevman.so.0.1
b4133000 b4137000 r-xp /usr/lib/libchromium.so.1.0
b413f000 b4145000 r-xp /usr/lib/libappsvc.so.0.1.0
b414d000 b414e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b4156000 b415c000 r-xp /usr/lib/libalarm.so.0.0.0
b4165000 b416e000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4177000 b4189000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b4191000 b4490000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b44b7000 b44c1000 r-xp /lib/libnss_files-2.13.so
b44ca000 b44d3000 r-xp /lib/libnss_nis-2.13.so
b44dc000 b44ed000 r-xp /lib/libnsl-2.13.so
b44f8000 b44fe000 r-xp /lib/libnss_compat-2.13.so
b4866000 b4877000 r-xp /usr/lib/libcom-core.so.0.0.1
b487f000 b4881000 r-xp /usr/lib/libdri2.so.0.0.0
b4889000 b4891000 r-xp /usr/lib/libdrm.so.2.4.0
b4899000 b489d000 r-xp /usr/lib/libtbm.so.1.0.0
b48a5000 b48a8000 r-xp /usr/lib/libXv.so.1.0.0
b48b0000 b497b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4991000 b49a1000 r-xp /usr/lib/libnotification.so.0.1.0
b49a9000 b49b0000 r-xp /usr/lib/libutilX.so.1.1.0
b49b8000 b49dc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b49e5000 b49f5000 r-xp /lib/libresolv-2.13.so
b49f9000 b49fb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4a03000 b4b56000 r-xp /usr/lib/libcrypto.so.1.0.0
b4b74000 b4bc0000 r-xp /usr/lib/libssl.so.1.0.0
b4bcc000 b4bf8000 r-xp /usr/lib/libidn.so.11.5.44
b4c01000 b4c0b000 r-xp /usr/lib/libcares.so.2.0.0
b4c13000 b4c2a000 r-xp /lib/libexpat.so.1.5.2
b4c34000 b4c58000 r-xp /usr/lib/libicule.so.48.1
b4c61000 b4c69000 r-xp /usr/lib/libsf_common.so
b4c71000 b4d0c000 r-xp /usr/lib/libstdc++.so.6.0.14
b4d1f000 b4dfc000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4e07000 b4e2c000 r-xp /usr/lib/libexif.so.12.3.3
b4e40000 b4e4a000 r-xp /usr/lib/libethumb.so.1.7.99
b4e52000 b4e96000 r-xp /usr/lib/libsndfile.so.1.0.25
b4ea4000 b4ea6000 r-xp /usr/lib/libctxdata.so.0.0.0
b4eae000 b4ebc000 r-xp /usr/lib/libremix.so.0.0.0
b4ec4000 b4ec5000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4ecd000 b4ee6000 r-xp /usr/lib/liblua-5.1.so
b4eef000 b4ef6000 r-xp /usr/lib/libembryo.so.1.7.99
b4eff000 b4f02000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4f0a000 b4f47000 r-xp /usr/lib/libcurl.so.4.3.0
b4f51000 b4f55000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4f5e000 b4fc8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4fd5000 b4ff9000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5002000 b505e000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5070000 b5084000 r-xp /usr/lib/libfribidi.so.0.3.1
b508c000 b50e1000 r-xp /usr/lib/libfreetype.so.6.8.1
b50ec000 b5110000 r-xp /usr/lib/libjpeg.so.8.0.2
b5128000 b513f000 r-xp /lib/libz.so.1.2.5
b5147000 b5154000 r-xp /usr/lib/libsensor.so.1.1.0
b515f000 b5161000 r-xp /usr/lib/libapp-checker.so.0.1.0
b5169000 b516f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6286000 b636e000 r-xp /usr/lib/libicuuc.so.48.1
b637b000 b649b000 r-xp /usr/lib/libicui18n.so.48.1
b64a9000 b64ac000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b64b4000 b64bd000 r-xp /usr/lib/libvconf.so.0.2.45
b64c5000 b64d3000 r-xp /usr/lib/libail.so.0.1.0
b64db000 b64f3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b64f4000 b64f9000 r-xp /usr/lib/libffi.so.5.0.10
b6501000 b6502000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b650a000 b6514000 r-xp /usr/lib/libXext.so.6.4.0
b651d000 b6520000 r-xp /usr/lib/libXtst.so.6.1.0
b6528000 b652e000 r-xp /usr/lib/libXrender.so.1.3.0
b6536000 b653c000 r-xp /usr/lib/libXrandr.so.2.2.0
b6544000 b6545000 r-xp /usr/lib/libXinerama.so.1.0.0
b654e000 b6557000 r-xp /usr/lib/libXi.so.6.1.0
b655f000 b6562000 r-xp /usr/lib/libXfixes.so.3.1.0
b656a000 b656c000 r-xp /usr/lib/libXgesture.so.7.0.0
b6574000 b6576000 r-xp /usr/lib/libXcomposite.so.1.0.0
b657e000 b657f000 r-xp /usr/lib/libXdamage.so.1.1.0
b6588000 b658f000 r-xp /usr/lib/libXcursor.so.1.0.2
b6597000 b659f000 r-xp /usr/lib/libemotion.so.1.7.99
b65a7000 b65c2000 r-xp /usr/lib/libecore_con.so.1.7.99
b65cb000 b65d0000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65d9000 b65e1000 r-xp /usr/lib/libethumb_client.so.1.7.99
b65e9000 b65eb000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b65f3000 b65f7000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6600000 b6616000 r-xp /usr/lib/libefreet.so.1.7.99
b6620000 b6629000 r-xp /usr/lib/libedbus.so.1.7.99
b6631000 b6636000 r-xp /usr/lib/libecore_fb.so.1.7.99
b663f000 b669b000 r-xp /usr/lib/libedje.so.1.7.99
b66a5000 b66bc000 r-xp /usr/lib/libecore_input.so.1.7.99
b66d7000 b66dc000 r-xp /usr/lib/libecore_file.so.1.7.99
b66e4000 b6701000 r-xp /usr/lib/libecore_evas.so.1.7.99
b670a000 b6749000 r-xp /usr/lib/libeina.so.1.7.99
b6752000 b6801000 r-xp /usr/lib/libevas.so.1.7.99
b6823000 b6836000 r-xp /usr/lib/libeet.so.1.7.99
b683f000 b68a9000 r-xp /lib/libm-2.13.so
b68b2000 b68b7000 r-xp /usr/lib/libappcore-common.so.1.1
b68bf000 b68ca000 r-xp /usr/lib/libaul.so.0.1.0
b68d3000 b6907000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6910000 b6940000 r-xp /usr/lib/libecore_x.so.1.7.99
b6949000 b695e000 r-xp /usr/lib/libecore.so.1.7.99
b6975000 b6a95000 r-xp /usr/lib/libelementary.so.1.7.99
b6aaf000 b6ab1000 r-xp /opt/usr/apps/Gxyc5ddxrX/bin/RemoteCamera
b6abb000 b6abe000 r-xp /lib/libattr.so.1.1.0
b6ac6000 b6ac8000 r-xp /usr/lib/libXau.so.6.0.0
b6ad0000 b6ad6000 r-xp /lib/librt-2.13.so
b6adf000 b6ae7000 r-xp /lib/libcrypt-2.13.so
b6b17000 b6b1a000 r-xp /lib/libcap.so.2.21
b6b22000 b6b24000 r-xp /usr/lib/libiri.so
b6b2c000 b6b41000 r-xp /usr/lib/libxcb.so.1.1.0
b6b49000 b6b54000 r-xp /lib/libunwind.so.8.0.1
b6b82000 b6c9f000 r-xp /lib/libc-2.13.so
b6cad000 b6cb6000 r-xp /lib/libgcc_s-4.5.3.so.1
b6cbe000 b6cc1000 r-xp /usr/lib/libsmack.so.1.0.0
b6cc9000 b6cf5000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6cfe000 b6d02000 r-xp /usr/lib/libbundle.so.0.1.22
b6d0a000 b6d0c000 r-xp /lib/libdl-2.13.so
b6d15000 b6def000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6df8000 b6e62000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e6c000 b6e79000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e82000 b6f68000 r-xp /usr/lib/libX11.so.6.3.0
b6f73000 b6f87000 r-xp /lib/libpthread-2.13.so
b6f92000 b6f93000 r-xp /usr/lib/libdlog.so.0.0.0
b6fa0000 b6fa4000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fad000 b6fb1000 r-xp /usr/lib/libsys-assert.so
b6fb9000 b6fd6000 r-xp /lib/ld-2.13.so
be7f5000 be816000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4864)
Call Stack Count: 26
 0: Tizen::Base::BufferBase::GetCapacity() const + 0x3 (0xb42b9918) [/usr/lib/osp/libosp-appfw.so] + 0x128918
 1: (0xb3a93aa1) [/usr/lib/osp/libosp-uifw.so] + 0x62caa1
 2: Tizen::Graphics::_BitmapImpl::Construct(Tizen::Base::ByteBuffer const&, Tizen::Graphics::Dimension const&, Tizen::Graphics::BitmapPixelFormat, Tizen::Graphics::BufferScaling) + 0x5a (0xb3a95147) [/usr/lib/osp/libosp-uifw.so] + 0x62e147
 3: Tizen::Graphics::Bitmap::Construct(Tizen::Base::ByteBuffer const&, Tizen::Graphics::Dimension const&, Tizen::Graphics::BitmapPixelFormat, Tizen::Graphics::BufferScaling) + 0x32 (0xb3a89263) [/usr/lib/osp/libosp-uifw.so] + 0x622263
 4: Info::SetByteBuffer(Tizen::Base::ByteBuffer*, int, int, Tizen::Graphics::BitmapPixelFormat) + 0x1b4 (0xb26f33c0) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0x53c0
 5: TizenRemoteCamera::GetRemoteImageN() + 0x5fc (0xb26f9f44) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0xbf44
 6: TizenRemoteCamera::OnTimerExpired(Tizen::Base::Runtime::Timer&) + 0x2c (0xb26fa024) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0xc024
 7: non-virtual thunk to TizenRemoteCamera::OnTimerExpired(Tizen::Base::Runtime::Timer&) + 0x2c (0xb26fa0d8) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera.exe] + 0xc0d8
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
