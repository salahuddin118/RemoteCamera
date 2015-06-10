/*
 * TizenRemoteCamera.cpp
 *
 *  Created on: Jun 6, 2015
 *      Author: Salahuddin
 */

#include "TizenRemoteCamera.h"
#include <FSystem.h>
#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
#include <sys/stat.h>
#include <sys/types.h>

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Graphics;
using namespace Tizen::Media;
using namespace Tizen::Base::Runtime;
using namespace Tizen::Base::Collection;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Uix::Vision;
using namespace Tizen::Io;
using namespace Tizen::System;

//#include <dbus/dbus.h>
//#include "glib.h"


static const BitmapPixelFormat DECODEDFORMAT = BITMAP_PIXEL_FORMAT_RGB565;
static const BitmapPixelFormat DECODEDFORMAT1 = BITMAP_PIXEL_FORMAT_R8G8B8A8;
//static const BitmapPixelFormat DECODEDFORMAT1 = BITMAP_PIXEL_FORMAT_R8G8B8A8;

static const wchar_t* PICTURE1 = L"sample1.png";
static const wchar_t* PICTURE2 = L"sample2.png";
static const wchar_t* PICTURE3 = L"sample3.png";
static const wchar_t* PICTURE4 = L"sample4.png";
static const wchar_t* PICTURE5 = L"1433755762058.png";
static const wchar_t* PICTURE6 = L"_1433829041898.png";

static const wchar_t* PICTURE1_PATH = L"res/sample1.png";
static const wchar_t* PICTURE2_PATH = L"res/sample2.png";
static const wchar_t* PICTURE3_PATH = L"res/sample3.png";
static const wchar_t* PICTURE4_PATH = L"res/sample4.png";
static const wchar_t* PICTURE5_PATH = L"res/1433755762058.png";
//static const wchar_t* PICTURE5_PATH = L"res/1433761221619.png";
static const wchar_t* PICTURE6_PATH = L"res/_1433829041898.png";

static const wchar_t* PICTURE_NAME = L"Unknown";

static const int FPS = 50;
static const int INTERVAL = 1000/FPS;
static const int TIMER_START = 200;
static const int TIMER_STOP = 202;

static String dstPath = Tizen::App::App::GetInstance()->GetAppRootPath() + L"data/test_out.jpg";

TizenRemoteCamera::TizenRemoteCamera(void)
	: __imageCount(0)
	, __stat(0)
	, __count(0)
	, __pPicture(null)
	, __pTimer(null)
	, __pInfoList(null)
{
}

TizenRemoteCamera::~TizenRemoteCamera(void)
{
	delete __pPicture;
	__pPicture = null;
	delete __pInfoList;
	__pInfoList = null;
	delete __pTimer;
	 __pTimer = null;
}

void
TizenRemoteCamera::Initialize()
{
	int width = 0;
	int height = 0;
	// Init
	__pPicture = new (std::nothrow) Info(PICTURE1, PICTURE_NAME);
	ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE1_PATH, width, height);
	__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);

	// Create Timer
	__pTimer = new (std::nothrow) Timer();
	__pTimer->Construct(*this);
	GetRemoteImage();
}

const Bitmap*
TizenRemoteCamera::GetBitmap(void) const
{
	if(__stat == TIMER_START)
		return __pPicture->GetBitmap();
	else
		return null;
}

ByteBuffer*
TizenRemoteCamera::LoadImageN(String FileName, int& nWidth, int& nHeight)
{
	result r = E_SUCCESS;

	Image* pImage = new (std::nothrow) Image();
	TryReturn(pImage != null, null, "Failed to create Image");
	r = pImage->Construct();
	TryReturn(r == E_SUCCESS, null, "Failed to construct Image");

	ByteBuffer* pByteBuffer = null;
	pByteBuffer = pImage->DecodeToBufferN(FileName, DECODEDFORMAT, nWidth, nHeight);

	delete pImage;

	return pByteBuffer;
}

ByteBuffer*
TizenRemoteCamera::LoadImageNRaw(String FileName, int& nWidth, int& nHeight)
{
	result r = E_SUCCESS;

	int BUFFER_SIZE = 2764800;
	ByteBuffer* pByteBuffer = new (std::nothrow) ByteBuffer();
	File file;
	int readCnt;
	byte bufferImg[BUFFER_SIZE];

	Image* pImage = new (std::nothrow) Image();
	TryReturn(pImage != null, null, "Failed to create Image");
	r = pImage->Construct();
	TryReturn(r == E_SUCCESS, null, "Failed to construct Image");

	//ByteBuffer* pByteBuffer = null;
	//pByteBuffer = pImage->DecodeToBufferN(FileName, DECODEDFORMAT1, nWidth, nHeight);
	nWidth = 960;
	nHeight = 720;

	pByteBuffer->Construct(BUFFER_SIZE);
	file.Construct(FileName, "r");
	readCnt = file.Read(bufferImg, BUFFER_SIZE);
	pByteBuffer->SetArray(bufferImg, 0, BUFFER_SIZE);
	TryReturn(readCnt == BUFFER_SIZE, null, "Failed to read Image");

	delete pImage;

	return pByteBuffer;
}

