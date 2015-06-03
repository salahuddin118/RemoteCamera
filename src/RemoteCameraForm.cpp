
#include <new>
#include "RemoteCameraForm.h"
#include "InfoCompare.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Uix::Vision;
using namespace Tizen::Graphics;
using namespace Tizen::Media;
using namespace Tizen::Base::Collection;
using namespace Tizen::Base::Runtime;

static const BitmapPixelFormat DECODEDFORMAT = BITMAP_PIXEL_FORMAT_RGB565;
static const int SPACE_X = 10;
static const int SPACE_Y = 80;

static const int PICTURE_SIZE_M = 250;
static const int PICTURE_SIZE_L = 500;

static const int SCREEN_W = 480;

static const int LABEL_H = 200;

static const int FONT_SIZE = 50;
static const int FONT_SIZE_S = 25;

static const int TEXT_X = 70;
static const int TEXT_Y = 620;

static const int MARGIN = 10;
static const int COUNT3 = 3;

static const wchar_t* BUTTON1_NAME = L"Start";
static const wchar_t* BUTTON2_NAME = L"Stop";

static const wchar_t* PICTURE1 = L"sample1.png";
static const wchar_t* PICTURE2 = L"sample2.png";
static const wchar_t* PICTURE3 = L"sample3.png";
static const wchar_t* PICTURE4 = L"sample4.png";

static const wchar_t* PICTURE1_PATH = L"res/sample1.png";
static const wchar_t* PICTURE2_PATH = L"res/sample2.png";
static const wchar_t* PICTURE3_PATH = L"res/sample3.png";
static const wchar_t* PICTURE4_PATH = L"res/sample4.png";

static const wchar_t* PICTURE1_NAME = L"Unknown";
static const wchar_t* PICTURE2_NAME = L"Christine";
static const wchar_t* PICTURE3_NAME = L"Stephanie";
static const wchar_t* PICTURE4_NAME = L"Tom";

static const wchar_t* NO_PICTURE = L"No Picture";
static const wchar_t* NOT_FOUND = L"Not Found";

static const int INTERVAL = 10;
static const int TIMER_START = 200;
static const int TIMER_STOP = 202;

static String dstPath = Tizen::App::App::GetInstance()->GetAppRootPath() + L"data/test_out.jpg";


RemoteCameraForm::RemoteCameraForm(void)
	: __percent(1.0f)
	, __panelY(0)
	, __stat(0)
	, __count(0)
	, __pButton(null)
	, __pButton2(null)
	, __pPanel(null)
	, __pCanvas(null)
	, __pPicture(null)
	, __pTimer(null)
	, __pInfoList(null)
{
}

RemoteCameraForm::~RemoteCameraForm(void)
{
	delete __pCanvas;
	__pCanvas = null;
	delete __pPicture;
	__pPicture = null;
	delete __pInfoList;
	__pInfoList = null;
	delete __pTimer;
	 __pTimer = null;
}

