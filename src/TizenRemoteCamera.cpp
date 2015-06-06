/*
 * TizenRemoteCamera.cpp
 *
 *  Created on: Jun 6, 2015
 *      Author: Salahuddin
 */

#include "TizenRemoteCamera.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Graphics;
using namespace Tizen::Media;
using namespace Tizen::Base::Runtime;
using namespace Tizen::Base::Collection;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Uix::Vision;

static const BitmapPixelFormat DECODEDFORMAT = BITMAP_PIXEL_FORMAT_RGB565;

static const wchar_t* PICTURE1 = L"sample1.png";
static const wchar_t* PICTURE2 = L"sample2.png";
static const wchar_t* PICTURE3 = L"sample3.png";
static const wchar_t* PICTURE4 = L"sample4.png";

static const wchar_t* PICTURE1_PATH = L"res/sample1.png";
static const wchar_t* PICTURE2_PATH = L"res/sample2.png";
static const wchar_t* PICTURE3_PATH = L"res/sample3.png";
static const wchar_t* PICTURE4_PATH = L"res/sample4.png";

static const wchar_t* PICTURE_NAME = L"Unknown";

static const int FPS = 10;
static const int INTERVAL = 1000/FPS;
static const int TIMER_START = 200;
static const int TIMER_STOP = 202;

static String dstPath = Tizen::App::App::GetInstance()->GetAppRootPath() + L"data/test_out.jpg";

TizenRemoteCamera::TizenRemoteCamera(void)
	: __percent(1.0f)
	, __panelY(0)
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
	return __pPicture->GetBitmap();
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

void
TizenRemoteCamera::GetRemoteImage(void)
{
	int width = 0;
	int height = 0;
	result r = E_SUCCESS;

	switch(__count%4)
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
	}

	AppLog("Timer: GetRemoteImage: %d", __count++);
	return;
}

void
TizenRemoteCamera::OnTimerExpired(Timer& timer)
{
	GetRemoteImage();

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
	__stat = TIMER_START;
	__pTimer->Start(INTERVAL);
}

void
TizenRemoteCamera::CaptureRemoteCamera()
{
	result r = E_SUCCESS;
	Image img;

	img.Construct();
	r = img.EncodeToFile(*__pPicture->GetBitmap(), IMG_FORMAT_JPG, dstPath, true);
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





