S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2
Build-Number: Tizen_Ref.Device-ODROID-U3_20150504.1306
Build-Date: 2015.05.04 13:06:30

Crash Information
Process Name: RemoteCamera
PID: 5535
Date: 2016-01-02 00:28:12(GMT+0900)
Executable File Path: /opt/apps/Gxyc5ddxrX/bin/RemoteCamera
This process is multi-thread process
pid=5535 tid=5535
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 5535, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000159f
r2   = 0x00000006, r3   = 0x0000159f
r4   = 0x00000006, r5   = 0xb61f3be4
r6   = 0xb61f3000, r7   = 0x0000010c
r8   = 0x00000be4, r9   = 0x2a082788
r10  = 0xb2855000, fp   = 0xbefe3f78
ip   = 0xb28554c0, sp   = 0xbefe3950
lr   = 0xb60fa55c, pc   = 0xb60f6760
cpsr = 0x28000010

Memory Information
MemTotal:  2059848 KB
MemFree:   1570216 KB
Buffers:     19376 KB
Cached:     175308 KB
VmPeak:      99020 KB
VmSize:      99016 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       38796 KB
VmRSS:       38796 KB
VmData:      15912 KB
VmStk:         172 KB
VmExe:          56 KB
VmLib:       66644 KB
VmPTE:          88 KB
VmSwap:          0 KB

