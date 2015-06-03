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

#ifndef _INFO_H_
#define _INFO_H_

#include <FBase.h>
#include <FGraphics.h>
#include <FMedia.h>
#include <FBaseObject.h>
#include <FBaseColIComparer.h>
#include <FUix.h>

class Info
	: public Tizen::Base::Object
{
public:
	Info(void);
	Info(Tizen::Base::String fileName, Tizen::Base::String info);
	Info(const Info& ob);
	virtual ~Info(void);

	Tizen::Base::String GetFileName(void) const;
	Tizen::Base::String GetInfo(void) const;
	const Tizen::Graphics::Bitmap* GetBitmap(void) const;
	const Tizen::Base::ByteBuffer* GetByteBuffer(void) const;
	int GetWidth(void) const;
	int GetHeight(void) const;
	Tizen::Graphics::BitmapPixelFormat GetPixelFormat(void) const;
	int GetMatchingPercent(void) const;
	Tizen::Base::Collection::IList* GetFaceFeatures(void);
	Tizen::Uix::Vision::EyeState GetEyeState(void) const;
	Tizen::Uix::Vision::FacialExpression GetFacialExpression(void) const;

	void SetFileName(const Tizen::Base::String fileName);
	void SetInfo(const Tizen::Base::String info);
	void SetByteBuffer(Tizen::Base::ByteBuffer* byteBuffer, int width, int height, Tizen::Graphics::BitmapPixelFormat format);
	void SetMatchingPercent(int percent);
	void SetFaceFeatures(Tizen::Base::Collection::IList* pFeatures);
	void SetEyeState(Tizen::Uix::Vision::EyeState eyeState);
	void SetFacialExpression(Tizen::Uix::Vision::FacialExpression facialExpression);

	bool operator <(const Info& rhs) const;
	bool operator >(const Info& rhs) const;
	bool operator ==(const Info& rhs) const;
	bool operator !=(const Info& rhs) const;
	Info& operator =(const Info& rhs);
	bool operator ==(const Tizen::Base::String& fileName);
	bool operator <(const Tizen::Base::String& ob) const;
	bool operator >(const Tizen::Base::String& ob) const;

private:
	Tizen::Graphics::Bitmap* __pBitmap;
	Tizen::Base::ByteBuffer* __pByteBuffer;
	int __width;
	int __height;
	Tizen::Graphics::BitmapPixelFormat __pixelFormat;
	int __matchingPercent;
	Tizen::Base::Collection::IList* __pFaceFeatures;
	Tizen::Uix::Vision::EyeState __eyeState;
	Tizen::Uix::Vision::FacialExpression __facialExpression;
	Tizen::Base::String __fileName;
	Tizen::Base::String __info;
};

#endif // _INFO_H_
