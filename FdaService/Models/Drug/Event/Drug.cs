namespace FdaService.Models.Drug.Event
{
    public class Drug
    {
        public string drugtreatmentdurationunit { get; set; }
        public string drugauthorizationnumb { get; set; }
        public string drugtreatmentduration { get; set; }
        public string drugstartdateformat { get; set; }
        public string drugcharacterization { get; set; }
        public string drugindication { get; set; }
        public string medicinalproduct { get; set; }
        public string drugadministrationroute { get; set; }
        public string drugdosagetext { get; set; }
        public string drugstartdate { get; set; }
        public string drugenddate { get; set; }
        public string drugenddateformat { get; set; }
        public Openfda openfda { get; set; }
    }
}