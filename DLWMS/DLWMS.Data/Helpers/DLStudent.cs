namespace DLWMS.Data.Helpers
{
    public struct DLStudent
    {
        public string Prezime { get; set; }
        public int GodinaStudija { get; set; }

        public override string ToString()
        {
            return $"Prezime: {Prezime} Godina studija: {GodinaStudija}";
        }
    }

}
