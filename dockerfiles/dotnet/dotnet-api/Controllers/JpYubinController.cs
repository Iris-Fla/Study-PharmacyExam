using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using SqliteWebApiCoreDemo.Models;

namespace SqliteWebApiCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JpYubinController : ControllerBase
    {

        private readonly ILogger<JpYubinController> _logger;
        private readonly IWebHostEnvironment _env;

        public JpYubinController(ILogger<JpYubinController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        /// <summary>
        /// 郵便番号から住所情報を取得するAPI
        /// </summary>
        /// <param name="id">検索する郵便番号（ハイフンなし）</param>
        /// <returns></returns>
        [HttpGet(Name = "GetJpYubinModel")]
        public IEnumerable<JpYubinModel> Get(string id)
        {

            using var connection = new SqliteConnection($@"Data Source={_env.ContentRootPath}\Database\kenall.db");

            var sql = $$"""
        SELECT  field3 AS '郵便番号'
        ,       field7 AS '都道府県名' 
        ,       field8 AS '市区町村名' 
        ,       field9 AS '町域名' 
        ,       field4 AS '都道府県名カナ' 
        ,       field5 AS '市区町村名カナ' 
        ,       field6 AS '町域名カナ' 

        FROM utf_ken_all
        WHERE field3 = @id
    """;
            var parameters = new
            {
                id = id
            };

            var command = new CommandDefinition(sql,parameters);

            var result = connection.Query<JpYubinModel>(command);

            return result;

        }
        /// <summary>
        /// 郵便番号から住所情報を取得するAPI
        /// </summary>
        /// <returns></returns>
        [HttpGet("JpTodou",Name = "GetJpTodou")]
        public IEnumerable<JpTodou> GetJpTodou()
        {

            using var connection = new SqliteConnection($@"Data Source={_env.ContentRootPath}\Database\kenall.db");

            var sql = $$"""SELECT DISTINCT field7 AS "県名" FROM prefacture_name""";
            var parameters = new
            {
            };

            var command = new CommandDefinition(sql);

            var result = connection.Query<JpTodou>(command);

            return result;

        }
    }
}