result
RemoteCameraForm::OnInitializing(void)
{
	int width = 0;
	int height = 0;
	result r = E_SUCCESS;

	Footer* pFooter = this->GetFooter();

	// Create Timer
	__pTimer = new (std::nothrow) Timer();
	__pTimer->Construct(*this);

	if(pFooter != null)
	{
		pFooter->SetStyle(FOOTER_STYLE_BUTTON_TEXT);
		this->SetFormBackEventListener(this);

		FooterItem footerItemRecognize;
		footerItemRecognize.Construct(ID_BUTTON);
		footerItemRecognize.SetText(BUTTON1_NAME);
		pFooter->AddItem(footerItemRecognize);

		FooterItem footerItemSimilarity;
		footerItemSimilarity.Construct(ID_BUTTON2);
		footerItemSimilarity.SetText(BUTTON2_NAME);
		pFooter->AddItem(footerItemSimilarity);

		pFooter->AddActionEventListener(*this);
	}

	FaceRecognizer faceRecog;
	r = faceRecog.Construct();
	TryReturn(r == E_SUCCESS, E_FAILURE, "Failed to construct RemoteCamera");

	__pPicture = new (std::nothrow) Info(PICTURE1, PICTURE1_NAME);
	TryReturn(__pPicture != null, E_FAILURE, "Failed to create info");
	ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE1_PATH, width, height);
	__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
	if (height > PICTURE_SIZE_M - SPACE_X)
	{
		__percent = (double) PICTURE_SIZE_M / (double) height;
	}
	if (width > PICTURE_SIZE_L)
	{
		double temp = (double) PICTURE_SIZE_L / (double) width;
		if (temp < __percent)
		{
			__percent = temp;
		}
	}

	IList* pFaceList = faceRecog.ExtractFaceInfoFromStillImageN(*(__pPicture->GetByteBuffer()), Dimension(width, height), __pPicture->GetPixelFormat());
	if (pFaceList != null)
	{
		__pPicture->SetFaceFeatures(pFaceList);
		pFaceList->RemoveAll(true);
		delete pFaceList;
	}

	IMapT< Rectangle, EyeState >* pEyeStateIList = faceRecog.DetectBlinksFromStillImageN(*(__pPicture->GetByteBuffer()), Dimension(width, height), __pPicture->GetPixelFormat());
	if (pEyeStateIList != null)
	{
		IMapEnumeratorT< Rectangle, EyeState >* pMapEnum = pEyeStateIList->GetMapEnumeratorN();
		if (pMapEnum->MoveNext() == E_SUCCESS)
		{
			EyeState eyeState;
			pMapEnum->GetValue(eyeState);
			__pPicture->SetEyeState(eyeState);
		}
		delete pMapEnum;
		pEyeStateIList->RemoveAll();
		delete pEyeStateIList;
	}

	IMapT< Rectangle, FacialExpression >* pFacialExpressionIList = faceRecog.RecognizeExpressionsFromStillImageN(*(__pPicture->GetByteBuffer()), Dimension(width, height), __pPicture->GetPixelFormat());
	if (pFacialExpressionIList != null)
	{
		IMapEnumeratorT< Tizen::Graphics::Rectangle, FacialExpression >* pMapEnum = pFacialExpressionIList->GetMapEnumeratorN();
		if (pMapEnum->MoveNext() == E_SUCCESS)
		{
			FacialExpression facialExpression;
			pMapEnum->GetValue(facialExpression);
			__pPicture->SetFacialExpression(facialExpression);
		}
		delete pMapEnum;
		pFacialExpressionIList->RemoveAll();
		delete pFacialExpressionIList;
	}

	__pInfoList = new (std::nothrow) ArrayListT< Info >();
	TryReturn(__pInfoList != null, E_FAILURE, "Failed to create list");
	r = __pInfoList->Construct();
	TryReturn(r == E_SUCCESS, E_FAILURE, "Failed to construct List");

	Info* pInfo = new (std::nothrow) Info(PICTURE2, PICTURE2_NAME);
	TryReturn(pInfo != null, E_FAILURE, "Failed to create info");
	pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE2_PATH, width, height);
	pInfo->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
	pFaceList = faceRecog.ExtractFaceInfoFromStillImageN(*(pInfo->GetByteBuffer()), Dimension(width, height), pInfo->GetPixelFormat());
	if (pFaceList != null)
	{
		pInfo->SetFaceFeatures(pFaceList);
		pFaceList->RemoveAll(true);
		delete pFaceList;
		__pInfoList->Add(*pInfo);
		delete pInfo;
	}

	pInfo = new (std::nothrow) Info(PICTURE3, PICTURE3_NAME);
	TryReturn(pInfo != null, E_FAILURE, "Failed to create info");
	pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE3_PATH, width, height);
	pInfo->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
	pFaceList = faceRecog.ExtractFaceInfoFromStillImageN(*(pInfo->GetByteBuffer()), Dimension(width, height), pInfo->GetPixelFormat());
	if (pFaceList != null)
	{
		pInfo->SetFaceFeatures(pFaceList);
		pFaceList->RemoveAll(true);
		delete pFaceList;
		__pInfoList->Add(*pInfo);
		delete pInfo;
	}

	pInfo = new (std::nothrow) Info(PICTURE4, PICTURE4_NAME);
	TryReturn(pInfo != null, E_FAILURE, "Failed to create info");
	pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE4_PATH, width, height);
	pInfo->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
	pFaceList = faceRecog.ExtractFaceInfoFromStillImageN(*(pInfo->GetByteBuffer()), Dimension(width, height), pInfo->GetPixelFormat());
	if (pFaceList != null)
	{
		pInfo->SetFaceFeatures(pFaceList);
		pFaceList->RemoveAll(true);
		delete pFaceList;
		__pInfoList->Add(*pInfo);
		delete pInfo;
	}

	return E_SUCCESS;
}