ByteBuffer*
TizenRemoteCamera::LoadImageNPNG(String FileName, int& nWidth, int& nHeight)
{
	result r = E_SUCCESS;
	// Read first 4 bytes to get the size
	int BUFFER_SIZE = 98851;
	ByteBuffer* pByteBuffer = new (std::nothrow) ByteBuffer();
	File file;
	int readCnt;
	byte bufferImg[BUFFER_SIZE];

	Image* pImage = new (std::nothrow) Image();
	TryReturn(pImage != null, null, "Failed to create Image");
	r = pImage->Construct();
	TryReturn(r == E_SUCCESS, null, "Failed to construct Image");

	//ByteBuffer* pByteBuffer = null;
	//pByteBuffer = pImage->DecodeToBufferN(FileName, DECODEDFORMAT1, nWidth, nHeight);
	nWidth = 320;
	nHeight = 180;

	pByteBuffer->Construct(BUFFER_SIZE);
	file.Construct(FileName, "r");
	readCnt = file.Read(bufferImg, BUFFER_SIZE);
	pByteBuffer->SetArray(bufferImg, 0, BUFFER_SIZE);
	TryReturn(readCnt == BUFFER_SIZE, null, "Failed to read Image");

	ByteBuffer* pByteBuffer1 = null;
	pByteBuffer1 = pImage->DecodeToBufferN(*pByteBuffer, IMG_FORMAT_PNG, DECODEDFORMAT, nWidth, nHeight);

	delete pImage;

	return pByteBuffer1;
}

void
TizenRemoteCamera::GetRemoteImage(void)
{
	int width = 0;
	int height = 0;
	result r = E_SUCCESS;

	switch(__count%6)
	{
		case 0:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE1, PICTURE_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE1_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
			}
			break;

		case 1:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE2, PICTURE_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE2_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
			}
			break;

		case 2:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE3, PICTURE_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE3_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
			}
			break;

		case 3:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE4, PICTURE_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE4_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
			}
			break;

//		case 4:
//			if (__pPicture->GetBitmap() != null)
//			{
//				delete __pPicture;
//				__pPicture = null;
//				__pPicture = new (std::nothrow) Info(PICTURE5, PICTURE_NAME);
//				TryReturn(r == E_SUCCESS, , "Failed to construct image");
//				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE5_PATH, width, height);
//				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
//			}
//			break;

		case 4:
			if (__pPicture->GetBitmap() != null)
			{
				//width = 960;
				//height = 720;
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE5, PICTURE_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageNRaw(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE5_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT1);

//				Image img;
//				img.Construct();
//				ByteBuffer* pByteBuffer1 = img.EncodeToBufferN(*__pPicture->GetBitmap(), IMG_FORMAT_BMP);
//				delete __pPicture;
//				__pPicture = null;
//				__pPicture = new (std::nothrow) Info(PICTURE5, PICTURE_NAME);
//				TryReturn(r == E_SUCCESS, , "Failed to construct image");
//				__pPicture->SetByteBuffer(pByteBuffer1, width, height, DECODEDFORMAT);
			}
			break;

		case 5:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE6, PICTURE_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageNPNG(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE6_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);

//				Image img;
//				img.Construct();
//				ByteBuffer* pByteBuffer1 = img.EncodeToBufferN(*__pPicture->GetBitmap(), IMG_FORMAT_BMP);
//				delete __pPicture;
//				__pPicture = null;
//				__pPicture = new (std::nothrow) Info(PICTURE5, PICTURE_NAME);
//				TryReturn(r == E_SUCCESS, , "Failed to construct image");
//				__pPicture->SetByteBuffer(pByteBuffer1, width, height, DECODEDFORMAT);
			}
			break;
	}

	AppLog("Timer: GetRemoteImage: %d", __count++);
	return;
}