Maps Information
2a000000 2a00e000 r-xp /opt/usr/apps/Gxyc5ddxrX/bin/RemoteCamera.exe
2a016000 2a017000 rwxp /opt/usr/apps/Gxyc5ddxrX/bin/RemoteCamera.exe
2a017000 2a410000 rwxp [heap]
b14f2000 b1876000 rwxs anon_inode:exynos_gem
b1876000 b1bfa000 rwxs anon_inode:exynos_gem
b21c5000 b21ca000 r-xp /usr/lib/libhaptic-module.so
b21d1000 b21d2000 rwxp /usr/lib/libhaptic-module.so
b21d2000 b221d000 rwxs /dev/shm/elm_indicator_portrait-0-946688453.4108.949608920
b221d000 b2248000 rwxs /dev/shm/elm_indicator_landscape-0-946688453.4108.1675746557
b2248000 b2293000 rwxs /dev/shm/elm_indicator_portrait-0-946688453.4108.949608920
b2293000 b22be000 rwxs /dev/shm/elm_indicator_landscape-0-946688453.4108.1675746557
b2304000 b2329000 r-xp /usr/share/fonts/TizenSansMedium.ttf
b2329000 b234e000 r-xp /usr/share/fonts/TizenSansRegular.ttf
b234e000 b2356000 r-xs /var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-3
b2356000 b2359000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2360000 b2361000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2361000 b236b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2372000 b2373000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2373000 b237c000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b2384000 b2385000 rwxp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b2385000 b238f000 r-xp /lib/libnss_files-2.13.so
b2396000 b2397000 r-xp /lib/libnss_files-2.13.so
b2397000 b2398000 rwxp /lib/libnss_files-2.13.so
b2398000 b23a1000 r-xp /lib/libnss_nis-2.13.so
b23a8000 b23a9000 r-xp /lib/libnss_nis-2.13.so
b23a9000 b23aa000 rwxp /lib/libnss_nis-2.13.so
b23aa000 b23bb000 r-xp /lib/libnsl-2.13.so
b23c2000 b23c3000 r-xp /lib/libnsl-2.13.so
b23c3000 b23c4000 rwxp /lib/libnsl-2.13.so
b23c6000 b23cc000 r-xp /lib/libnss_compat-2.13.so
b23d3000 b23d4000 r-xp /lib/libnss_compat-2.13.so
b23d4000 b23d5000 rwxp /lib/libnss_compat-2.13.so
b23d5000 b24a0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b24a8000 b24b6000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b24b8000 b24b9000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b24c0000 b24c1000 rwxp /usr/lib/libdrm_slp.so.1.0.0
b24c1000 b24c8000 r-xs /usr/lib/gconv/gconv-modules.cache
b24c8000 b24ec000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b24f3000 b24f5000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b24f5000 b2614000 r-xp /usr/lib/locale/locale-archive
b2614000 b2654000 r-xp /usr/lib/locale/locale-archive
b2654000 b2854000 r-xp /usr/lib/locale/locale-archive
b285c000 b2896000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b289e000 b289f000 rwxp /usr/lib/libpulsecommon-0.9.23.so
b289f000 b28a3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b28aa000 b28ab000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
b28ac000 b28c0000 r-xp /usr/lib/libnetwork.so.0.0.0
b28c7000 b28c8000 rwxp /usr/lib/libnetwork.so.0.0.0
b28c9000 b28cc000 r-xp /lib/libattr.so.1.1.0
b28d3000 b28d4000 rwxp /lib/libattr.so.1.1.0
b28d4000 b28d7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b28de000 b28df000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
b28e0000 b2911000 r-xp /usr/lib/libpulse.so.0.12.4
b2918000 b2919000 rwxp /usr/lib/libpulse.so.0.12.4
b2919000 b297c000 r-xp /usr/lib/libasound.so.2.0.0
b2983000 b2986000 rwxp /usr/lib/libasound.so.2.0.0
b2986000 b2989000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2990000 b2991000 rwxp /usr/lib/libpulse-simple.so.0.0.3
b2991000 b2995000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b299d000 b299e000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
b299e000 b29bb000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b29c2000 b29c3000 rwxp /usr/lib/libavsysaudio.so.0.0.1
b29c4000 b29d2000 r-xp /usr/lib/libmmfsound.so.0.1.0
b29d9000 b29da000 rwxp /usr/lib/libmmfsound.so.0.1.0
b29da000 b2a76000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b2a7e000 b2a81000 rwxp /usr/lib/libgstreamer-0.10.so.0.30.0
b2a82000 b2ac3000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b2acb000 b2acc000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
b2acc000 b2ad5000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b2adc000 b2add000 rwxp /usr/lib/libgstapp-0.10.so.0.25.0
b2add000 b2aea000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2af2000 b2af3000 rwxp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2af4000 b2b20000 r-xp /usr/lib/libidn.so.11.5.44
b2b28000 b2b29000 rwxp /usr/lib/libidn.so.11.5.44
b2b29000 b2b33000 r-xp /usr/lib/libcares.so.2.0.0
b2b3a000 b2b3b000 rwxp /usr/lib/libcares.so.2.0.0
b2b3b000 b2b3d000 r-xp /usr/lib/libXau.so.6.0.0
b2b44000 b2b45000 rwxp /usr/lib/libXau.so.6.0.0
b2b45000 b2b55000 r-xp /lib/libresolv-2.13.so
b2b55000 b2b56000 r-xp /lib/libresolv-2.13.so
b2b56000 b2b57000 rwxp /lib/libresolv-2.13.so
b2b5a000 b2b5f000 r-xp /usr/lib/libffi.so.5.0.10
b2b66000 b2b67000 rwxp /usr/lib/libffi.so.5.0.10
b2b67000 b2b71000 r-xp /usr/lib/libethumb.so.1.7.99
b2b78000 b2b79000 rwxp /usr/lib/libethumb.so.1.7.99
b2b79000 b2bbd000 r-xp /usr/lib/libsndfile.so.1.0.25
b2bc5000 b2bc7000 rwxp /usr/lib/libsndfile.so.1.0.25
b2bcb000 b2bcd000 r-xp /usr/lib/libctxdata.so.0.0.0
b2bd4000 b2bd5000 rwxp /usr/lib/libctxdata.so.0.0.0
b2bd6000 b2be4000 r-xp /usr/lib/libremix.so.0.0.0
b2beb000 b2bec000 rwxp /usr/lib/libremix.so.0.0.0
b2bec000 b2bf3000 r-xp /usr/lib/libembryo.so.1.7.99
b2bfb000 b2bfc000 rwxp /usr/lib/libembryo.so.1.7.99
b2bfc000 b2c20000 r-xp /usr/lib/libjpeg.so.8.0.2
b2c27000 b2c28000 rwxp /usr/lib/libjpeg.so.8.0.2
b2c38000 b2c3a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b2c41000 b2c42000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b2c42000 b2c45000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2c4c000 b2c4d000 rwxp /usr/lib/libmm_ta.so.0.0.0
b2c4e000 b2c5d000 r-xp /usr/lib/libICE.so.6.3.0
b2c64000 b2c65000 rwxp /usr/lib/libICE.so.6.3.0
b2c67000 b2c6c000 r-xp /usr/lib/libSM.so.6.0.1
b2c73000 b2c74000 rwxp /usr/lib/libSM.so.6.0.1
b2c74000 b2c88000 r-xp /usr/lib/libwifi-direct.so.0.0
b2c8f000 b2c90000 rwxp /usr/lib/libwifi-direct.so.0.0
b2c90000 b2c98000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2c98000 b2c99000 rwxp /usr/lib/libcapi-network-tethering.so.0.1.0
b2c99000 b2ca2000 r-xp /usr/lib/libcapi-network-connection.so.0.1.3_18
b2ca9000 b2caa000 rwxp /usr/lib/libcapi-network-connection.so.0.1.3_18
b2cab000 b2cb3000 r-xp /lib/libcrypt-2.13.so
b2cba000 b2cbb000 r-xp /lib/libcrypt-2.13.so
b2cbb000 b2cbc000 rwxp /lib/libcrypt-2.13.so
b2ce3000 b2ce6000 r-xp /lib/libcap.so.2.21
b2ced000 b2cee000 rwxp /lib/libcap.so.2.21
b2cee000 b2cf0000 r-xp /usr/lib/libiri.so
b2cf7000 b2cf8000 rwxp /usr/lib/libiri.so
b2cf8000 b2d09000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b2d11000 b2d12000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b2d12000 b2d14000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b2d1b000 b2d1c000 rwxp /usr/lib/libsystemd-daemon.so.0.0.1
b2d1d000 b2d1e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b2d25000 b2d26000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b2d26000 b2d28000 r-xp /usr/lib/libdeviced.so.0.1.0
b2d2f000 b2d30000 rwxp /usr/lib/libdeviced.so.0.1.0
b2d30000 b2d46000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b2d4d000 b2d4e000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b2d4f000 b2d51000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2d58000 b2d59000 rwxp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2d59000 b2d5c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2d63000 b2d64000 rwxp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2d64000 b2d75000 r-xp /usr/lib/libcom-core.so.0.0.1
b2d7c000 b2d7d000 rwxp /usr/lib/libcom-core.so.0.0.1
b2d7d000 b2d80000 r-xp /usr/lib/libdevice-node.so.0.1
b2d87000 b2d88000 rwxp /usr/lib/libdevice-node.so.0.1
b2d89000 b2d8d000 r-xp /usr/lib/libheynoti.so.0.0.2
b2d94000 b2d95000 rwxp /usr/lib/libheynoti.so.0.0.2
b2d95000 b2d97000 r-xp /usr/lib/libapp-checker.so.0.1.0
b2d9e000 b2d9f000 rwxp /usr/lib/libapp-checker.so.0.1.0
b2d9f000 b2da2000 r-xp /usr/lib/libsmack.so.1.0.0
b2da9000 b2daa000 rwxp /usr/lib/libsmack.so.1.0.0
b2daa000 b2df6000 r-xp /usr/lib/libssl.so.1.0.0
b2dfd000 b2e02000 rwxp /usr/lib/libssl.so.1.0.0
b2e03000 b2e04000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2e0b000 b2e0c000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b2e0c000 b2e14000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2e1b000 b2e1c000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b2e1c000 b2e20000 r-xp /usr/lib/libsysman.so.0.2.0
b2e27000 b2e28000 rwxp /usr/lib/libsysman.so.0.2.0
b2e28000 b2e30000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b2e37000 b2e38000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
b2e3b000 b2e3e000 r-xp /usr/lib/libmmfsession.so.0.0.0
b2e45000 b2e46000 rwxp /usr/lib/libmmfsession.so.0.0.0
b2e47000 b2e8b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b2e92000 b2e94000 rwxp /usr/lib/libmmfplayer.so.0.0.0
b2e94000 b2e9a000 r-xp /usr/lib/libUMP.so
b2ea1000 b2ea2000 rwxp /usr/lib/libUMP.so
b2ea2000 b2ec6000 r-xp /usr/lib/libicule.so.48.1
b2ece000 b2ecf000 rwxp /usr/lib/libicule.so.48.1
b2ecf000 b2ed5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2edc000 b2edd000 rwxp /usr/lib/libxcb-render.so.0.0.0
b2edd000 b2ede000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2ee6000 b2ee7000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b2ee8000 b2eff000 r-xp /lib/libexpat.so.1.5.2
b2f07000 b2f09000 rwxp /lib/libexpat.so.1.5.2
b2f09000 b2f0c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b2f13000 b2f14000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b2f14000 b2f51000 r-xp /usr/lib/libcurl.so.4.3.0
b2f59000 b2f5b000 rwxp /usr/lib/libcurl.so.4.3.0
b2f5b000 b2f5f000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b2f67000 b2f68000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b2f69000 b2f6f000 r-xp /usr/lib/libXrender.so.1.3.0
b2f76000 b2f77000 rwxp /usr/lib/libXrender.so.1.3.0
b2f77000 b2f7d000 r-xp /usr/lib/libXrandr.so.2.2.0
b2f84000 b2f85000 rwxp /usr/lib/libXrandr.so.2.2.0
b2f85000 b2f86000 r-xp /usr/lib/libXinerama.so.1.0.0
b2f8e000 b2f8f000 rwxp /usr/lib/libXinerama.so.1.0.0
b2f8f000 b2f98000 r-xp /usr/lib/libXi.so.6.1.0
b2f9f000 b2fa0000 rwxp /usr/lib/libXi.so.6.1.0
b2fa0000 b2fa2000 r-xp /usr/lib/libXgesture.so.7.0.0
b2fa9000 b2faa000 rwxp /usr/lib/libXgesture.so.7.0.0
b2faa000 b2fac000 r-xp /usr/lib/libXcomposite.so.1.0.0
b2fb3000 b2fb4000 rwxp /usr/lib/libXcomposite.so.1.0.0
b2fb5000 b2fbc000 r-xp /usr/lib/libXcursor.so.1.0.2
b2fc3000 b2fc4000 rwxp /usr/lib/libXcursor.so.1.0.2
b2fc4000 b2fc7000 r-xp /usr/lib/libXfixes.so.3.1.0
b2fce000 b2fcf000 rwxp /usr/lib/libXfixes.so.3.1.0
b2fcf000 b2fe4000 r-xp /usr/lib/libxcb.so.1.1.0
b2feb000 b2fec000 rwxp /usr/lib/libxcb.so.1.1.0
b2fec000 b2ff4000 r-xp /usr/lib/libemotion.so.1.7.99
b2ffb000 b2ffc000 rwxp /usr/lib/libemotion.so.1.7.99
b2ffc000 b3001000 r-xp /usr/lib/libecore_fb.so.1.7.99
b3008000 b300a000 rwxp /usr/lib/libecore_fb.so.1.7.99
b300b000 b3013000 r-xp /usr/lib/libsf_common.so
b301a000 b301b000 rwxp /usr/lib/libsf_common.so
b301b000 b30f8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b30ff000 b3102000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b3103000 b3148000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b314f000 b3151000 rwxp /usr/lib/libsoup-2.4.so.1.5.0
b3151000 b3185000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b318c000 b318e000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b318e000 b31a9000 r-xp /usr/lib/libecore_con.so.1.7.99
b31b0000 b31b1000 rwxp /usr/lib/libecore_con.so.1.7.99
b31b3000 b31bb000 r-xp /usr/lib/libethumb_client.so.1.7.99
b31c2000 b31c3000 rwxp /usr/lib/libethumb_client.so.1.7.99
b31c3000 b31cc000 r-xp /usr/lib/libedbus.so.1.7.99
b31d3000 b31d4000 rwxp /usr/lib/libedbus.so.1.7.99
b31d4000 b31d6000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b31dd000 b31de000 rwxp /usr/lib/libefreet_trash.so.1.7.99
b31de000 b31e2000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b31ea000 b31eb000 rwxp /usr/lib/libefreet_mime.so.1.7.99
b31eb000 b3201000 r-xp /usr/lib/libefreet.so.1.7.99
b3209000 b320a000 rwxp /usr/lib/libefreet.so.1.7.99
b320c000 b3268000 r-xp /usr/lib/libedje.so.1.7.99
b3270000 b3272000 rwxp /usr/lib/libedje.so.1.7.99
b3272000 b3277000 r-xp /usr/lib/libecore_file.so.1.7.99
b327e000 b327f000 rwxp /usr/lib/libecore_file.so.1.7.99
b327f000 b3292000 r-xp /usr/lib/libeet.so.1.7.99
b329a000 b329b000 rwxp /usr/lib/libeet.so.1.7.99
b329b000 b43a2000 r-xp /usr/lib/libicudata.so.48.1
b43a9000 b43aa000 rwxp /usr/lib/libicudata.so.48.1
b43aa000 b43ad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b43b4000 b43b5000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b43b5000 b43bb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b43c2000 b43c3000 rwxp /usr/lib/libxdgmime.so.1.1.0
b43c4000 b43d2000 r-xp /usr/lib/libail.so.0.1.0
b43d9000 b43da000 rwxp /usr/lib/libail.so.0.1.0
b43da000 b43ff000 r-xp /usr/lib/libexif.so.12.3.3
b4406000 b4413000 rwxp /usr/lib/libexif.so.12.3.3
b4413000 b445e000 r-xp /usr/lib/libtiff.so.5.1.0
b4466000 b4469000 rwxp /usr/lib/libtiff.so.5.1.0
b4469000 b4492000 r-xp /usr/lib/libturbojpeg.so
b449a000 b449b000 rwxp /usr/lib/libturbojpeg.so
b44ab000 b44b1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b44b8000 b44b9000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b44ba000 b44c0000 r-xp /usr/lib/libgif.so.4.1.6
b44c7000 b44c8000 rwxp /usr/lib/libgif.so.4.1.6
b44c8000 b44ea000 r-xp /usr/lib/libavutil.so.51.73.101
b44f2000 b44f5000 rwxp /usr/lib/libavutil.so.51.73.101
b44f9000 b4527000 r-xp /usr/lib/libswscale.so.2.1.101
b452f000 b4530000 rwxp /usr/lib/libswscale.so.2.1.101
b4530000 b4827000 r-xp /usr/lib/libavcodec.so.54.59.100
b482f000 b483f000 rwxp /usr/lib/libavcodec.so.54.59.100
b4b4e000 b4b67000 r-xp /usr/lib/libpng12.so.0.50.0
b4b6f000 b4b70000 rwxp /usr/lib/libpng12.so.0.50.0
b4b71000 b4d8e000 r-xp /usr/lib/libface-engine-plugin.so
b4d95000 b4de4000 rwxp /usr/lib/libface-engine-plugin.so
b4dec000 b4eb1000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b4eb9000 b4ebf000 rwxp /usr/lib/osp/libosp-net.so.1.2.2.0
b4ebf000 b4ecc000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b4ed4000 b4ed5000 rwxp /usr/lib/libprivilege-control.so.0.0.2
b4ed5000 b5028000 r-xp /usr/lib/libcrypto.so.1.0.0
b5030000 b5043000 rwxp /usr/lib/libcrypto.so.1.0.0
b5046000 b505b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b5063000 b5064000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b5065000 b5069000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b5070000 b5071000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b5071000 b5076000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b507d000 b507e000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
b507e000 b507f000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b5087000 b5088000 rwxp /usr/lib/libcapi-system-power.so.0.1.1
b5088000 b508b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b5092000 b5093000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
b5093000 b5096000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b509d000 b509e000 rwxp /usr/lib/libcapi-network-serial.so.0.0.8
b509e000 b509f000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b50a6000 b50a7000 rwxp /usr/lib/libcapi-content-mime-type.so.0.0.2
b50a8000 b50ca000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b50d1000 b50d2000 rwxp /usr/lib/libSLP-tapi.so.0.0.0
b50d2000 b50e9000 r-xp /lib/libz.so.1.2.5
b50f0000 b50f1000 rwxp /lib/libz.so.1.2.5
b50f1000 b50f4000 r-xp /usr/lib/libuuid.so.1.3.0
b50fc000 b50fd000 rwxp /usr/lib/libuuid.so.1.3.0
b50fd000 b5167000 r-xp /usr/lib/libsqlite3.so.0.8.6
b516e000 b5170000 rwxp /usr/lib/libsqlite3.so.0.8.6
b5171000 b518f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b5196000 b5197000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b5198000 b51c4000 r-xp /usr/lib/libdbus-1.so.3.7.2
b51cc000 b51cd000 rwxp /usr/lib/libdbus-1.so.3.7.2
b51cd000 b51e5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b51e5000 b51e6000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b51e6000 b51e7000 r-xp /usr/lib/libdlog.so.0.0.0
b51ee000 b51ef000 rwxp /usr/lib/libdlog.so.0.0.0
b51ef000 b5206000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b520e000 b520f000 rwxp /usr/lib/libpkgmgr-client.so.0.1.68
b520f000 b5210000 r-xp /usr/lib/libpmapi.so.1.2
b5217000 b5218000 rwxp /usr/lib/libpmapi.so.1.2
b5218000 b521c000 r-xp /usr/lib/libbundle.so.0.1.22
b5223000 b5224000 rwxp /usr/lib/libbundle.so.0.1.22
b5225000 b5235000 r-xp /usr/lib/libnotification.so.0.1.0
b523c000 b523d000 rwxp /usr/lib/libnotification.so.0.1.0
b523d000 b5245000 r-xp /usr/lib/libminizip.so.1.0.0
b524c000 b524d000 rwxp /usr/lib/libminizip.so.1.0.0
b524d000 b5258000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b525f000 b5260000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b5260000 b527e000 r-xp /usr/lib/libpcre.so.0.0.1
b5285000 b5286000 rwxp /usr/lib/libpcre.so.0.0.1
b5286000 b5289000 r-xp /usr/lib/libiniparser.so.0
b5290000 b5291000 rwxp /usr/lib/libiniparser.so.0
b5292000 b537a000 r-xp /usr/lib/libicuuc.so.48.1
b537a000 b5385000 rwxp /usr/lib/libicuuc.so.48.1
b5388000 b54a8000 r-xp /usr/lib/libicui18n.so.48.1
b54af000 b54b5000 rwxp /usr/lib/libicui18n.so.48.1
b54b6000 b54ba000 r-xp /usr/lib/libhaptic.so.0.1
b54c1000 b54c2000 rwxp /usr/lib/libhaptic.so.0.1
b54c2000 b54cd000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b54d5000 b54d6000 rwxp /usr/lib/libcryptsvc.so.0.0.1
b54da000 b54df000 r-xp /usr/lib/libdevman.so.0.1
b54e7000 b54e8000 rwxp /usr/lib/libdevman.so.0.1
b54e8000 b54f3000 r-xp /usr/lib/libaul.so.0.1.0
b54fb000 b54fc000 rwxp /usr/lib/libaul.so.0.1.0
b54fd000 b54fe000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b5505000 b5506000 rwxp /usr/lib/osp/libappinfo.so.1.2.2.1
b5506000 b550c000 r-xp /usr/lib/libalarm.so.0.0.0
b5514000 b5515000 rwxp /usr/lib/libalarm.so.0.0.0
b5515000 b551e000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b5526000 b5527000 rwxp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b5527000 b5539000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b5540000 b5541000 rwxp /usr/lib/libprivacy-manager-client.so.0.0.5
b5541000 b5547000 r-xp /lib/librt-2.13.so
b554e000 b554f000 r-xp /lib/librt-2.13.so
b554f000 b5550000 rwxp /lib/librt-2.13.so
b5551000 b55bb000 r-xp /lib/libm-2.13.so
b55c2000 b55c3000 r-xp /lib/libm-2.13.so
b55c3000 b55c4000 rwxp /lib/libm-2.13.so
b55c4000 b55c8000 r-xp /usr/lib/libchromium.so.1.0
b55cf000 b55d0000 rwxp /usr/lib/libchromium.so.1.0
b55d0000 b55d3000 r-xp /usr/lib/libXtst.so.6.1.0
b55da000 b55db000 rwxp /usr/lib/libXtst.so.6.1.0
b55db000 b55e2000 r-xp /usr/lib/libutilX.so.1.1.0
b55e9000 b55ea000 rwxp /usr/lib/libutilX.so.1.1.0
b55ea000 b55ed000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b55f5000 b55f6000 rwxp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b55f6000 b560f000 r-xp /usr/lib/liblua-5.1.so
b5617000 b5618000 rwxp /usr/lib/liblua-5.1.so
b5619000 b561d000 r-xp /usr/lib/libtbm.so.1.0.0
b5624000 b5625000 rwxp /usr/lib/libtbm.so.1.0.0
b5625000 b562d000 r-xp /usr/lib/libdrm.so.2.4.0
b5634000 b5635000 rwxp /usr/lib/libdrm.so.2.4.0
b5635000 b5637000 r-xp /usr/lib/libdri2.so.0.0.0
b563e000 b563f000 rwxp /usr/lib/libdri2.so.0.0.0
b563f000 b5645000 r-xp /usr/lib/libfeedback.so.0.1.4
b564c000 b564d000 rwxp /usr/lib/libfeedback.so.0.1.4
b564d000 b5659000 r-xp /usr/lib/libtts.so
b5660000 b5661000 rwxp /usr/lib/libtts.so
b5661000 b5664000 r-xp /usr/lib/libXv.so.1.0.0
b566b000 b566c000 rwxp /usr/lib/libXv.so.1.0.0
b566d000 b57aa000 r-xp /usr/lib/libMali.so
b57b2000 b57b7000 rwxp /usr/lib/libMali.so
b57b7000 b57c1000 r-xp /usr/lib/libXext.so.6.4.0
b57c9000 b57ca000 rwxp /usr/lib/libXext.so.6.4.0
b57ca000 b5826000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b582e000 b5838000 rwxp /usr/lib/libharfbuzz.so.0.907.0
b5838000 b584c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5853000 b5854000 rwxp /usr/lib/libfribidi.so.0.3.1
b5854000 b58a9000 r-xp /usr/lib/libfreetype.so.6.8.1
b58b0000 b58b4000 rwxp /usr/lib/libfreetype.so.6.8.1
b58b4000 b598e000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b5996000 b5997000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b5998000 b5a02000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5a0a000 b5a0f000 rwxp /usr/lib/libpixman-1.so.0.28.2
b5a0f000 b5ac6000 r-xp /usr/lib/libcairo.so.2.11200.12
b5acd000 b5ad0000 rwxp /usr/lib/libcairo.so.2.11200.12
b5ad0000 b5af4000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5afb000 b5afd000 rwxp /usr/lib/libfontconfig.so.1.5.0
b5afd000 b5bd5000 r-xp /usr/lib/libxml2.so.2.7.8
b5bdc000 b5be2000 rwxp /usr/lib/libxml2.so.2.7.8
b5be2000 b5bf9000 r-xp /usr/lib/libecore_input.so.1.7.99
b5c00000 b5c14000 rwxp /usr/lib/libecore_input.so.1.7.99
b5c14000 b5c15000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5c1c000 b5c1d000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5c1e000 b5c23000 r-xp /usr/lib/libecore_imf.so.1.7.99
b5c2b000 b5c2c000 rwxp /usr/lib/libecore_imf.so.1.7.99
b5c2c000 b5c5c000 r-xp /usr/lib/libecore_x.so.1.7.99
b5c63000 b5c65000 rwxp /usr/lib/libecore_x.so.1.7.99
b5c65000 b5c82000 r-xp /usr/lib/libecore_evas.so.1.7.99
b5c89000 b5c8b000 rwxp /usr/lib/libecore_evas.so.1.7.99
b5c8b000 b5cca000 r-xp /usr/lib/libeina.so.1.7.99
b5cd1000 b5cd3000 rwxp /usr/lib/libeina.so.1.7.99
b5cd3000 b5d82000 r-xp /usr/lib/libevas.so.1.7.99
b5d8a000 b5d92000 rwxp /usr/lib/libevas.so.1.7.99
b5da5000 b5dba000 r-xp /usr/lib/libecore.so.1.7.99
b5dc2000 b5dc3000 rwxp /usr/lib/libecore.so.1.7.99
b5dd1000 b5dda000 r-xp /usr/lib/libvconf.so.0.2.45
b5de1000 b5de2000 rwxp /usr/lib/libvconf.so.0.2.45
b5de2000 b5de3000 r-xp /usr/lib/libXdamage.so.1.1.0
b5deb000 b5dec000 rwxp /usr/lib/libXdamage.so.1.1.0
b5dec000 b5ed2000 r-xp /usr/lib/libX11.so.6.3.0
b5ed9000 b5edd000 rwxp /usr/lib/libX11.so.6.3.0
b5edd000 b5ffd000 r-xp /usr/lib/libelementary.so.1.7.99
b6004000 b600b000 rwxp /usr/lib/libelementary.so.1.7.99
b600f000 b601c000 r-xp /usr/lib/libsensor.so.1.1.0
b6024000 b6025000 rwxp /usr/lib/libsensor.so.1.1.0
b6027000 b602d000 r-xp /usr/lib/libappsvc.so.0.1.0
b6034000 b6035000 rwxp /usr/lib/libappsvc.so.0.1.0
b6035000 b6039000 r-xp /usr/lib/libappcore-efl.so.1.1
b6040000 b6041000 rwxp /usr/lib/libappcore-efl.so.1.1
b6041000 b6046000 r-xp /usr/lib/libappcore-common.so.1.1
b604d000 b604e000 rwxp /usr/lib/libappcore-common.so.1.1
b604e000 b605c000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b6063000 b6064000 rwxp /usr/lib/libcapi-appfw-application.so.0.1.0
b6065000 b607f000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b6087000 b6088000 rwxp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b6088000 b608a000 r-xp /lib/libdl-2.13.so
b6091000 b6092000 r-xp /lib/libdl-2.13.so
b6092000 b6093000 rwxp /lib/libdl-2.13.so
b6093000 b609e000 r-xp /lib/libunwind.so.8.0.1
b60a6000 b60a7000 rwxp /lib/libunwind.so.8.0.1
b60cc000 b61e9000 r-xp /lib/libc-2.13.so
b61f1000 b61f3000 r-xp /lib/libc-2.13.so
b61f3000 b61f4000 rwxp /lib/libc-2.13.so
b61f7000 b6200000 r-xp /lib/libgcc_s-4.5.3.so.1
b6207000 b6208000 rwxp /lib/libgcc_s-4.5.3.so.1
b6208000 b62a3000 r-xp /usr/lib/libstdc++.so.6.0.14
b62ab000 b62ae000 r-xp /usr/lib/libstdc++.so.6.0.14
b62ae000 b62b0000 rwxp /usr/lib/libstdc++.so.6.0.14
b62b6000 b62d9000 r-xp /usr/lib/osp/libosp-face.so.1.2.2.0
b62e1000 b62e3000 rwxp /usr/lib/osp/libosp-face.so.1.2.2.0
b62e3000 b6300000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b6308000 b6309000 rwxp /usr/lib/osp/libosp-image.so.1.2.2.0
b6309000 b6608000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b6610000 b662e000 rwxp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b662f000 b6f2a000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6f31000 b6f9a000 rwxp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6f9d000 b6fb1000 r-xp /lib/libpthread-2.13.so
b6fb8000 b6fb9000 r-xp /lib/libpthread-2.13.so
b6fb9000 b6fba000 rwxp /lib/libpthread-2.13.so
b6fbd000 b6fbe000 r-xs /var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-3
b6fbe000 b6fbf000 r-xp /usr/share/locale/en_GB/LC_MESSAGES/libc.mo
b6fbf000 b6fc0000 r-xp /usr/lib/locale/locale-archive
b6fc0000 b6fc1000 r-xp /usr/lib/locale/locale-archive
b6fc1000 b6fc6000 r-xp /usr/lib/libslp_devman_plugin.so
b6fcd000 b6fce000 rwxp /usr/lib/libslp_devman_plugin.so
b6fce000 b6fd2000 r-xp /usr/lib/libsys-assert.so
b6fd9000 b6fda000 rwxp /usr/lib/libsys-assert.so
b6fda000 b6ff7000 r-xp /lib/ld-2.13.so
b6ffe000 b6fff000 r-xp /lib/ld-2.13.so
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
befdf000 bf000000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5535)
Call Stack Count: 25
 0: gsignal + 0x3c (0xb60f6760) [/lib/libc.so.6] + 0x2a760
 1: abort + 0x1ac (0xb60fa55c) [/lib/libc.so.6] + 0x2e55c
 2: __assert_fail + 0x10c (0xb60ef63c) [/lib/libc.so.6] + 0x2363c
 3: SysAssertfInternal + 0x82 (0xb643bcef) [/usr/lib/osp/libosp-appfw.so.1] + 0x132cef
 4: Tizen::Graphics::Bitmap::Construct(Tizen::Base::ByteBuffer const&, Tizen::Graphics::Dimension const&, Tizen::Graphics::BitmapPixelFormat, Tizen::Graphics::BufferScaling) + 0x9e (0xb6c512cf) [/usr/lib/osp/libosp-uifw.so.1] + 0x6222cf
 5: (0x2a0053c0) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera] + 0x53c0
 6: (0x2a00bbd4) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera] + 0xbbd4
 7: (0x2a00bcd4) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera] + 0xbcd4
 8: (0x2a00bd88) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera] + 0xbd88
 9: (0xb646ddd9) [/usr/lib/osp/libosp-appfw.so.1] + 0x164dd9