void
RemoteCameraForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	result r = E_SUCCESS;
	switch (actionId)
	{
	case ID_BUTTON:
		if (__pPanel != null)
		{
			this->RemoveControl(__pPanel);
		}
		__pPanel = new (std::nothrow) ScrollPanel();
		TryReturn(__pPanel != null, , "Failed to create panel");
		r = __pPanel->Construct(Rectangle(0, __panelY, SCREEN_W, GetClientAreaBounds().height - __panelY));
		TryReturn(r == E_SUCCESS, , "Failed to construct panel");
		AddControl(__pPanel);

		//DoRecognizing();
		StartRemoteCamera();
		break;

	case ID_BUTTON2:
		if (__pPanel != null)
		{
			this->RemoveControl(__pPanel);
		}
		__pPanel = new (std::nothrow) ScrollPanel();
		TryReturn(__pPanel != null, , "Failed to create panel");
		r = __pPanel->Construct(Rectangle(0, __panelY, SCREEN_W, GetClientAreaBounds().height - __panelY));
		TryReturn(r == E_SUCCESS, , "Failed to construct panel");
		AddControl(__pPanel);

		//DoFaceSimilarity();
		StopRemoteCamera();
		break;

	default:
		break;
	}

	RequestRedraw();
}

result
RemoteCameraForm::OnDraw(void)
{
	result r = E_SUCCESS;

	__pCanvas = GetCanvasN();
	__pCanvas->Clear();

	r = DrawImage(__pPicture->GetBitmap());
	//r = DrawFaceDetectArea(__pPicture);

	return r;
}

ByteBuffer*
RemoteCameraForm::LoadImageN(String FileName, int& nWidth, int& nHeight)
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

result
RemoteCameraForm::DrawImage(const Bitmap* pBitmap)
{
	result r = E_SUCCESS;

	int img_width = 0;
	int img_height = 0;
	int client_width = 0;
	img_width = pBitmap->GetWidth() * __percent;
	img_height = pBitmap->GetHeight() * __percent;
	client_width = GetClientAreaBounds().width;

	r = __pCanvas->DrawBitmap(Rectangle(client_width/2 - img_width/2, SPACE_Y, img_width, img_height), *pBitmap);

	return r;
}

