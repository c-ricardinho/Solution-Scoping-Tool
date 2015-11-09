using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Solution_Scoping_Tool
{
    public class CustomerServerTab
    {
        public string ServerName { get; set; }
        public string Qty { get; set; }
        public string ServerType { get; set; }
        public string OperatingSystem { get; set; }
        public string LogicalProcessors { get; set; }
        public string Utilisation { get; set; }
        public string RAM { get; set; }
        public string HDD1 { get; set; }
        public string HDD1Type { get; set; }
        public string HDD2 { get; set; }
        public string HDD2Type { get; set; }
        public string HDD3 { get; set; }
        public string HDD3Type { get; set; }
        public string HDD4 { get; set; }
        public string HDD4Type { get; set; }
        public string HDD5 { get; set; }
        public string HDD5Type { get; set; }
        public string vHostCluster { get; set; }
        public string VLAN { get; set; }
        public string Bandwidth { get; set; }
        public string LBPool { get; set; }
        public string Datacentre { get; set; }
        public string Database { get; set; }
        public string DatabaseCluster { get; set; }
        public string Notes { get; set; }
        public bool Include { get; set; }
    }

    public class CustomerSettings
    {
        public string CustomerName { get; set; }
        public bool DDoSPrevention { get; set; }
        public string DefaultBackupRetention { get; set; }
        public string DefaultMaximumUtilisation { get; set; }
        public string DesignIteration { get; set; }
        public string DesignOption { get; set; }
        public string GlobalTrafficManager { get; set; }
        public string IDSThreatManager { get; set; }
        public string LoadBalancer { get; set; }
        public bool LoadBalancerHA { get; set; }
        public bool LogManager { get; set; }
        public string PrimarySupportSegment { get; set; }
        public string ProjectName { get; set; }
        public string RackConnect { get; set; }
        public string SourceMHzPerCore { get; set; }
        public string Tier1Firewall { get; set; }
        public bool Tier1FirewallHA { get; set; }
        public string Tier2Firewall { get; set; }
        public bool Tier2FirewallHA { get; set; }
        public string VMSnapshotOverhead { get; set; }
        public string WebApplicationFirewall { get; set; }
        public bool WebApplicationFirewallHA { get; set; }
        public List<CustomerServerTab> CustomerServerTab { get; set; }
    }
}
