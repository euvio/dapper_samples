ÿ��SQL���ִ�н����᷵��һ�Ż���Ŷ�ά��ÿ��SQL����ʹ������3���������κ�1����ִ�У�������ʵ��ʹ��ʱ�����������ѡ����������ʵ�1��ִ��SQL��

�����ķ��صĶ�ά���ѡ��1��ֻ���ȡ��һ�ű�(��ʹ���ض��ű�)�ĵ�һ��Cell���ݣ���ѡ��2��������ȡ��һ�ű������CELL���ݻ����б������CELL�����ݣ���ѡ��3.

1. ExecuteNonQuery()
2. ExecuteScalar()
3. ExecuteReader()

// ��ɾ��
// insert/update/delete etc
var count  = connection.Execute(sql [, args]);
// ���в�
// multi-row query
IEnumerable<T> rows = connection.Query<T>(sql [, args]);
// ���в�
// single-row query ({Single|First}[OrDefault])
T row = connection.QuerySingle<T>(sql [, args]);

