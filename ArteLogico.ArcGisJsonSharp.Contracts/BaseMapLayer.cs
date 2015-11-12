namespace ArteLogico.ArcGisJsonSharp.Contracts
{
    public class BaseMapLayer
    {
        public string Id { get; set; }

        public bool IsReference { get; set; }

        public int Opacity { get; set; }

        public bool Visibility { get; set; }

        public string Url { get; set; }
    }
}