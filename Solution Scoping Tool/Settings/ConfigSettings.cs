using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_Scoping_Tool
{
    public class RootObject
    {
        public List<string> PrimarySupportSegment { get; set; }
        public List<string> DefaultBackupRetention { get; set; }
        public int VMSnapshotOverhead { get; set; }
        public int DefaultMaximumUtilisation { get; set; }
        public int SourceMHzPerCore { get; set; }
        public List<string> RackConnect { get; set; }
        public List<bool> DDoSPrevention { get; set; }
        public List<string> Tier1Firewall { get; set; }
        public List<string> Tier1FirewallHA { get; set; }
        public List<string> Tier2Firewall { get; set; }
        public List<string> Tier2FirewallHA { get; set; }
        public List<string> LoadBalancer { get; set; }
        public List<string> LoadBalancerHA { get; set; }
        public List<string> IDSThreatManager { get; set; }
        public List<bool> LogManager { get; set; }
        public List<string> WebApplicationFirewall { get; set; }
        public List<string> WebApplicationFirewallHA { get; set; }
        public List<string> GlobalTrafficManager { get; set; }
    }
}
