/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_AMBIENCE = 278617630U;
        static const AkUniqueID PLAY_BOSSMUSIC = 3463024606U;
        static const AkUniqueID PLAY_ITEMGET = 3545215997U;
        static const AkUniqueID PLAY_MAINMENUMUSIC = 667425441U;
        static const AkUniqueID PLAY_MUSIC = 2932040671U;
        static const AkUniqueID PLAY_WALKING = 1733885923U;
        static const AkUniqueID STOP_AMBIENCE = 2477713992U;
        static const AkUniqueID STOP_BOSSMUSIC = 656877296U;
        static const AkUniqueID STOP_MAINMENUMUSIC = 1307794083U;
        static const AkUniqueID STOP_MUSIC = 2837384057U;
        static const AkUniqueID STOP_WALKING = 165461773U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace ITEMTYPE
        {
            static const AkUniqueID GROUP = 4247838896U;

            namespace STATE
            {
                static const AkUniqueID CURSED = 1162897947U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID NORMAL = 1160234136U;
                static const AkUniqueID WIERD = 338436036U;
            } // namespace STATE
        } // namespace ITEMTYPE

    } // namespace STATES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID CORRUPTION = 1614265074U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMBIENCEBUS = 612772313U;
        static const AkUniqueID GETITEM = 154721382U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID AMBIENCE = 85412153U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