result
RemoteCameraForm::DrawFaceDetectArea(const Info* pInfo)
{
	result r = E_SUCCESS;

	Tizen::Base::Collection::IList* pFaceDetectList = GetFaceDetectAreaN(pInfo);

	int img_width = 0;
	int img_height = 0;
	int client_width = 0;
	img_width = pInfo->GetBitmap()->GetWidth() * __percent;
	img_height = pInfo->GetBitmap()->GetHeight() * __percent;
	client_width = GetClientAreaBounds().width;

	if (pFaceDetectList == null)
	{
		return E_OUT_OF_MEMORY;
	}

	for (int i = 0; i < pFaceDetectList->GetCount(); i++)
	{
		Tizen::Graphics::Rectangle* pRect = (Tizen::Graphics::Rectangle*) pFaceDetectList->GetAt(i);

		Rectangle rect((client_width/2 - img_width/2 + pRect->x * __percent), (SPACE_Y + pRect->y * __percent),
					   (pRect->width * __percent),
					   (pRect->height * __percent));

		if (__pCanvas == null || (rect.height <= 0 && rect.width <= 0))
		{
			pFaceDetectList->RemoveAll(true);
			delete pFaceDetectList;
			return E_INVALID_STATE;
		}

		__pCanvas->SetLineWidth(COUNT3);
		r = __pCanvas->DrawRectangle(rect);

		Font font;
		r = font.Construct(FONT_STYLE_PLAIN, FONT_SIZE_S);
		TryReturn(r == E_SUCCESS, E_FAILURE, "Failed to construct font");
		__pCanvas->SetFont(font);

		int xPos = SPACE_X * 2;
		int yPos = img_height + MARGIN;

		Tizen::Base::String text = L"Eye state : ";
		switch (pInfo->GetEyeState())
		{
		case EYE_STATE_BOTH_OPEN:
			text += L"Open";
			break;

		case EYE_STATE_BOTH_CLOSED:
			text += L"Closed";
			break;

		case EYE_STATE_NONE:
			text += L"Unknown";
			break;
		}
		r = __pCanvas->DrawText(Point(xPos, SPACE_Y + yPos), text);

		text = L"Expression : ";
		switch (pInfo->GetFacialExpression())
		{
		case FACIAL_EXPRESSION_NEUTRAL:
			text += L"Neutral";
			break;

		case FACIAL_EXPRESSION_ANGRY:
			text += L"Angry";
			break;

		case FACIAL_EXPRESSION_HAPPY:
			text += L"Happy";
			break;

		case FACIAL_EXPRESSION_SURPRISED:
			text += L"Surprised";
			break;

		case FACIAL_EXPRESSION_NONE:
			text += L"Unknown";
			break;
		}
		r = __pCanvas->DrawText(Point(xPos, SPACE_Y + yPos + FONT_SIZE_S + MARGIN), text);
		__panelY = SPACE_Y + yPos + (FONT_SIZE_S + MARGIN)*2 - GetClientAreaBounds().y;
	}

	pFaceDetectList->RemoveAll(true);
	delete pFaceDetectList;
	return r;
}

Tizen::Base::Collection::IList*
RemoteCameraForm::GetFaceDetectAreaN(const Info* pInfo)
{
	if (pInfo == null)
	{
		return null;
	}

	if (pInfo->GetWidth() > 0 && pInfo->GetHeight() > 0)
	{
		//Detect faces
		FaceDetector faceDetect;
		result r = faceDetect.Construct();
		TryReturn(r == E_SUCCESS, null, "Failed to construct FaceDetector");
		Tizen::Base::Collection::IList* pFaceDetectList = faceDetect.DetectFacesFromStillImageN(*(pInfo->GetByteBuffer()), Dimension(pInfo->GetWidth(), pInfo->GetHeight()), pInfo->GetPixelFormat());

		return pFaceDetectList;
	}

	return null;
}

void
RemoteCameraForm::SetTimer(void)
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
				__pPicture = new (std::nothrow) Info(PICTURE1, PICTURE1_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE1_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
				Draw();
			}
			break;

		case 1:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE2, PICTURE2_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE2_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
				Draw();
			}
			break;

		case 2:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE3, PICTURE3_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE3_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
				Draw();
			}
			break;

		case 3:
			if (__pPicture->GetBitmap() != null)
			{
				delete __pPicture;
				__pPicture = null;
				__pPicture = new (std::nothrow) Info(PICTURE4, PICTURE4_NAME);
				TryReturn(r == E_SUCCESS, , "Failed to construct image");
				ByteBuffer* pByteBuffer = LoadImageN(Tizen::App::App::GetInstance()->GetAppRootPath() + PICTURE4_PATH, width, height);
				__pPicture->SetByteBuffer(pByteBuffer, width, height, DECODEDFORMAT);
				Draw();
			}
			break;
	}

	AppLog("Timer: OnTimerExpired: %d", __count++);
	return;
}


