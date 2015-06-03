//
// Tizen C++ SDK
// Copyright (c) 2012-2013 Samsung Electronics Co., Ltd.
//
// Licensed under the Flora License, Version 1.1 (the License);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://floralicense.org/license/
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an AS IS BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#include "Info.h"

using namespace Tizen::Uix::Vision;
using namespace Tizen::Graphics;
using namespace Tizen::Media;
using namespace Tizen::Base;
using namespace Tizen::Base::Collection;

Info::Info(void)
	: __pBitmap(null)
	, __pByteBuffer(null)
	, __width(0)
	, __height(0)
	, __pixelFormat(BITMAP_PIXEL_FORMAT_ARGB8888)
	, __matchingPercent(0)
	, __pFaceFeatures(null)
	, __eyeState(EYE_STATE_NONE)
	, __facialExpression(FACIAL_EXPRESSION_NONE)
{
}

Info::Info(String fileName, String info)
	: __pBitmap(null)
	, __pByteBuffer(null)
	, __width(0)
	, __height(0)
	, __pixelFormat(BITMAP_PIXEL_FORMAT_ARGB8888)
	, __matchingPercent(0)
	, __pFaceFeatures(null)
	, __fileName(fileName)
	, __info(info)
{
}

Info::Info(const Info& rhs)
	: __pFaceFeatures(null)
{
	__fileName = rhs.__fileName;
	__info = rhs.__info;
	__matchingPercent = rhs.GetMatchingPercent();
	__eyeState = rhs.__eyeState;
	__facialExpression = rhs.__facialExpression;

	if(rhs.__pByteBuffer != null)
	{
		__pByteBuffer = new ByteBuffer();
		TryReturn(__pByteBuffer != null, , "Failed to create ByteBuffer");
		result r = __pByteBuffer->Construct(*rhs.__pByteBuffer);
		TryReturn(r == E_SUCCESS, , "Failed to construct ByteBuffer");
		__width = rhs.__width;
		__height = rhs.__height;
		__pixelFormat = rhs.__pixelFormat;
	}

	if(rhs.__pBitmap != null)
	{
		__pBitmap = new Bitmap();
		TryReturn(__pBitmap != null, , "Failed to create Bitmap");
		result r = __pBitmap->Construct(*__pByteBuffer, Dimension(__width, __height), __pixelFormat, BUFFER_SCALING_NONE);
		TryReturn(r == E_SUCCESS, , "Failed to construct Bitmap");
	}

	if (rhs.__pFaceFeatures != null)
	{
		SetFaceFeatures(rhs.__pFaceFeatures);
	}
}

Info::~Info(void)
{
	delete __pBitmap;
	delete __pByteBuffer;
	delete __pFaceFeatures;
}

String
Info::GetFileName(void) const
{
	return __fileName;
}

String
Info::GetInfo(void) const
{
	return __info;
}

const Bitmap*
Info::GetBitmap(void) const
{
	return __pBitmap;
}

const ByteBuffer*
Info::GetByteBuffer(void) const
{
	return __pByteBuffer;
}

int
Info::GetWidth(void) const
{
	return __width;
}

int
Info::GetHeight(void) const
{
	return __height;
}

BitmapPixelFormat
Info::GetPixelFormat(void) const
{
	return __pixelFormat;
}

int
Info::GetMatchingPercent(void) const
{
	return __matchingPercent;
}

Tizen::Uix::Vision::EyeState
Info::GetEyeState(void) const
{
	return __eyeState;
}

Tizen::Uix::Vision::FacialExpression
Info::GetFacialExpression(void) const
{
	return __facialExpression;
}

void
Info::SetFileName(const String fileName)
{
	__fileName = fileName;
}

void
Info::SetInfo(const String info)
{
	__fileName = info;
}

void
Info::SetByteBuffer(ByteBuffer* byteBuffer, int width, int height, Tizen::Graphics::BitmapPixelFormat format)
{
	__pByteBuffer = byteBuffer;
	__width = width;
	__height = height;
	__pixelFormat = format;

	if (__pBitmap == null)
	{
		__pBitmap = new (std::nothrow) Bitmap();
		TryReturn(__pBitmap != null, , "Failed to create Bitmap");

	}
	result r = __pBitmap->Construct(*__pByteBuffer, Dimension(__width, __height), __pixelFormat, BUFFER_SCALING_NONE);
	TryReturn(r == E_SUCCESS, , "Failed to construct Bitmap");
}

