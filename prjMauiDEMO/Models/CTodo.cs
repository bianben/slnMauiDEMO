namespace prjMAUIDEMO.Models
{
    public class CTodo
    {
        public int id { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public override string ToString() { return id + "/標題:" + title + "/期限:" + date; }
    }
}