void
RemoteCameraForm::OnTimerExpired(Timer& timer)
{
	SetTimer();

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
RemoteCameraForm::StartRemoteCamera()
{
	__stat = TIMER_START;
	__pTimer->Start(INTERVAL);
}

void
RemoteCameraForm::StopRemoteCamera()
{
	result r = E_SUCCESS;
	Image img;

	img.Construct();

	__stat = TIMER_STOP;
	r = img.EncodeToFile(*__pPicture->GetBitmap(), IMG_FORMAT_JPG, dstPath, true);
	if (IsFailed(r))
	{
		AppLog("Image save failed.\n");
		return;
	}

	return;
}

void
RemoteCameraForm::DoRecognizing()
{
	result r = E_SUCCESS;
	if (__pPicture->GetBitmap() == null)
	{
		Font font;
		r = font.Construct(FONT_STYLE_PLAIN | FONT_STYLE_BOLD, FONT_SIZE);
		TryReturn(r == E_SUCCESS, , "Failed to construct font");

		String Msg(NO_PICTURE);
		__pCanvas->SetFont(font);
		__pCanvas->DrawText(Point(TEXT_X, TEXT_Y), Msg);
		Draw();

		return;
	}

	if (__pPicture->GetBitmap()->GetWidth() <= 0 && __pPicture->GetBitmap()->GetHeight() <= 0)
	{
		return;
	}

	InfoCompare* pInfoComparer = new InfoCompare();
	TryReturn(pInfoComparer != null, , "Failed to create InfoCompare");
	pInfoComparer->SetCompareOpt(InfoCompare::SORT_BY_STRING);
	__pInfoList->Sort(*pInfoComparer);
	delete pInfoComparer;

	int label1X = 0;
	int label1W = GetClientAreaBounds().width / 2 - MARGIN * 2;
	int label2X = label1W - label1X - MARGIN;
	int label2W = GetClientAreaBounds().width - label2X - MARGIN * 2;
	int labelY = 0;

	bool IsMatching = false;

	for (int index = 0; index < __pInfoList->GetCount(); index++)
	{
		Info* pInfo = new (std::nothrow) Info();
		TryReturn(pInfo != null, , "Failed to create Info");
		__pInfoList->GetAt(index, *pInfo);

		if (FaceRecognize(__pPicture->GetFaceFeatures(), pInfo->GetFaceFeatures()))
		{
			__pPanel->SetShowState(true);

			Label* pLabel = new (std::nothrow) Label();
			if (pLabel == null && pInfo != null)
			{
				delete pInfo;
				return;
			}
			Label* pLabe2 = new (std::nothrow) Label();
			if (pLabe2 == null && pInfo != null)
			{
				delete pInfo;
				return;
			}

			String labelText = L" is Matched";
			labelText = pInfo->GetInfo() + labelText;

			r = pLabel->Construct(Rectangle(label1X, labelY, label1W, LABEL_H), labelText);
			if (r != E_SUCCESS)
			{
				delete pInfo;
				return;
			}
			pLabel->SetTextConfig(FONT_SIZE_S, LABEL_TEXT_STYLE_NORMAL);
			pLabel->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);

			r = pLabe2->Construct(Rectangle(label2X, labelY, label2W, LABEL_H), L"  ");
			if (r != E_SUCCESS)
			{
				delete pInfo;
				return;
			}

			const Bitmap* pBitmap = pInfo->GetBitmap();
			if (pBitmap == null)
			{
				continue;
			}

			Bitmap* pBackBitmap = new (std::nothrow) Bitmap();
			if (pBackBitmap == null && pInfo != null)
			{
				delete pInfo;
				return;
			}
			int width = pBitmap->GetWidth();
			int height = pBitmap->GetHeight();

			r = pBackBitmap->Construct(*pBitmap, Rectangle(0, 0, width, height));
			if (r != E_SUCCESS)
			{
				delete pInfo;
				return;
			}

			if (pBackBitmap != null)
			{
				pLabe2->SetBackgroundBitmap(*pBackBitmap);
				delete pBackBitmap;
			}

			__pPanel->AddControl(pLabel);
			__pPanel->AddControl(pLabe2);

			__pPanel->RequestRedraw(true);

			labelY += LABEL_H + MARGIN;
			IsMatching = true;
		}
		if (pInfo != null)
		{
			delete pInfo;
			pInfo = null;
		}
	}

	if (!IsMatching)
	{
		Font font;
		r = font.Construct(FONT_STYLE_PLAIN | FONT_STYLE_BOLD, FONT_SIZE);
		TryReturn(r == E_SUCCESS, , "Failed to construct font");

		String Msg(NOT_FOUND);
		__pCanvas->SetFont(font);
		__pCanvas->DrawText(Point(TEXT_X, TEXT_Y), Msg);
		Draw();

		return;
	}
}

