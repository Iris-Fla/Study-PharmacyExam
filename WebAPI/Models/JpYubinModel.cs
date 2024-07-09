namespace SqliteWebApiCoreDemo.Models
{
    public record JpYubinModel
    {

        public string 郵便番号 { get; set; } = string.Empty;

        public string 都道府県名 { get; set; } = string.Empty;
        
        public string 市区町村名 { get; set; } = string.Empty;

        public string 町域名 { get; set; } = string.Empty;

        public string 都道府県名カナ { get; set; } = string.Empty;

        public string 市区町村名カナ { get; set; } = string.Empty;

        public string 町域名カナ { get; set; } = string.Empty;

    }
}
