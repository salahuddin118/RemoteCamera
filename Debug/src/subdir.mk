################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/Info.cpp \
../src/InfoCompare.cpp \
../src/RemoteCamera.cpp \
../src/RemoteCameraEntry.cpp \
../src/RemoteCameraForm.cpp \
../src/TizenRemoteCamera.cpp 

OBJS += \
./src/Info.o \
./src/InfoCompare.o \
./src/RemoteCamera.o \
./src/RemoteCameraEntry.o \
./src/RemoteCameraForm.o \
./src/TizenRemoteCamera.o 

CPP_DEPS += \
./src/Info.d \
./src/InfoCompare.d \
./src/RemoteCamera.d \
./src/RemoteCameraEntry.d \
./src/RemoteCameraForm.d \
./src/TizenRemoteCamera.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	clang++.exe -I"pch" -D_DEBUG -I"C:\Users\Md\workspace\RemoteCamera\inc" -O0 -g3 -Wall -c -fmessage-length=0 -target i386-tizen-linux-gnueabi -gcc-toolchain "C:/tizen-sdk/tools/smart-build-interface/../i386-linux-gnueabi-gcc-4.5/" -ccc-gcc-name i386-linux-gnueabi-g++ -march=i386 -Wno-gnu -fPIE --sysroot="C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-emulator-2.2.native" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-emulator-2.2.native/usr/include/libxml2" -I"C:\tizen-sdk\library" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-emulator-2.2.native/usr/include" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-emulator-2.2.native/usr/include/osp" -D_APP_LOG -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


