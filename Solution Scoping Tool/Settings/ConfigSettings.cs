using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_Scoping_Tool
{
    public class InputTab
    {
        public List<string> PrimarySupportSegment { get; set; }
        public List<string> DefaultBackupRetention { get; set; }
        public int VMSnapshotOverhead { get; set; }
        public int DefaultMaximumUtilisation { get; set; }
        public int SourceMHzPerCore { get; set; }
        public List<string> RackConnect { get; set; }
        public List<bool> DDoSPrevention { get; set; }
        public List<string> Tier1Firewall { get; set; }
        public List<bool> Tier1FriewallHA { get; set; }
        public List<string> Tier2Firewall { get; set; }
        public List<bool> Tier2FirewallHA { get; set; }
        public List<string> LoadBalancer { get; set; }
        public List<bool> LoadBalancerHA { get; set; }
        public List<string> IDSThreatManager { get; set; }
        public List<bool> LogManager { get; set; }
        public List<string> WebApplicationFirewall { get; set; }
        public List<bool> WebApplicationFirewallHA { get; set; }
        public List<string> GlobalTrafficManager { get; set; }
    }

    public class OperatingSystem
    {
        public List<string> DedicatedOS { get; set; }
        public List<string> CloudOS { get; set; }
    }

    public class ServerTab
    {
        public List<string> ServerType { get; set; }
        public OperatingSystem OperatingSystem { get; set; }
        public List<string> HDDType { get; set; }
        public List<string> vHostCluster { get; set; }
        public List<string> Datacentre { get; set; }
        public List<string> Database { get; set; }
    }

    public class RootObject
    {
        public InputTab InputTab { get; set; }
        public ServerTab ServerTab { get; set; }
        public List<string> TestKey { get; set; }
    }
}