void
Info::SetMatchingPercent(int percent)
{
	__matchingPercent = percent;
}

Tizen::Base::Collection::IList*
Info::GetFaceFeatures(void)
{
	return __pFaceFeatures;
}

void
Info::SetFaceFeatures(Tizen::Base::Collection::IList* pFaceFeatures)
{
	delete __pFaceFeatures;
	TryReturn(pFaceFeatures != null, , "Failed to get face feature list");

	Tizen::Base::Collection::ArrayList* pList = new (std::nothrow) ArrayList();
	TryReturn(pList != null, , "Failed to create List");
	result r = pList->Construct();
	TryReturn(r == E_SUCCESS, , "Failed to construct List");

	for (int i = 0; i < pFaceFeatures->GetCount(); i++)
	{
		FaceRecognitionInfo* pFInfo = (Tizen::Uix::Vision::FaceRecognitionInfo*) pFaceFeatures->GetAt(i);
		FaceRecognitionInfo* pFInfoPhoto = new FaceRecognitionInfo();
		if (pFInfoPhoto == null && pList != null)
		{
			delete pList;
			return;
		}
		result r = pFInfoPhoto->Construct(*(pFInfo->GetFaceFeatures()));
		if (r != E_SUCCESS)
		{
			delete pList;
			return;
		}
		pList->Add(*pFInfoPhoto);
	}

	__pFaceFeatures = pList;
}

void
Info::SetEyeState(Tizen::Uix::Vision::EyeState eyeState)
{
	__eyeState = eyeState;
}

void
Info::SetFacialExpression(Tizen::Uix::Vision::FacialExpression facialExpression)
{
	__facialExpression = facialExpression;
}

bool
Info::operator <(const Info& rhs) const
{
	if (__matchingPercent < rhs.GetMatchingPercent())
	{
		return true;
	}
	return false;
}

bool
Info::operator >(const Info& rhs) const
{
	if (__matchingPercent > rhs.GetMatchingPercent())
	{
		return true;
	}
	return false;
}

bool
Info::operator ==(const Info& rhs) const
{
	if (__fileName.CompareTo(rhs.__fileName) == 0 &&
		__info.CompareTo(rhs.__info) == 0 &&
		__matchingPercent == rhs.__matchingPercent)
	{
		return true;
	}
	return false;
}

bool
Info::operator !=(const Info& rhs) const
{
	if (*this == rhs)
	{
		return false;
	}
	return true;
}

Info&
Info::operator =(const Info& rhs)
{
	if (this == &rhs)
	{
		return *this;
	}

	__fileName = rhs.__fileName;
	__info = rhs.__info;
	__matchingPercent = rhs.GetMatchingPercent();
	__eyeState = rhs.__eyeState;
	__facialExpression = rhs.__facialExpression;

	result r = E_SUCCESS;
	if (rhs.__pByteBuffer != null)
	{
		delete __pByteBuffer;
		__pByteBuffer = new (std::nothrow) ByteBuffer();
		TryCatch(__pByteBuffer != null, , "Failed to create ByteBuffer");
		r = __pByteBuffer->Construct(*rhs.__pByteBuffer);
		TryCatch(r == E_SUCCESS, , "Failed to construct ByteBuffer");
		__width = rhs.__width;
		__height = rhs.__height;
		__pixelFormat = rhs.__pixelFormat;
	}

	if (rhs.__pBitmap != null)
	{
		delete __pBitmap;
		__pBitmap = new (std::nothrow) Bitmap();
		TryCatch(__pBitmap != null, , "Failed to create Bitmap");
		r = __pBitmap->Construct(*__pByteBuffer, Dimension(__width, __height), __pixelFormat, BUFFER_SCALING_NONE);
		TryCatch(r == E_SUCCESS, , "Failed to construct Bitmap");
	}

	if (rhs.__pFaceFeatures != null)
	{
		SetFaceFeatures(rhs.__pFaceFeatures);
	}

CATCH:
	return *this;
}


bool
Info::operator ==(const String& fileName)
{
	if (__fileName.CompareTo(fileName) == 0)
	{
		return true;
	}
	return false;
}

bool
Info::operator <(const String& rhs) const
{
	if (__fileName.CompareTo(rhs) < 0)
	{
		return true;
	}
	return false;
}

bool
Info::operator >(const String& rhs) const
{
	if (__fileName.CompareTo(rhs) > 0)
	{
		return true;
	}
	return false;
}
