using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Solution_Scoping_Tool
{
    public class CustomerSettings
    {
        public string CustomerName { get; set; }
        public string ProjectName { get; set; }
        public string DesignIteration { get; set; }
        public string DesignOption { get; set; }

        public string PrimarySupportSegment { get; set; }
        public string DefaultBackupRetention { get; set; }
        public string VMSnapshotOverhead { get; set; }
        public string DefaultMaximumUtilisation { get; set; }
        public string SourceMHzPerCore { get; set; }
        public string RackConnect { get; set; }
        public string DDoSPrevention { get; set; }
        public string Tier1Firewall { get; set; }
        public string Tier1FirewallHA { get; set; }
        public string Tier2Firewall { get; set; }
        public string Tier2FirewallHA { get; set; }
        public string LoadBalancer { get; set; }
        public string LoadBalancerHA { get; set; }
        public string IDSThreatManager { get; set; }
        public string LogManager { get; set; }
        public string WebApplicationFirewall { get; set; }
        public string WebApplicationFirewallHA { get; set; }
        public string GlobalTrafficManager { get; set; }
    }

}
