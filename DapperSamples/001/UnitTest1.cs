using Common;
using Dapper;
using Npgsql;

namespace _001
{
    /* ���ر��ֶ���Model���Ժ��Դ�Сд���졣
     * �� Name nAMe   AGE age ,���ǿ��еġ�
     * �� Name _Name������
     */
    public class UnitTest1
    {
        /// <summary>
        /// Model���Դ�Сд�뷵�ر��ֶ���ȫ��ͬ
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
        /// Model����ȫ��Сд�����ر��ֶδ��շ�
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
        /// Model���Դ�Сд��������ر��ֶδ��շ�
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