bool
RemoteCameraForm::FaceRecognize(Tizen::Base::Collection::IList* pFaceDetectList1, Tizen::Base::Collection::IList* pFaceDetectList2)
{
	FaceRecognizer faceRecog;
	result r = faceRecog.Construct();
	TryReturn(r == E_SUCCESS, false, "Failed to construct RemoteCamera");

	if (pFaceDetectList1 == null || pFaceDetectList2 == null)
	{
		return false;
	}

	for (int i = 0; i < pFaceDetectList1->GetCount(); i++)
	{
		FaceRecognitionInfo* pFInfo1 = (Tizen::Uix::Vision::FaceRecognitionInfo*) pFaceDetectList1->GetAt(i);

		if (pFInfo1 == null)
		{
			break;
		}

		for (int j = 0; j < pFaceDetectList2->GetCount(); j++)
		{
			FaceRecognitionInfo* pFInfo2 = (Tizen::Uix::Vision::FaceRecognitionInfo*) (pFaceDetectList2->GetAt(j));
			if (pFInfo2 == null)
			{
				break;
			}
			if (faceRecog.IsMatching(*pFInfo1, *pFInfo2))
			{
				return true;
			}
		}
	}

	return false;
}

void
RemoteCameraForm::DoFaceSimilarity()
{
	result r = E_SUCCESS;
	if (__pPicture->GetBitmap() == null)
	{
		Font font;
		r = font.Construct(FONT_STYLE_PLAIN | FONT_STYLE_BOLD, FONT_SIZE);
		TryReturn(r == E_SUCCESS, , "Failed to construct font");

		String Msg(NO_PICTURE);
		__pCanvas->SetFont(font);
		__pCanvas->DrawText(Point(TEXT_X, TEXT_Y), Msg);
		Draw();

		return;
	}

	if (__pPicture->GetBitmap()->GetWidth() <= 0 && __pPicture->GetBitmap()->GetHeight() <= 0)
	{
		return;
	}

	for (int index = 0; index < __pInfoList->GetCount(); index++)
	{
		Info* pInfo = new (std::nothrow) Info();
		TryReturn(pInfo != null, , "Failed to create Info");
		__pInfoList->GetAt(index, *pInfo);

		int similarity = GetSimilarity(__pPicture->GetFaceFeatures(), pInfo->GetFaceFeatures());
		int before = pInfo->GetMatchingPercent();
		if (similarity > before)
		{
			__pInfoList->RemoveAt(index);
			pInfo->SetMatchingPercent(similarity);
			__pInfoList->InsertAt(*pInfo, index);
		}
		delete pInfo;
	}

	InfoCompare* pInfoComparer = new InfoCompare();
	TryReturn(pInfoComparer != null, , "Failed to create InfoCompare");
	pInfoComparer->SetCompareOpt(InfoCompare::SORT_DES);
	__pInfoList->Sort(*pInfoComparer);
	delete pInfoComparer;

	int label1X = 0;
	int label1W = GetClientAreaBounds().width / 2 - MARGIN * 2;
	int label2X = label1W - label1X - MARGIN;
	int label2W = GetClientAreaBounds().width - label2X - MARGIN * 2;
	int labelY = 0;

	bool IsSimilarity = false;

	for (int index = 0; index < __pInfoList->GetCount(); index++)
	{
		Info* pInfo = new (std::nothrow) Info();
		TryReturn(pInfo != null, , "Failed to create Info");
		__pInfoList->GetAt(index, *pInfo);

		if (pInfo != null && pInfo->GetMatchingPercent() > 0)
		{
			__pPanel->SetShowState(true);
			Label* pLabel = new (std::nothrow) Label();
			if (pLabel == null && pInfo != null)
			{
				delete pInfo;
				return;
			}
			Label* pLabe2 = new (std::nothrow) Label();
			if (pLabe2 == null && pInfo != null)
			{
				delete pInfo;
				return;
			}

			String labelText = pInfo->GetInfo();
			labelText.Append("'s\nsimilarity :\n");
			labelText.Append((int) pInfo->GetMatchingPercent());

			r = pLabel->Construct(Rectangle(label1X, labelY, label1W, LABEL_H), labelText);
			if (r != E_SUCCESS)
			{
				delete pInfo;
				return;
			}
			pLabel->SetTextConfig(FONT_SIZE_S, LABEL_TEXT_STYLE_NORMAL);
			pLabel->SetTextVerticalAlignment(ALIGNMENT_MIDDLE);

			r = pLabe2->Construct(Rectangle(label2X, labelY, label2W, LABEL_H), L"  ");
			if (r != E_SUCCESS)
			{
				delete pInfo;
				return;
			}

			const Bitmap* pBitmap = pInfo->GetBitmap();
			if (pBitmap == null)
			{
				continue;
			}

			Bitmap* pBackBitmap = new (std::nothrow) Bitmap();
			if (pBackBitmap == null && pInfo != null)
			{
				delete pInfo;
				return;
			}
			int width = pBitmap->GetWidth();
			int height = pBitmap->GetHeight();

			r = pBackBitmap->Construct(*pBitmap, Rectangle(0, 0, width, height));
			if (r != E_SUCCESS)
			{
				delete pInfo;
				return;
			}

			if (pBackBitmap != null)
			{
				pLabe2->SetBackgroundBitmap(*pBackBitmap);
				delete pBackBitmap;
			}

			__pPanel->AddControl(*pLabel);
			__pPanel->AddControl(*pLabe2);

			__pPanel->RequestRedraw(true);

			labelY += LABEL_H + MARGIN;
			IsSimilarity = true;
		}
		if (pInfo != null)
		{
			delete pInfo;
			pInfo = null;
		}
	}

	if (!IsSimilarity)
	{
		Font font;
		r = font.Construct(FONT_STYLE_PLAIN | FONT_STYLE_BOLD, FONT_SIZE);
		TryReturn(r == E_SUCCESS, , "Failed to construct font");

		String Msg(NOT_FOUND);
		__pCanvas->SetFont(font);
		__pCanvas->DrawText(Point(TEXT_X, TEXT_Y), Msg);
		Draw();

		return;
	}
}

