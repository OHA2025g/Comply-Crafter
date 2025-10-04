namespace ComplyCrafter_UI.Models
{
    public class AgendaViewModelEnabler
    {
        public bool enableAgendaDropDown { get; set; } = true;
        public bool enableAgendaHeading { get; set; } = true;
        public bool enableMinuteHeading { get; set; } = true;
        public bool enableNoticeCertificateTable { get; set; } = true;
        public bool enableResolutionForNoticePara2 { get; set; } = true;
        public bool enableMinutesCertificateTable { get; set; } = true;
        public bool enableResolutionForMinutesPara2 { get; set; } = true;
        public bool enableResolutionSignatory { get; set; } = false;
    }
}
