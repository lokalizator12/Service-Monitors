using changeResolution1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceMonitorEVK.Util_Managers
{
    public class MonitorManager
    {
        private readonly DisplayManager _displayManager;
        private readonly MonitorInfoManager _monitorInfoManager;
        private readonly ResolutionDisplayManager _resolutionManager;

        public MonitorManager(DisplayManager displayManager, MonitorInfoManager monitorInfoManager, ResolutionDisplayManager resolutionManager)
        {
            _displayManager = displayManager;
            _monitorInfoManager = monitorInfoManager;
            _resolutionManager = resolutionManager;
        }

        public Dictionary<string, string> GetMonitorNameToIdentifierMap()
        {
            var monitorNameToIdentifierMap = new Dictionary<string, string>();

            var monitorNames = _resolutionManager.GetMonitorNames();
            var friendlyNames = _monitorInfoManager.GetFriendlyMonitorNames();

            for (int i = 0; i < monitorNames.Count; i++)
            {
                var identifier = monitorNames[i];
                var friendlyName = friendlyNames[i];
                monitorNameToIdentifierMap[friendlyName] = identifier;
            }

            return monitorNameToIdentifierMap;
        }

        public List<string> GetResolutionsForMonitor(string monitorIdentifier)
        {
            return _resolutionManager.GetAvailableResolutions(monitorIdentifier)
                .OrderBy(r =>
                {
                    var parts = r.Split('x');
                    int width = int.Parse(parts[0]);
                    int height = int.Parse(parts[1]);
                    return width * height;
                }).ToList();
        }

        public void SetMaxResolutionForAllMonitors(Dictionary<string, string> monitorNameToIdentifierMap)
        {
            foreach (var kvp in monitorNameToIdentifierMap)
            {
                var identifier = kvp.Value;
                var maxResolution = _resolutionManager.GetMaxResolution(identifier);

                _resolutionManager.SetResolution(identifier, maxResolution.Width, maxResolution.Height);
            }
        }

    }


}