int
RemoteCameraForm::GetSimilarity(Tizen::Base::Collection::IList* pFaceDetectList1, Tizen::Base::Collection::IList* pFaceDetectList2)
{
	int similarity = 0;
	int before = 0;

	FaceRecognizer faceRecog;
	result r = faceRecog.Construct();
	TryReturn(r == E_SUCCESS, -1, "Failed to construct RemoteCamera");

	if (pFaceDetectList1 == null || pFaceDetectList2 == null)
	{
		return 0;
	}

	for (int i = 0; i < pFaceDetectList1->GetCount(); i++)
	{
		FaceRecognitionInfo* pFInfo1 = (Tizen::Uix::Vision::FaceRecognitionInfo*) pFaceDetectList1->GetAt(i);

		if (pFInfo1 == null)
		{
			break;
		}

		for (int j = 0; j < pFaceDetectList2->GetCount(); j++)
		{
			FaceRecognitionInfo* pFInfo2 = (Tizen::Uix::Vision::FaceRecognitionInfo*) (pFaceDetectList2->GetAt(j));
			if (pFInfo2 != null)
			{
				similarity = faceRecog.MeasureSimilarity(*pFInfo1, *pFInfo2);

				if (similarity > before)
				{
					before = similarity;
				}
			}
		}
	}

	return before;
}

void
RemoteCameraForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	UiApp* pApp = UiApp::GetInstance();
	AppAssert(pApp);
	pApp->Terminate();
}
