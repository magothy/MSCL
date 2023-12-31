/*****************************************************************************************
**          Copyright(c) 2015-2022 Parker Hannifin Corp. All rights reserved.           **
**                                                                                      **
**    MIT Licensed. See the included LICENSE.txt for a copy of the full MIT License.    **
*****************************************************************************************/

#include "stdafx.h"
#include "BaseStationFeatures_wsda.h"

namespace mscl
{
    BaseStationFeatures_wsda::BaseStationFeatures_wsda(const BaseStationInfo& info):
        BaseStationFeatures(info)
    {
    }

    bool BaseStationFeatures_wsda::supportsRfSweepMode() const
    {
        return false;
    }

    bool BaseStationFeatures_wsda::supportsCustomRfSweepMode() const
    {
        return false;
    }
}