//void
//TizenRemoteCamera::GetRemoteImageN(void)
//{
//	//	char buf[512];
//	//	FILE *fp_rcMem = NULL;
//	//	fp_rcMem = fopen("/dev/rc_mem", "r");
//	//
//	//	fread(buf, 1, sizeof(buf), fp_rcMem);
//	//
//	//	fclose(fp_rcMem);
//
//	delete __pPicture;
//	__pPicture = null;
//	__pPicture = new (std::nothrow) Info(PICTURE6, PICTURE_NAME);
////	TryReturn(r == E_SUCCESS, , "Failed to construct image");
//	//ByteBuffer* pByteBuffer = LoadImageNPNG(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE6_PATH, width, height);
//	String pngPath = Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE6_PATH;
//
//	result r = E_SUCCESS;
//	// Read first 4 bytes to get the size
//	int BUFFER_SIZE = 98851;
//	ByteBuffer* pByteBuffer = new (std::nothrow) ByteBuffer();
//	File file;
//	int readCnt;
//	byte bufferImg[BUFFER_SIZE];
//	int nWidth = 320;
//	int nHeight = 180;
//
//	// Populate ByteBuffer from remote PNG file data
//	pByteBuffer->Construct(BUFFER_SIZE);
//	file.Construct(pngPath, "r");
//	readCnt = file.Read(bufferImg, BUFFER_SIZE);
//	pByteBuffer->SetArray(bufferImg, 0, BUFFER_SIZE);
////	TryReturn(readCnt == BUFFER_SIZE, null, "Failed to read Image");
//
//
//	// Decode PNG data ByteBuffer to image data
//	Image* pImage = new (std::nothrow) Image();
////	TryReturn(pImage != null, null, "Failed to create Image");
//	r = pImage->Construct();
////	TryReturn(r == E_SUCCESS, null, "Failed to construct Image");
//	ByteBuffer* pByteBuffer1 = null;
//	pByteBuffer1 = pImage->DecodeToBufferN(*pByteBuffer, IMG_FORMAT_PNG, DECODEDFORMAT, nWidth, nHeight);
//
//	delete pImage;
//	__pPicture->SetByteBuffer(pByteBuffer1, nWidth, nHeight, DECODEDFORMAT);
//}

void
TizenRemoteCamera::GetRemoteImageN(void)
{
	result r = E_SUCCESS;
	int BUFFER_SIZE = 20000;
	ByteBuffer* pByteBuffer = new (std::nothrow) ByteBuffer();
	File file;
	byte bufferImg[BUFFER_SIZE];

	// Read from device
	int fd_rcmem =0;
	fd_rcmem = open("/dev/rc_mem", O_RDONLY);
	int fileSize = read(fd_rcmem, bufferImg, BUFFER_SIZE);
	close(fd_rcmem);

	// Error check
	if(fileSize == 0)
		return;

	// Copy to ByteBuffer
	pByteBuffer->Construct(fileSize);
	pByteBuffer->SetArray(bufferImg, 0, fileSize);

	// Decode PNG data ByteBuffer to image data
	int nWidth = 320;
	int nHeight = 180;
	Image* pImage = new (std::nothrow) Image();
	TryReturn(pImage != null, , "Failed to create Image");
	r = pImage->Construct();
	TryReturn(r == E_SUCCESS, , "Failed to construct Image");
	ByteBuffer* pByteBuffer1 = null;
	pByteBuffer1 = pImage->DecodeToBufferN(*pByteBuffer, IMG_FORMAT_PNG, DECODEDFORMAT, nWidth, nHeight);

	// Reset with new data
	delete pImage;
	delete __pPicture;
	__pPicture = null;
	__pPicture = new (std::nothrow) Info(PICTURE6, PICTURE_NAME);
	TryReturn(r == E_SUCCESS, , "Failed to construct image");
	__pPicture->SetByteBuffer(pByteBuffer1, nWidth, nHeight, DECODEDFORMAT);
}

void
TizenRemoteCamera::OnTimerExpired(Timer& timer)
{
	GetRemoteImageN();

	if(__stat == TIMER_STOP)
	{
		return;
	}

	result r = __pTimer->Start(INTERVAL);
	if (IsFailed(r))
	{
		AppLog("Timer Start Fail.\n");
		return;
	}
}

void
TizenRemoteCamera::StartRemoteCamera()
{
//// Test Code
	// Read first 4 bytes to get the size
	int BUFFER_SIZE = 98851;

	// Populate ByteBuffer from remote PNG file data
	byte bufferImg[BUFFER_SIZE];

	String pngPath = Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE6_PATH;
	File file;
	file.Construct(pngPath, "r");

	int readCnt;
	readCnt = file.Read(bufferImg, BUFFER_SIZE);

	// Write to device
	//int fd_rcmem =0;
	//fd_rcmem = open("/dev/rc_mem", O_WRONLY);
	//write(fd_rcmem, bufferImg, BUFFER_SIZE);
	//close(fd_rcmem);
//// Test Code

	__stat = TIMER_START;
	__pTimer->Start(INTERVAL);
}

void
TizenRemoteCamera::CaptureRemoteCamera()
{
	if(__stat != TIMER_START)
		return;
	else
		__imageCount++;

	result r = E_SUCCESS;
	Image img;

	img.Construct();
	Tizen::Base::String destPath = Tizen::System::Environment::GetMediaPath() + L"Images/capture";
	destPath.Append(__imageCount);
	destPath.Append(L".jpg");
	r = img.EncodeToFile(*__pPicture->GetBitmap(), IMG_FORMAT_JPG, destPath, true);
	if (IsFailed(r))
	{
		AppLog("Image save failed.\n");
		return;
	}
}

void
TizenRemoteCamera::StopRemoteCamera()
{
	__stat = TIMER_STOP;
	return;
}
