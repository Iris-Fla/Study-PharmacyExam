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
        /// —X•Ö”Ô†‚©‚çZŠî•ñ‚ğæ“¾‚·‚éAPI
        /// </summary>
        /// <param name="id">ŒŸõ‚·‚é—X•Ö”Ô†iƒnƒCƒtƒ“‚È‚µj</param>
        /// <returns></returns>
        [HttpGet(Name = "GetJpYubinModel")]
        public IEnumerable<JpYubinModel> Get(string id)
        {

            using var connection = new SqliteConnection($@"Data Source={_env.ContentRootPath}\Database\kenall.db");

            var sql = $$"""
        SELECT  field3 AS '—X•Ö”Ô†'
        ,       field7 AS '“s“¹•{Œ§–¼' 
        ,       field8 AS 's‹æ’¬‘º–¼' 
        ,       field9 AS '’¬ˆæ–¼' 
        ,       field4 AS '“s“¹•{Œ§–¼ƒJƒi' 
        ,       field5 AS 's‹æ’¬‘º–¼ƒJƒi' 
        ,       field6 AS '’¬ˆæ–¼ƒJƒi' 

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
        /// —X•Ö”Ô†‚©‚çZŠî•ñ‚ğæ“¾‚·‚éAPI
        /// </summary>
        /// <returns></returns>
        [HttpGet("JpTodou",Name = "GetJpTodou")]
        public IEnumerable<JpTodou> GetJpTodou()
        {

            using var connection = new SqliteConnection($@"Data Source={_env.ContentRootPath}\Database\kenall.db");

            var sql = $$"""SELECT DISTINCT field7 AS "Œ§–¼" FROM prefacture_name""";
            var parameters = new
            {
            };

            var command = new CommandDefinition(sql);

            var result = connection.Query<JpTodou>(command);

            return result;

        }
    }
}