10: g_io_unix_dispatch + 0x2a (0xb5918783) [/usr/lib/libglib-2.0.so.0] + 0x64783
11: g_main_context_dispatch + 0xce (0xb58eca37) [/usr/lib/libglib-2.0.so.0] + 0x38a37
12: _ecore_glib_select + 0x3ae (0xb5db4337) [/usr/lib/libecore.so.1] + 0xf337
13: _ecore_main_select + 0x294 (0xb5daf8b9) [/usr/lib/libecore.so.1] + 0xa8b9
14: _ecore_main_loop_iterate_internal + 0x2de (0xb5db02f3) [/usr/lib/libecore.so.1] + 0xb2f3
15: ecore_main_loop_begin + 0x30 (0xb5db05cd) [/usr/lib/libecore.so.1] + 0xb5cd
16: elm_run + 0x6 (0xb5f8519f) [/usr/lib/libelementary.so.1] + 0xa819f
17: appcore_efl_main + 0x2d4 (0xb60377d5) [/usr/lib/libappcore-efl.so.1] + 0x27d5
18: app_efl_main + 0xc6 (0xb60566c7) [/usr/lib/libcapi-appfw-application.so.0] + 0x86c7
19: Tizen::App::_AppImpl::Execute(Tizen::App::_IAppImpl*) + 0xe6 (0xb63f68b3) [/usr/lib/osp/libosp-appfw.so.1] + 0xed8b3
20: Tizen::App::UiApp::Execute(Tizen::App::UiApp* (*)(), Tizen::Base::Collection::IList const*) + 0x64 (0xb6cda1f9) [/usr/lib/osp/libosp-uifw.so.1] + 0x6ab1f9
21: OspMain + 0x1c4 (0x2a0074d8) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera] + 0x74d8
22: main + 0x3c6 (0xb640f4df) [/usr/lib/osp/libosp-appfw.so.1] + 0x1064df
23: __libc_start_main + 0x114 (0xb60e16e8) [/lib/libc.so.6] + 0x156e8
24: (0x2a00433c) [/opt/apps/Gxyc5ddxrX/bin/RemoteCamera] + 0x433c
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
