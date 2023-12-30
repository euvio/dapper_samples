using Common;
using Dapper;
using Npgsql;

namespace _001
{
    /* 返回表字段与Model属性忽略大小写差异。
     * 如 Name nAMe   AGE age ,都是可行的。
     * 如 Name _Name不可行
     */
    public class UnitTest1
    {
        /// <summary>
        /// Model属性大小写与返回表字段完全相同
        /// </summary>
        [Fact]
        public void Test1()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=postgres");
            string sql = """
                SELECT "Id","Name","Age" FROM "Dog";
                """;
            var dogs = connection.Query<StandardDog>(sql).ToList();
            Assert.Equal(1000, dogs.Count());
            Assert.Equal(new Guid("0da8109c-91fa-c9e7-9695-1a3afdf30bbe"), dogs[0].Id);
            Assert.Equal("He Yunxi", dogs[0].Name);
            Assert.Equal(332, dogs[0].Age);
        }

        /// <summary>
        /// Model属性全部小写，返回表字段大驼峰
        /// </summary>
        [Fact]
        public void Test2()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=postgres");
            string sql = """
                SELECT "Id","Name","Age" FROM "Dog";
                """;
            var dogs = connection.Query<LowerCaseDog>(sql).ToList();
            Assert.Equal(1000, dogs.Count());
            Assert.Equal(new Guid("0da8109c-91fa-c9e7-9695-1a3afdf30bbe"), dogs[0].id);
            Assert.Equal("He Yunxi", dogs[0].name);
            Assert.Equal(332, dogs[0].age);
        }

        /// <summary>
        /// Model属性大小写随机，返回表字段大驼峰
        /// </summary>
        [Fact]
        public void Test3()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=postgres");
            string sql = """
                SELECT "Id","Name","Age" FROM "Dog";
                """;
            var dogs = connection.Query<MixDog>(sql).ToList();
            Assert.Equal(1000, dogs.Count());
            Assert.Equal(new Guid("0da8109c-91fa-c9e7-9695-1a3afdf30bbe"), dogs[0].Id);
            Assert.Equal("He Yunxi", dogs[0].naME);
            Assert.Equal(332, dogs[0].AgE);
        }
    }
}