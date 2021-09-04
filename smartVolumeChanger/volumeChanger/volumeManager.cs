using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartVolumeChanger
{
    static class volumeChanger
    {
        // <string, int> => ProcessName, Process
        public static SortedDictionary<string, int> sortedDic = new SortedDictionary<string, int>();
        public static SortedDictionary<string, int> update()
        {
            sortedDic.Clear();

            using (AudioSessionManager2 sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
            {
                using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                {
                    foreach (var session in sessionEnumerator)
                    {
                        using (var simpleVolume = session.QueryInterface<SimpleAudioVolume>())
                        using (var sessionControl = session.QueryInterface<AudioSessionControl2>())
                        {
                            try
                            {
                                sortedDic.Add(sessionControl.Process.ProcessName, (int)(simpleVolume.MasterVolume * 100));
                            }
                            catch (System.ArgumentException e)
                            {

                            }
                        }
                    }

                    return sortedDic;
                }
            }
        }

        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }
    }

}
