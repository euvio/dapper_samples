using Dapper;
using Npgsql;

namespace _001
{
    /* Dynamic对象的属性大小写必须要与返回表的字段完全一致
     */

    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=postgres");
            string sql = """
                SELECT "Id","Name","Age" FROM "Dog";
                """;
            List<dynamic> dogs = connection.Query(sql).ToList();
            Assert.Equal(1000, dogs.Count());
            Assert.Equal(new Guid("0da8109c-91fa-c9e7-9695-1a3afdf30bbe"), (Guid)(dogs[0].Id));
            Assert.Equal("He Yunxi", dogs[0].Name as string);
            Assert.Equal(332, (int)(dogs[0].Age));
        }

        [Fact]
        public void Test2()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=postgres");
            string sql = """
                SELECT "Id" AS "ID", "Name" AS "name", "Age" AS "aGe" FROM "Dog";
                """;
            List<dynamic> dogs = connection.Query(sql).ToList();
            Assert.Equal(1000, dogs.Count());
            Assert.Equal(new Guid("0da8109c-91fa-c9e7-9695-1a3afdf30bbe"), (Guid)(dogs[0].ID));
            Assert.Equal("He Yunxi", dogs[0].name as string);
            Assert.Equal(332, (int)(dogs[0].aGe));
        }
    }
}